using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace metin_belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac = new OpenFileDialog();
            dosyaac.Title = "Dosya Aç";
            if (dosyaac.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(dosyaac.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            dosyakaydet.Title = "Dosya Kaydet";
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(dosyakaydet.FileName);
                txtoutput.Write(richTextBox1.Text);
                txtoutput.Write(richTextBox1.Text);
                txtoutput.Close();           
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);     
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void sözcükKaydırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
            sözcükKaydırToolStripMenuItem.Checked = richTextBox1.WordWrap;
        }

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = string.Format(" {0}", DateTime.Now);
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void yardımGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Enabled = true;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog YazıRengi = new ColorDialog();
            if (YazıRengi.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = YazıRengi.Color;
        }

        private void klasörOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
