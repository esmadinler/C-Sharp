namespace HarfNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double puan = Convert.ToDouble(tbPuan.Text);
            if (puan < 0 || puan > 100)
            {
                MessageBox.Show("[0-100] aralığında puan girebilirsiniz.");
                return;
            }

            if (puan >= 90)
                HarfNotu.Text = "AA";
            else if (puan >= 80)
                HarfNotu.Text = "BA";
            else if (puan >= 70)
                HarfNotu.Text = "BB";
            else if (puan >= 60)
                HarfNotu.Text = "CB";
            else if (puan >= 53)
                HarfNotu.Text = "CC";
            else if (puan >= 48)
                HarfNotu.Text = "DC";
            else if (puan >= 40)
                HarfNotu.Text = "DD";
            else if (puan >= 30)
                HarfNotu.Text = "FD";
            else
                HarfNotu.Text = "FF";
        }
    }
}
