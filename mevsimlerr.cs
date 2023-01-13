using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mevsimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mevsim;
            mevsim = textBox1.Text;
            if (mevsim == "ilkbahar")
            {label1.Text =(" Mevsimindeki aylar Mart Nisan 
            Mayıs");}
            
            else if (mevsim == "yaz")
            {label1.Text =(" Mevsimindeki aylar Haziran 
            Temmuz Ağustos");}
            
            else if (mevsim == "sonbahar")
            {label1.Text =("Mevsimindeki aylar Eylül Ekim 
            Kasım");}
            
            else if (mevsim == "kış")
            {label1.Text =("Mevsimindeki aylar Aralık Ocak 
            Şubat");}
            
            else
            {label1.Text =("Hatalı giriş yaptınız");}
        }
    }
}
