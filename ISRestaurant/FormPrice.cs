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
    public partial class FormPrice : Form
    {

        private void LoadGrid()
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Prices.Join(db.Dishes, p => p.id_dish, d => d.id_dish, (p,d) => new
                {
                    p.date,
                    d.name,
                    price = p.price1
                }).ToList();
                dataGridView1.ClearSelection();

            }
        }

        public FormPrice()
        {
            InitializeComponent();
            LoadGrid();
            using (Context db = new Context())
            {
                cmBoxDish.DataSource = db.Dishes.ToList();

                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Price" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }

            }
        }

        private void FormPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmBoxDish.SelectedIndex == -1 )
            {
                MessageBox.Show("Ошб.003 Заполните поля");
            }
            else
            {

                using (Context db = new Context())
                {

                    db.Prices.Add(
                        new Price
                        {
                            date = dateTimePicker1.Value,
                            price1 = (int)numericUpDown1.Value,
                            id_dish = (int)cmBoxDish.SelectedValue,
                        });

                    try
                    {
                        db.SaveChanges();
                        LoadGrid();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такая запись уже существует\nНевозможно выставить цену блюда 2 раза в один день");
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Price updatePrice;
            int dishId;
            DateTime dateTime;

            using (Context db = new Context())
            {
                dishId = (int)cmBoxDish.SelectedValue;
                dateTime = (DateTime)dataGridView1.SelectedRows[0].Cells[0].Value;

                updatePrice = db.Prices.Where(p => p.id_dish == dishId && p.date == dateTime).FirstOrDefault();

                updatePrice.date = dateTime;
                updatePrice.id_dish = dishId;
                updatePrice.price1 = (int)numericUpDown1.Value;

                try
                {
                    db.SaveChanges();
                    LoadGrid();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Ошб.005 Такая запись уже существует\nНевозможно выставить цену блюда 2 раза в один день");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;

            DialogResult dialogResult =
                MessageBox.Show($"Удалить строки в количетве : {selected.Count} ", "Потверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            Price deletePrice;
            int dishId;
            DateTime dateTime;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    string temp = row.Cells[1].Value.ToString();
                    dishId = (db.Dishes.Where(d => d.name == temp).FirstOrDefault()).id_dish;
                    dateTime = (DateTime)row.Cells[0].Value;

                    deletePrice = db.Prices.Where(p => p.id_dish == dishId && p.date == dateTime).FirstOrDefault();
                    db.Prices.Remove(deletePrice);
                }
                db.SaveChanges();
                LoadGrid();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                numericUpDown1.Value = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[0].Value;

                string nameDish = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                using (Context db = new Context())
                {
                    cmBoxDish.SelectedValue = (
                        db.Dishes.Where(d => d.name == nameDish).FirstOrDefault()).id_dish;
                }
            }
        }
    }
}
