using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPraktika
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        class Components<T>
        {
            public int Datarelese;
            public double Price;
            public T Article;

            public Components(int pr, int drel, T arti)
            {
                Price = pr;
                Datarelese = drel;
                Article = arti;
            }

            public void Display(ListBox listbox1)
            {
                listbox1.Items.Add($"Цена: {Price} Рублей");
                listbox1.Items.Add($"Год релиза: {Datarelese} ");
            }
        }

        class Hdd : Components<T>
        {
            private static T arti;

            public int Numturn { get; set; }
            public int Vol { get; set; }
            public string Interf { get; set; }

            public Hdd(int pr, int drel, int mt, int vol, string itf) : base(pr, drel, arti)
            {
                Numturn = mt;
                Vol = vol;
                Interf = itf;
            }

            public new void Display(ListBox listbox1)
            {
                listbox1.Items.Add($"Цена: {Price} Рублей");
                listbox1.Items.Add($"Год релиза: {Datarelese} ");
                listbox1.Items.Add($"Кол-во Оборотов: {Numturn}");
                listbox1.Items.Add($"Объем: {Vol}");
                listbox1.Items.Add($"Интерфейс: {Interf}");
            }
        }

        class Gpu : Components<T>
        {
            private static T arti;

            public string Hertz;
            public string Manuf;
            public int Memory;

            public Gpu(int pr, int drel, string ht, string mf, int ms) : base(pr, drel, arti)
            {
                Hertz = ht;
                Manuf = mf;
                Memory = ms;
            }

            public new void Display(ListBox listbox1)
            {
                listbox1.Items.Add($"Цена: {Price} Рублей");
                listbox1.Items.Add($"Год релиза: {Datarelese} ");
                listbox1.Items.Add($"Частота GPU: {Hertz}");
                listbox1.Items.Add($"Производитель,: {Manuf}");
                listbox1.Items.Add($"Объём Памяти: {Memory}");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Hdd hdd = new Hdd(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text);
            hdd.Display(listBox1);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Gpu hdd = new Gpu(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox6.Text, textBox7.Text, Convert.ToInt32(textBox8.Text));
            hdd.Display(listBox2);

        }
    }
}
