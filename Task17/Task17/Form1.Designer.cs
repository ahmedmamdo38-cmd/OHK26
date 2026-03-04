namespace Task17
{
    partial class MuistoFM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuistoFM));
            menuStrip1 = new MenuStrip();
            tiiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            muokkaToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            kopioiToolStripMenuItem = new ToolStripMenuItem();
            leikkaToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            poistaToolStripMenuItem = new ToolStripMenuItem();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            kirjaisinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorotusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivittysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoToolStripMenuItem = new ToolStripMenuItem();
            TekstilaatikkoRTB = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiiedostoToolStripMenuItem, muokkaToolStripMenuItem, muotoileToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(941, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiiedostoToolStripMenuItem
            // 
            tiiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, tallennaNimelläToolStripMenuItem, toolStripMenuItem1, tulostuksenEsikatseluToolStripMenuItem, tulostaToolStripMenuItem, toolStripMenuItem2, poistuToolStripMenuItem });
            tiiedostoToolStripMenuItem.Name = "tiiedostoToolStripMenuItem";
            tiiedostoToolStripMenuItem.Size = new Size(101, 29);
            tiiedostoToolStripMenuItem.Text = "Tiiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(289, 34);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(289, 34);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(289, 34);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(289, 34);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(286, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(289, 34);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(289, 34);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(286, 6);
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            poistuToolStripMenuItem.Size = new Size(289, 34);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // muokkaToolStripMenuItem
            // 
            muokkaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem3, kopioiToolStripMenuItem, leikkaToolStripMenuItem, liitäToolStripMenuItem, poistaToolStripMenuItem, valitseKaikkiToolStripMenuItem });
            muokkaToolStripMenuItem.Name = "muokkaToolStripMenuItem";
            muokkaToolStripMenuItem.Size = new Size(92, 29);
            muokkaToolStripMenuItem.Text = "Muokka";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(276, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(276, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(273, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            kopioiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioiToolStripMenuItem.Size = new Size(276, 34);
            kopioiToolStripMenuItem.Text = "Kopioi";
            kopioiToolStripMenuItem.Click += kopioiToolStripMenuItem_Click;
            // 
            // leikkaToolStripMenuItem
            // 
            leikkaToolStripMenuItem.Name = "leikkaToolStripMenuItem";
            leikkaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaToolStripMenuItem.Size = new Size(276, 34);
            leikkaToolStripMenuItem.Text = "Leikka";
            leikkaToolStripMenuItem.Click += leikkaToolStripMenuItem_Click;
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(276, 34);
            liitäToolStripMenuItem.Text = "Liitä";
            liitäToolStripMenuItem.Click += liitäToolStripMenuItem_Click;
            // 
            // poistaToolStripMenuItem
            // 
            poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            poistaToolStripMenuItem.Size = new Size(276, 34);
            poistaToolStripMenuItem.Text = "Poista";
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(276, 34);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            valitseKaikkiToolStripMenuItem.Click += valitseKaikkiToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjaisinToolStripMenuItem, tekstinKorotusToolStripMenuItem, tekstinRivittysToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(99, 29);
            muotoileToolStripMenuItem.Text = "Muotoile";
            muotoileToolStripMenuItem.Click += muotoileToolStripMenuItem_Click;
            // 
            // kirjaisinToolStripMenuItem
            // 
            kirjaisinToolStripMenuItem.Name = "kirjaisinToolStripMenuItem";
            kirjaisinToolStripMenuItem.Size = new Size(270, 34);
            kirjaisinToolStripMenuItem.Text = "Kirjaisin ";
            kirjaisinToolStripMenuItem.Click += kirjaisinToolStripMenuItem_Click;
            // 
            // tekstinKorotusToolStripMenuItem
            // 
            tekstinKorotusToolStripMenuItem.Name = "tekstinKorotusToolStripMenuItem";
            tekstinKorotusToolStripMenuItem.Size = new Size(270, 34);
            tekstinKorotusToolStripMenuItem.Text = "Tekstin korotus";
            tekstinKorotusToolStripMenuItem.Click += tekstinKorotusToolStripMenuItem_Click;
            // 
            // tekstinRivittysToolStripMenuItem
            // 
            tekstinRivittysToolStripMenuItem.Name = "tekstinRivittysToolStripMenuItem";
            tekstinRivittysToolStripMenuItem.Size = new Size(270, 34);
            tekstinRivittysToolStripMenuItem.Text = "Tekstin rivittys";
            tekstinRivittysToolStripMenuItem.Click += tekstinRivittysToolStripMenuItem_Click;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tietoToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(70, 29);
            apuaToolStripMenuItem.Text = "Apua";
            apuaToolStripMenuItem.Click += apuaToolStripMenuItem_Click;
            // 
            // tietoToolStripMenuItem
            // 
            tietoToolStripMenuItem.Name = "tietoToolStripMenuItem";
            tietoToolStripMenuItem.Size = new Size(270, 34);
            tietoToolStripMenuItem.Text = "Tieto";
            tietoToolStripMenuItem.Click += tietoToolStripMenuItem_Click;
            // 
            // TekstilaatikkoRTB
            // 
            TekstilaatikkoRTB.Dock = DockStyle.Fill;
            TekstilaatikkoRTB.Location = new Point(0, 33);
            TekstilaatikkoRTB.Name = "TekstilaatikkoRTB";
            TekstilaatikkoRTB.Size = new Size(941, 524);
            TekstilaatikkoRTB.TabIndex = 1;
            TekstilaatikkoRTB.Text = "";
            TekstilaatikkoRTB.TextChanged += TekstilaatikkoRTB_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // MuistoFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(941, 557);
            Controls.Add(TekstilaatikkoRTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MuistoFM";
            Text = "Muisto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem muokkaToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem kirjaisinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorotusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivittysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem tietoToolStripMenuItem;
        private RichTextBox TekstilaatikkoRTB;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontDialog fontDialog1;
    }
}
