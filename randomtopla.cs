using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listBox1.Items.Clear();

            int sayi;

            Random rastgele = new Random();

            for (int i = 1; i <= 10; i++)
            {
                sayi = rastgele.Next(0, 1000);
                listBox1.Items.Add(sayi);
            
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi;

            for (int i = 0; i <= 9; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                toplam = toplam + sayi;
            }
            label1.Text = toplam.ToString();
        }
    }
}
