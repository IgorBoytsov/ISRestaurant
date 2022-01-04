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
    public partial class FormQuerry : Form
    {
        public FormQuerry()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                lblCountOrders.Text += db.Orders.ToList().Count;
                lblCountWorkers.Text += db.Workers.ToList().Count;

                int profit = 0;

                foreach (Order item in db.Orders.ToList())
                {
                    profit += item.price;
                }
                lblProfit.Text += $"{profit} руб.";

                int idWorker = 0;
                int countOrder = 0;
                foreach (var var in db.Orders.ToList().GroupBy(o => o.id_worker))
                {
                    if (countOrder < var.ToList().Count)
                    {
                        idWorker = var.Key;
                        countOrder = var.ToList().Count;
                    }
                }

                lblBestWorker.Text += $"{db.Workers.Where(w => w.id_worker == idWorker).FirstOrDefault().full_name} \n{countOrder} Выполненых заказов !!!.";

            }
        }

        private void FormQuerry_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }

        class anyList
        {
            public string Name;
            public int Count;
            static List<anyList> dishes = new List<anyList>();
            static public List<anyList> ToList()
            {
                return dishes;
            }
            static public void Clear()
            {
                dishes.Clear();
            }
            public static void Add(string name, int amount)
            {
                bool find = false;

                foreach (anyList item in dishes)
                {
                    if (item.Name == name)
                    {
                        item.Count += amount;
                        find = true;
                    }
                }

                if (!find)
                {
                    dishes.Add(new anyList { Name = name, Count = amount });
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            anyList.Clear();

            if (tabControl1.SelectedIndex == 0)
            {
                chart1.Series["Profit"].Points.Clear();

                dataGridView1.Columns.Add("w", "Дата");
                dataGridView1.Columns.Add("w", "Счет");

                DateTime starDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                starDate = starDate.AddHours(-starDate.Hour);
                starDate = starDate.AddMinutes(-starDate.Minute);
                starDate = starDate.AddSeconds(-starDate.Second);

                if (checkBox1.Checked)
                {
                    while (starDate <= endDate)
                    {
                        int profit = 0;
                        using (Context db = new Context())
                        {

                            foreach (Order item in db.Orders.Where(o => o.date == starDate).ToList())
                            {
                                profit += item.price;
                            }
                            chart1.Series["Profit"].Points.AddXY(starDate.ToString(), profit);

                            if (profit > 0) dataGridView1.Rows.Add(starDate.ToShortDateString(), profit);
                        }

                        starDate = starDate.AddDays(1);
                    }
                }
                else
                {
                    starDate = starDate.AddDays(-starDate.Day);
                    while (starDate <= endDate)
                    {
                        int profit = 0;
                        DateTime temp = starDate.AddMonths(1);
                        using (Context db = new Context())
                        {
                            foreach (Order item in db.Orders.Where(o => o.date >= starDate && o.date < temp && o.date < endDate).ToList())
                            {
                                profit += item.price;
                            }
                            chart1.Series["Profit"].Points.AddXY(starDate.ToString(), profit);
                            if (profit > 0) dataGridView1.Rows.Add(starDate.Month + "." + starDate.Year, profit);
                        }

                        starDate = temp;
                    }
                }
            }

            if (tabControl1.SelectedIndex == 1)
            {
                chart2.Series["pie"].Points.Clear();

                dataGridView1.Columns.Add("w", "Название");
                dataGridView1.Columns.Add("w", "Кол-во");

                DateTime starDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                using (Context db = new Context())
                {
                    List<Order> orders = db.Orders.Where(o => o.date >= starDate && o.date < endDate).ToList();


                    foreach (Order item in orders)
                    {
                        foreach (Order_cart cart in item.Order_cart)
                        {
                            anyList.Add(cart.Dish.name, cart.amount);
                        }
                    }

                    foreach (anyList elem in anyList.ToList())
                    {
                        chart2.Series["pie"].Points.AddXY(elem.Name, elem.Count);
                        dataGridView1.Rows.Add(elem.Name, elem.Count);
                    }
                }
            }

            if (tabControl1.SelectedIndex == 2)
            {
                chart3.Series["pie"].Points.Clear();

                dataGridView1.Columns.Add("w", "Рабочий");
                dataGridView1.Columns.Add("w", "Заказов");

                DateTime starDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                using (Context db = new Context())
                {
                    List<Order> orders = db.Orders.Where(o => o.date >= starDate && o.date < endDate).ToList();

                    foreach (Order item in orders)
                    {
                        anyList.Add(item.Worker.full_name, 1);
                    }

                    foreach (anyList elem in anyList.ToList())
                    {
                        chart3.Series["pie"].Points.AddXY(elem.Name, elem.Count);
                        dataGridView1.Rows.Add(elem.Name, elem.Count);
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
