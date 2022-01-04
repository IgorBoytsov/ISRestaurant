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
    public partial class FormIngredient : Form
    {
        Regex regex = new Regex(@"^[А-Я][а-я\s]{0,30}$");
        public FormIngredient()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Ingredients.ToList();
                dataGridView1.ClearSelection();

                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Ingredient" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }
            }
        }

        private void FormIngredient_FormClosed(object sender, FormClosedEventArgs e)
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
                MessageBox.Show("Ошб.004 Неверный формат вводимых данных пример \"Луковый кольца\"");
            }
            else
            {
                using (Context db = new Context())
                {
                    if (db.Ingredients.Where(i => i.name == txtBoxName.Text).FirstOrDefault() != null)
                        MessageBox.Show("Ошб.005 Такой ингридиент уже есть");
                    else
                    {
                        db.Ingredients.Add(
                            new Ingredient
                            {
                                name = txtBoxName.Text.Trim(),
                                price = (int)numericUpDown1.Value
                            }) ;
                        txtBoxName.Text = "";
                        numericUpDown1.Value = 0;

                        db.SaveChanges();
                        dataGridView1.DataSource = db.Ingredients.ToList();
                        dataGridView1.ClearSelection();
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
            else
            {
                using (Context db = new Context())
                {
                    Ingredient updateIngredient = db.Ingredients.Where(i => i.id_ingredient == id).FirstOrDefault();
                    updateIngredient.name = txtBoxName.Text;
                    updateIngredient.price = (int)numericUpDown1.Value;

                    txtBoxName.Text = "";
                    numericUpDown1.Value = 0;

                    try
                    {
                        db.SaveChanges();
                        dataGridView1.DataSource = db.Ingredients.ToList();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такой ингридиент уже есть");
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

            Ingredient deleteIngredient;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deleteIngredient = db.Ingredients.Where(i => i.id_ingredient == id).FirstOrDefault();
                    db.Ingredients.Remove(deleteIngredient);

                }
                db.SaveChanges();
                dataGridView1.DataSource = db.Ingredients.ToList();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                numericUpDown1.Value = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
                txtBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
            }
        }
    }
}
