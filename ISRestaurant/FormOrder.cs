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
    public partial class FormOrder : Form
    {
        private int orderId;
        private List<Order_cart> cart = new List<Order_cart>();
        private void LoadGrid()
        {
            using (Context db = new Context())
            {
                dataGridView2.DataSource = cart.Join(db.Dishes, c => c.id_dish, d => d.id_dish, (c, d) => new
                {
                    d.id_dish,
                    d.name,
                    c.amount
                }).ToList();
            }
        }


        public FormOrder()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                cmbDish.DataSource = db.Dishes.Where(d => db.Prices.Where(p => p.id_dish == d.id_dish).FirstOrDefault() != null).ToList();
                cmbWorker.DataSource = db.Workers.ToList();
            }
        }

        public FormOrder(Order order)
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                cmbDish.DataSource = db.Dishes.Where(d => db.Prices.Where(p => p.id_dish == d.id_dish).FirstOrDefault() != null).ToList();
                cmbWorker.DataSource = db.Workers.ToList();
            }

            orderId = order.id_order;
            btnAddOrder.Click -= btnAddOrder_Click;
            btnAddOrder.Click += btnUpdate_Click;
            btnAddOrder.Text = "Обновить";

            cart = order.Order_cart.ToList();
            numericUpDown1.Value = order.table_num;
            cmbWorker.SelectedValue = order.id_worker;

            LoadGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach (Order_cart d in cart)
            {
                if (d.id_dish == ((Dish)cmbDish.SelectedItem).id_dish)
                {
                    d.amount++;
                    check = true;
                    LoadGrid();
                }
            }

            if (check) return;
            cart.Add(new Order_cart { id_dish = ((Dish)cmbDish.SelectedItem).id_dish, amount = 1 });
            LoadGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (Order_cart d in cart)
            {
                if (d.id_dish == (int)dataGridView2.SelectedRows[0].Cells[0].Value)
                {
                    if (d.amount == 1)
                    {
                        cart.Remove(d);
                    }
                    else
                    {
                        d.amount--;
                    }

                    LoadGrid();
                    return;
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Ошб.003 Невозможно добавть пустой заказ");
                return;
            }

            using (Context db = new Context())
            {
                int price = 0;

                foreach (Order_cart c in cart)
                {
                    Price pr = (db.Prices.Where(p => p.id_dish == c.id_dish && p.date <= DateTime.Now).ToList()).OrderByDescending(p1 => p1.date).FirstOrDefault();
                    price += pr.price1 * c.amount;
                }

                db.Orders.Add(new Order
                {
                    date = DateTime.Now,
                    //id_worker = (int)cmbWorker.SelectedValue,
                    id_worker = Program.worker.id_worker,
                    table_num = (int)numericUpDown1.Value,
                    price = price,
                    Order_cart = cart
                });

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошб.1000 Непредвиденная ошибка");
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Ошб.003 Невозможно добавть пустой заказ");
                return;
            }

            Order updateOrder;

            using (Context db = new Context())
            {
                int price = 0;
                foreach (Order_cart c in cart)
                {
                    Price pr = (db.Prices.Where(p => p.id_dish == c.id_dish && p.date <= DateTime.Now).ToList()).OrderByDescending(p1 => p1.date).FirstOrDefault();
                    price += pr.price1 * c.amount;
                }

                updateOrder = db.Orders.Where(o => o.id_order == orderId).FirstOrDefault();

                //updateOrder.id_worker = (int)cmbWorker.SelectedValue;
                updateOrder.id_worker = Program.worker.id_worker;
                updateOrder.table_num = (int)numericUpDown1.Value;
                updateOrder.price = price;

                int[] ids = new int[cart.Count];
                for (int i = 0; i < cart.Count; i++) ids[i] = cart[i].id_dish;
             
                List<Order_cart> removeRange = new List<Order_cart>();
                foreach (Order_cart item in updateOrder.Order_cart)
                {
                    if (ids.Contains(item.id_dish))
                    {
                        foreach (Order_cart c in cart)                    
                            if (c.id_dish == item.id_dish) item.amount = c.amount;
                    }
                    else
                        removeRange.Add(item);
                }

                foreach (Order_cart c in removeRange) updateOrder.Order_cart.Remove(c);

                ids = new int[updateOrder.Order_cart.Count];
                for (int i = 0; i < updateOrder.Order_cart.Count; i++) ids[i] = updateOrder.Order_cart.ToList()[i].id_dish;
               
                foreach (Order_cart c in cart)
                    if (!ids.Contains(c.id_dish))  updateOrder.Order_cart.Add(c);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошб.1000 Непредвиденная ошибка");
                }

            }
        }

    }
}
