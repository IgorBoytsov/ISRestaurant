using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormCategory : Form
    {
        Regex regex = new Regex(@"^[А-Я][а-я\s]{0,30}$");
        public FormCategory()
        {
            InitializeComponent();

            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Categories.ToList();

                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Category" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }
            }
        }

        private void FormCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Length > 30)
            {
                MessageBox.Show("Ошб.002 Недопустимая длина!! Максимальная длина : 30");
            }
            else if (txtBoxName.Text.Length == 0)
            {
                MessageBox.Show("Ошб.003 Заполните поля");
            }
            else if (!regex.IsMatch(txtBoxName.Text))
            {
                MessageBox.Show("Ошб.004 Неверный формат вводимых данных пример \"Название категории\"");
            }
            else
            {
                using (Context db = new Context())
                {
                    if (db.Categories.Where(c => c.name == txtBoxName.Text).FirstOrDefault() != null)
                        MessageBox.Show("Ошб.005 Такая категория уже есть");
                    else
                    {
                        db.Categories.Add(new Category { name = txtBoxName.Text.Trim() });
                        txtBoxName.Text = "";

                        db.SaveChanges();
                        dataGridView1.DataSource = db.Categories.ToList();
                    }
                     
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;

            if (txtBoxName.Text.Length > 30)
            {
                MessageBox.Show("Ошб.002 Недопустимая длина!! Максимальная длина : 30");
            }
            else if (txtBoxName.Text.Length == 0)
            {
                MessageBox.Show("Ошб.003 Заполните поля");
            }
            else if (!regex.IsMatch(txtBoxName.Text))
            {
                MessageBox.Show("Ошб.004 Неверный формат вводимых данных пример \"Название категории\"");
            }
            else
            {
                using (Context db = new Context())
                {
                    Category updateCategory = db.Categories.Where(c => c.id_category == id).FirstOrDefault();
                    updateCategory.name = txtBoxName.Text;
                    txtBoxName.Text = "";

                    try
                    {
                        db.SaveChanges();
                        dataGridView1.DataSource = db.Categories.ToList();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такая категория уже есть");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;

            DialogResult dialogResult =
                MessageBox.Show($"Удалить строки в количетве : {selected.Count} ", "Потверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            Category deleteCategory;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deleteCategory = db.Categories.Where(c => c.id_category == id).FirstOrDefault();
                    db.Categories.Remove(deleteCategory);

                }
                db.SaveChanges();
                dataGridView1.DataSource = db.Categories.ToList();

            }
        }
    }
}
