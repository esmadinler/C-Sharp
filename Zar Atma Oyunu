using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_atma_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam1, toplam2;
        string isim1, isim2;

        private void button1_Click(object sender, EventArgs e)
        {
            Image[]
            Images = new Image[6];
            Images[0] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\bir.jpg");
            Images[1] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\iki.jpg");
            Images[2] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\üç.jpg");
            Images[3] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\dört.jpg");
            Images[4] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\beş.jpg");
            Images[5] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\altı.jpg");

            isim1 = textBox1.Text;
            Random rastgele = new Random();
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            pictureBox1.Image = Images[a];
            pictureBox2.Image = Images[b];
            toplam1 = a + b;
            listBox1.Items.Add(a + b + 2);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Image[]
            Images = new Image[6];
            Images[0] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\bir.jpg");
            Images[1] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\iki.jpg");
            Images[2] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\üç.jpg");
            Images[3] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\dört.jpg");
            Images[4] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\beş.jpg");
            Images[5] = Image.FromFile("C:\\Users\\Excalibur\\source\\repos\\zar_gorsel_oyunu\\altı.jpg");

            isim2 = textBox2.Text;
            Random rastgele = new Random();
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            pictureBox3.Image = Images[c];
            pictureBox4.Image = Images[d];
            toplam2 = c + d;
            listBox2.Items.Add(c + d + 2);

            if (toplam1 > toplam2)
            { textBox3.Text = isim1 + " Oyunu kazandı. Tebrikler "; }
            else if (toplam1 == toplam2)
            { textBox3.Text = isim1 + " " + "ve" + " " + isim2 + " " + "berabere"; }
            else if (toplam2 > toplam1)
            { textBox3.Text = isim2 + " Oyunu kazandı. Tebrikler "; }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OYUN BİTTİ...");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
