using System.IO;
namespace Task17
{
    public partial class MuistoFM : Form
    {
        string tiedostopolku = "";
        public MuistoFM()
        {
            InitializeComponent();
        }

        private void muotoileToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Text = "";
            if (TekstilaatikkoRTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstilaatikkoRTB.Text = "";
            }
            else
            {
                TekstilaatikkoRTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            {
                Filter = "TextDocument|*.txt|Rich Text Format|*.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        TekstilaatikkoRTB.Rtf = teksti.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "TextDocument|*.txt|Rich Text Format|*.rtf",
                    ValidateNames = true,
                })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.TekstilaatikkoRTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Text, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        private void leikkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaToolStripMenuItem.Enabled = false;
            }
        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }

        private void kirjaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorotusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.Yellow;
        }

        private void apuaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tietoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tie tietoa = new tie();
            tietoa.ShowDialog();
        }
    }
}
