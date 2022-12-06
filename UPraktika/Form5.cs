using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPraktika
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnBD cstr = new ConnBD();
            MySqlConnection conn = new MySqlConnection(cstr.connStr);
            conn.Open();

            string query = "INSERT INTO `t_Uchebka_kuznesov` (`idStud`,`fioStud`, `datetimeStud`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
