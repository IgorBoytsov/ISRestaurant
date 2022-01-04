using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormWorker : Form
    {
        Regex regFullName = new Regex(@"^[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}\s?[А-Я]?[а-я]{0,15}$");
        Regex regPhone = new Regex(@"^((\+7|7|8)+([0-9]){10})$");
        private void LoadGrid()
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Workers.Join(db.Positions, w => w.id_position, p => p.id_position, (w, p) => new
                {
                    w.id_worker,
                    w.full_name,
                    positionName = p.name,
                    w.phone,
                    w.birth_date,
                    w.login
                }).ToList();
                dataGridView1.ClearSelection();
            }
        }
        public FormWorker()
        {
            InitializeComponent();
            LoadGrid();
            using (Context db = new Context())
            {
                cmBoxPosition.DataSource = db.Positions.ToList();

                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Worker" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }
            }
        }

        private void FormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!regFullName.IsMatch(txtBoxName.Text))
            {
                MessageBox.Show("Ошб.007 Неверный формат ФИО.\nПример коректного ввода \"Иванов Иван Иваныч\" или  \"Иванов Иван\"");
                return;
            }

            if (cmBoxPosition.Text == "admin")
            {
                MessageBox.Show("Ошб.008 Невозможно создать сотрудника с должностью: " + cmBoxPosition.Text);
                return;
            }

            if (!regPhone.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("Ошб.009 Неверный формат номера.");
                return;
            }

            if (cmBoxPosition.SelectedIndex == -1 || txtBoxName.TextLength == 0 || txtPhone.TextLength == 0 || txtPass.TextLength == 0 || txtLogin.TextLength == 0)
            {
                MessageBox.Show("Ошб.003 Заполните поля!!");
                return;
            }
            else
            {
                using (Context db = new Context())
                {

                    if (db.Workers.Where(w => w.login == txtLogin.Text).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Ошб.005 Логин занят");
                        return;
                    }

                    db.Workers.Add(
                        new Worker
                        {
                            full_name = txtBoxName.Text,
                            id_position = (int)cmBoxPosition.SelectedValue,
                            birth_date = dateTimePicker1.Value,
                            phone = txtPhone.Text,
                            login = txtLogin.Text,
                            pass = txtPass.Text
                        }) ;

                    txtPass.Text = ""; 

                    try
                    {
                        db.SaveChanges();
                        LoadGrid();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такая запись уже существует");
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

            Worker deleteWorker;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deleteWorker = db.Workers.Where(w => w.id_worker == id).FirstOrDefault();
                    db.Workers.Remove(deleteWorker);

                }
                db.SaveChanges();
                LoadGrid();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
                txtLogin.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                string namePos = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                using (Context db = new Context())
                {
                    cmBoxPosition.SelectedValue = (
                        db.Positions.Where(p => p.name == namePos).FirstOrDefault()).id_position;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Worker updateWorker;
            if (!regFullName.IsMatch(txtBoxName.Text))
            {
                MessageBox.Show("Ошб.007 Неверный формат ФИО.\nПример коректного ввода \"Иванов Иван Иваныч\" или  \"Иванов Иван\"");
                return;
            }

            if (cmBoxPosition.Text == "admin")
            {
                MessageBox.Show("Ошб.008 Невозможно создать сотрудника с должностью: " + cmBoxPosition.Text);
                return;
            }

            if (!regPhone.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("Ошб.009 Неверный формат номера.");
                return;
            }

            if (cmBoxPosition.SelectedIndex == -1 || txtBoxName.TextLength == 0 || txtPhone.TextLength == 0 ||  txtLogin.TextLength == 0)
            {
                MessageBox.Show("Ошб.003 Заполните поля!!");
                return;
            }

            using (Context db = new Context())
            {

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                updateWorker = db.Workers.Where(w => w.id_worker == id).FirstOrDefault();

                updateWorker.birth_date = dateTimePicker1.Value;
                updateWorker.phone = txtPhone.Text;
                updateWorker.id_position = (int)cmBoxPosition.SelectedValue;
                updateWorker.full_name = txtBoxName.Text;
                updateWorker.login = txtLogin.Text;

                if (txtPass.Text.Length != 0)
                {
                    updateWorker.pass = txtPass.Text;
                }

                try
                {
                    db.SaveChanges();
                    LoadGrid();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Ошб. 005 Такая запись уже существует");
                }
            }
        }
    }

}
