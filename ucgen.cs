using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucgennturleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               string a, b, c;

                a = textBox1.Text;
                b = textBox2.Text;
                c = textBox3.Text;

                if (a == b && a == c)
                {
                    MessageBox.Show("Eşkenar Üçgen");
                }

                else if (a == b || a == c || b == c)
                {
                    MessageBox.Show("İkizkenar Üçgen");
                }

                else
                {
                    MessageBox.Show("Çeşitkenar Üçgen");
                }         
        }
    }
}
