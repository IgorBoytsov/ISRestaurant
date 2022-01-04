using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormMenu : Form
    {

        private void LoadGrid()
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Dishes.Join(db.Categories, d => d.id_category, c => c.id_category, (d, c) => new
                {
                    d.id_dish,
                    d.name,
                    d.calories,
                    category = c.name,
                    onSale = d.on_sale ? "В продаже" : " Заморожен"
                }).ToList();
                dataGridView1.ClearSelection();
            }
        }
        public FormMenu()
        {
            InitializeComponent();
            if (Program.worker.Position.name != "admin")
            {
                using (Context db = new Context())
                {

                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Dish" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;

                }
            }
            LoadGrid();

        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormDish form = new FormDish();
            form.ShowDialog();
            LoadGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;

            DialogResult dialogResult =
                MessageBox.Show($"Удалить строки в количетве : {selected.Count} ", "Потверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            Dish deleteDish;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deleteDish = db.Dishes.Where(w => w.id_dish == id).FirstOrDefault();

                    foreach (Ingredient item in deleteDish.Ingredients.ToList())
                    {
                        item.Dishes.Remove(deleteDish);
                    }

                    foreach (Price item in deleteDish.Prices.ToList())
                    {
                        db.Prices.Remove(item);
                    }

                    db.Dishes.Remove(deleteDish);

                }
                db.SaveChanges();
                LoadGrid();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (Context db = new Context())
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Dish dish = db.Dishes.Where(d => d.id_dish == id).FirstOrDefault();
                    dataGridView2.DataSource = dish.Ingredients.ToList();

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (Context db = new Context())
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    FormDish form = new FormDish(db.Dishes.Where(d => d.id_dish == id).FirstOrDefault());
                    form.ShowDialog();
                    LoadGrid();
                }
            }
        }
    }
}
