using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y, puan;
        int zaman = 60;
        Random sayi = new Random();
  
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = sayi.Next(0, 300);
            y = sayi.Next(0, 300);
            pictureBox1.Location = new System.Drawing.Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            puan = puan + 1;
            label4.Text = puan.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            zaman--;
            label3.Text = zaman.ToString();
            if (zaman == 0)
            {   timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

    }
}
