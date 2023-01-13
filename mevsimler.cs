private void textBox1_TextChanged(object sender, EventArgs e)
{
    string mevsim;
    mevsim = textBox1.Text;

    if (mevsim == "ilkbahar")
    {MessageBox.Show(mevsim + " Mevsimindeki aylar Mart Nisan 
    Mayıs");}

    else if (mevsim == "yaz")
    {MessageBox.Show(mevsim + " Mevsimindeki aylar Haziran 
    Temmuz Ağustos");}

    else if (mevsim == "sonbahar")
    {MessageBox.Show(mevsim + " Mevsimindeki aylar Eylül Ekim 
    Kasım");}

    else if (mevsim == "kış")
    {MessageBox.Show(mevsim + " Mevsimindeki aylar Aralık Ocak 
    Şubat");}

    else
    {MessageBox.Show("Hatalı giriş yaptınız");}
}
