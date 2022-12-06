using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPraktika
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ConnBD cstr = new ConnBD();

            MySqlConnection myConn = new MySqlConnection(cstr.connStr);

            myConn.Open();

            string query_date = "SELECT * FROM t_datatime ORDER BY fio";

            MySqlCommand comm = new MySqlCommand(query_date, myConn);

            MySqlDataReader reader = comm.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myConn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnBD cstr = new ConnBD();

            MySqlConnection conn = new MySqlConnection(cstr.connStr);

            conn.Open();

            string query = "INSERT INTO `t_datatime` (`id`, `fio`, `date_of_birth`, `photoUrl`) VALUES (NULL, '"+textBox1.Text+ "', '"+dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '"+textBox3.Text+"');";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.ExecuteNonQuery();

            conn.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells["url"].Value.ToString();
        }
    }
}
