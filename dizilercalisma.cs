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
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100, 18, 46};
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            label2.Text = toplam.ToString();
            MessageBox.Show("Dizideki sayıların toplamı= "  +toplam);

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                { listBox1.Items.Add(sayi);}

                else
                {listBox2.Items.Add(sayi);}
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(listBox2.Items.Count);
        }
    }
}
