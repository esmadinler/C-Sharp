using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Topla()
        {
            int sy1 = Convert.ToInt32(textBox1.Text);
            int sy2 = Convert.ToInt32(textBox2.Text);
            int snc = sy1 + sy2;
            label12.Text = snc.ToString();
        }

        static int Fark(int sayi1, int sayi2)
        {
            int snc = sayi1 - sayi2;
            return snc;
        }

        private void carp(int sayi1, int sayi2)
        {
            int snc = sayi1 * sayi2;
            label14.Text = snc.ToString();
        }

        public string bol(int sayi1, int sayi2)
        {
            double snc = sayi1 / sayi2;
            return snc.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Topla();
            int sy1 = Convert.ToInt32(textBox1.Text);
            int sy2 = Convert.ToInt32(textBox2.Text);
            
            int donen = Fark(sy1, sy2);
            label13.Text = donen.ToString();
            label15.Text = bol(sy1, sy2);
            carp(sy1, sy2);
        }
    }
}
