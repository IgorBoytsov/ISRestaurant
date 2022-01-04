using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.FormClosed += FormMain_FormClosed;

            if (Program.worker.Position.name != "admin")
            {

                foreach (Permission_table item in Program.worker.Position.Permission_table)
                {
                    string tableName;
                    using (Context db = new Context())
                    {
                        tableName = (db.tables.Where(t => t.id_table == item.id_table).First()).name;
                    }
                    switch (tableName)
                    {
                        case "Category":
                            btnCategory.Click -= btnErrorPer_Click;
                            btnCategory.Click += btnCategory_Click;
                            btnCategory.BackColor = Color.LightGray;
                            break;
                        case "Dish":
                            btnMenu.Click -= btnErrorPer_Click;
                            btnMenu.Click += btnMenu_Click;
                            btnMenu.BackColor = Color.LightGray;
                            break;
                        case "Ingredient":
                            btnIngredient.Click -= btnErrorPer_Click;
                            btnIngredient.Click += btnIngredient_Click;
                            btnIngredient.BackColor = Color.LightGray;
                            break;
                        case "Position":
                            btnPosition.Click -= btnErrorPer_Click;
                            btnPosition.Click += btnPosition_Click;
                            btnPosition.BackColor = Color.LightGray;
                            break;
                        case "Price":
                            btnPrice.Click -= btnErrorPer_Click;
                            btnPrice.Click += btnPrice_Click;
                            btnPrice.BackColor = Color.LightGray;
                            break;
                        case "Worker":
                            btnWorker.Click -= btnErrorPer_Click;
                            btnWorker.Click += btnWorker_Click;
                            btnWorker.BackColor = Color.LightGray;
                            break;
                        case "Order":
                            btnOrder.Click -= btnErrorPer_Click;
                            btnOrder.Click += btnOrder_Click;
                            btnOrder.BackColor = Color.LightGray;
                            break;
                        case "Querry":
                            btnQuerry.Click -= btnErrorPer_Click;
                            btnQuerry.Click += btnQuerry_Click;
                            btnQuerry.BackColor = Color.LightGray;
                            break;

                    }
                }
            }
            else
            {

                btnCategory.Click -= btnErrorPer_Click;
                btnCategory.Click += btnCategory_Click;
                btnCategory.BackColor = Color.LightGray;

                btnMenu.Click -= btnErrorPer_Click;
                btnMenu.Click += btnMenu_Click;
                btnMenu.BackColor = Color.LightGray;

                btnIngredient.Click -= btnErrorPer_Click;
                btnIngredient.Click += btnIngredient_Click;
                btnIngredient.BackColor = Color.LightGray;

                btnPosition.Click -= btnErrorPer_Click;
                btnPosition.Click += btnPosition_Click;
                btnPosition.BackColor = Color.LightGray;

                btnPrice.Click -= btnErrorPer_Click;
                btnPrice.Click += btnPrice_Click;
                btnPrice.BackColor = Color.LightGray;

                btnWorker.Click -= btnErrorPer_Click;
                btnWorker.Click += btnWorker_Click;
                btnWorker.BackColor = Color.LightGray;

                btnOrder.Click -= btnErrorPer_Click;
                btnOrder.Click += btnOrder_Click;
                btnOrder.BackColor = Color.LightGray;

                btnQuerry.Click -= btnErrorPer_Click;
                btnQuerry.Click += btnQuerry_Click;
                btnQuerry.BackColor = Color.LightGray;
            }

        }

        private void btnErrorPer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ошб.006 У вас нет прав для просмотра этой таблицы");
        }


        private void btnCategory_Click(object sender, EventArgs e)
        {
            FormCategory form = new FormCategory();
            form.Show();
            this.Hide();
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            FormIngredient form = new FormIngredient();
            form.Show();
            this.Hide();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            FormPrice form = new FormPrice();
            form.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrders form = new FormOrders();
            form.Show();
            this.Hide();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            FormWorker form = new FormWorker();
            form.Show();
            this.Hide();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FormPosition form = new FormPosition();
            form.Show();
            this.Hide();
        }

        private void btnQuerry_Click(object sender, EventArgs e)
        {
            FormQuerry form = new FormQuerry();
            form.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            this.Hide();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formAuth.Close();
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            this.FormClosed -= FormMain_FormClosed;
            Program.formAuth.Show();
            this.Close();
        }
    }
}
