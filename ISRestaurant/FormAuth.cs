using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Program.worker = db.Workers.Where(w => w.login == txtLogin.Text).FirstOrDefault();
                if (Program.worker != null && Program.worker.pass.Equals(txtPass.Text))
                {
                    this.Hide();
                    Program.formMain = new FormMain();
                    Program.formMain.Show();
                }
                else
                {
                    MessageBox.Show("Ошб.001 Неверный логин или пароль");
                }         
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAuth_Click(this, new EventArgs());
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
