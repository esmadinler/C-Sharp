using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 9, 3, 7, 2, 8, 12, 66, 102, 99, 66, 88};
            int[] kopya = new int[sayilar.Length];
            for (int i = 0; i < kopya.Length; i++)
            {
                kopya[i] = sayilar[i];
                listBox1.Items.Add(kopya[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kaç sayı var
            textBox1.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int[] sayilar = { 9, 3, 7, 2, 8, 12, 66, 102, 99, 66, 88 };
            foreach (int sayi in sayilar) 
            {
                if (sayi % 2 == 0)
                { listBox2.Items.Add(sayi); } // Çift sayıları bulur

                else
                { listBox3.Items.Add(sayi); } // Tek sayıları bulur
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          // else ile çalışıyor
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           textBox2.Text= Convert.ToString(listBox2.Items.Count); // çift sayıları sayıp textbox2 ye yazar.
        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox3.Text= Convert.ToString(listBox3.Items.Count); // tek sayıları sayıp textbox3 e yazar.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // toplama işlemi

        }
    }
}
