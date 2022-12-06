using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPraktika
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuFrom());
        }

    }

    class ConnSql
    {
        public string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";
    
    }
}
