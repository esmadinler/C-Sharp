using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progpic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[0];
            pictureBox2.Image = ımageList1.Images[1];

            timer1.Interval = 100;
            timer1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button1.Text = "Başlat";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Durdur";
            }
        }

        int yer = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 1;
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    if (yer % 2 == 0)
                    {
                        pictureBox1.Image = ımageList1.Images[1];
                        pictureBox2.Image = ımageList1.Images[0];
                    }

                    else
                    {
                        pictureBox1.Image = ımageList1.Images[0];
                        pictureBox2.Image = ımageList1.Images[1];
                    }

                    yer++;
                    progressBar1.Value = 0;
                }
            }
        }
    }
}
