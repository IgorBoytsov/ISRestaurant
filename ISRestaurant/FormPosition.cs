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
    public partial class FormPosition : Form
    {
        Regex regex = new Regex(@"^[А-Я][а-я\s]{0,30}$");
        public FormPosition()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Positions.Where(p=> p.name != "admin").ToList();

                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Position" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnPermission.Visible = permission.rule_insert & permission.rule_delete & permission.rule_update;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }
            }
        }

        private void FormPosition_FormClosed(object sender, FormClosedEventArgs e)
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
                MessageBox.Show("Ошб.004 Неверный формат вводимых данных пример \"Название должности\"");
            }
            else
            {
                using (Context db = new Context())
                {
                    if (db.Positions.Where(p => p.name == txtBoxName.Text).FirstOrDefault() != null)
                        MessageBox.Show("Ошб.005 Такая должность уже есть");
                    else
                    {
                        db.Positions.Add(new Position { name = txtBoxName.Text.Trim() , salary = Math.Abs((int)numericUpDown1.Value)});
                        txtBoxName.Text = "";

                        db.SaveChanges();
                        dataGridView1.DataSource = db.Positions.Where(p => p.name != "admin").ToList();
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
                MessageBox.Show("Ошб.003 Заполните поле!!");
            }
            else
            {
                using (Context db = new Context())
                {
                    Position updatePosition = db.Positions.Where(p => p.id_position == id).FirstOrDefault();
                    updatePosition.name = txtBoxName.Text;
                    updatePosition.salary = Math.Abs((int)numericUpDown1.Value);
                    txtBoxName.Text = "";

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такая должность уже есть");
                    }
                    dataGridView1.DataSource = db.Positions.Where(p => p.name != "admin").ToList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;

            DialogResult dialogResult =
                MessageBox.Show($"Удалить строки в количетве : {selected.Count} ", "Потверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            Position deletePosition;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deletePosition = db.Positions.Where(p => p.id_position == id).FirstOrDefault();
                    db.Positions.Remove(deletePosition);

                }
                db.SaveChanges();
                dataGridView1.DataSource = db.Positions.Where(p => p.name != "admin").ToList();

            }
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {

            FormPermission form = new FormPermission((int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            form.ShowDialog();
        }
    }
}
