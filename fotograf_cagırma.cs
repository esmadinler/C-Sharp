using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile("C:\\Users\\USER\\Desktop\\resim\\balerin.jpg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\resim\\genç.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\resim\\dans.jpg");
        }

    }
}
