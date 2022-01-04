using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    static class Program
    {
        public static FormMain formMain;
        public static FormAuth formAuth;
        public static Worker worker;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formAuth = new FormAuth();
            Application.Run(formAuth);
        }
    }
}
