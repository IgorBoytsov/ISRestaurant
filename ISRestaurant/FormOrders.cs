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
    public partial class FormOrders : Form
    {
        private void LoadGrid()
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Orders.Join(db.Workers, o => o.id_worker, w => w.id_worker, (o, w) => new
                {
                    o.id_order,
                    w.full_name,
                    o.table_num,
                    o.date,
                    o.price
                }).ToList();
                dataGridView1.ClearSelection();
            }
        }

        public FormOrders()
        {
            InitializeComponent();
            LoadGrid();

            using (Context db = new Context())
            {
                if (Program.worker.Position.name != "admin")
                {
                    Permission_table permission = db.Permission_table.Where(t => t.table.name == "Order" && t.id_position == Program.worker.id_position).First();

                    btnInsert.Visible = permission.rule_insert;
                    btnDelete.Visible = permission.rule_delete;
                    btnUpdate.Visible = permission.rule_update;
                }
            }
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Order order;
                using (Context db = new Context())
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    order = db.Orders.Where(o => o.id_order == id).FirstOrDefault();
                    dataGridView2.DataSource = order.Order_cart.Join(db.Dishes, o => o.id_dish, d => d.id_dish, (o, d) => new
                    {
                        o.id_order,
                        d.name,
                        o.amount
                    }).ToList();
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormOrder form = new FormOrder();
            form.ShowDialog();
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (Context db = new Context())
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    FormOrder form = new FormOrder(db.Orders.Where(o => o.id_order == id).FirstOrDefault());
                    form.ShowDialog();
                    LoadGrid();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;

            DialogResult dialogResult =
                MessageBox.Show($"Удалить строки в количетве : {selected.Count} ", "Потверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            Order deleteOrder;
            int id;

            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in selected)
                {
                    id = (int)row.Cells[0].Value;

                    deleteOrder = db.Orders.Where(o => o.id_order == id).FirstOrDefault();

                    db.Order_cart.RemoveRange(deleteOrder.Order_cart);
                    db.Orders.Remove(deleteOrder);

                }
                db.SaveChanges();
                LoadGrid();

            }
        }

    }
}
