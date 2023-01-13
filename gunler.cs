 private void button1_Click_1(object sender, EventArgs e)
{
   string sayi = textBox2.Text;
   switch (sayi)
   { 
    case "1": label2.Text = "Pazartesi"; break;
    case "2": label2.Text = "Salı"; break;
    case "3": label2.Text = "Çarşamba"; break;
    case "4": label2.Text = "Perşembe"; break;
    case "5": label2.Text = "Cuma"; break;
    case "6": label2.Text = "Cumartesi"; break;
    case "7": label2.Text = "Pazar"; break;
    default: label2.Text = "Hatalı Giriş"; break;
    }
 }
