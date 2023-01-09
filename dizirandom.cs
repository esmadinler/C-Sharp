using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random sayi = new Random();
            int sayi1 = sayi.Next(1, 40);

            int[] dizi = new int[5];

            int i;
            int toplam=0;

            for (i=0; i<dizi.Length; i++)
            {
                sayi1 = sayi.Next(1, 40);
                listBox1.Items.Add(sayi1);
                toplam += sayi1;                 
            }

            label1.Text=toplam.ToString();

            if(toplam == 100 || toplam > 100)
            {
                MessageBox.Show("Değer Aşıldı");
            }

            else
            {
                MessageBox.Show(toplam + " " +  "toplam değeri");
            }

        }
    }
}
