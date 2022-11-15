using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
       
        int sayi;
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kadi = textBox1.Text;
            String ksoy = textBox2.Text;
            if ((kadi != " ") && (ksoy != " "))
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer1.Interval=1000;
            sayi=20;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            progressBar1.Maximum=20;
            progressBar1.Value = sayi;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(sayi>0)
           {
              sayi=sayi-1;
              label5.Text=sayi.ToString();
           }
        }    
     }
  }
