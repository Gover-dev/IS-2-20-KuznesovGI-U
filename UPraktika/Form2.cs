using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace UPraktika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";


        public class ConnSQL
        { 
            public static MySqlConnection GetConnection(MySqlConnection mySql)
            {
                try
                {
                    return mySql;
                }

                catch (Exception )
                {
                    return null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connect);

            try
            {
                listBox2.Items.Add("Подключение...");
            }

            catch (Exception)
            {
                listBox2.Items.Add("ОШИБКА!");
            }

            finally
            {
                listBox2.Items.Add("Подключено.");
                conn.Close();
            }
        }
    }
}
