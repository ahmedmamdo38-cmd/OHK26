namespace HotelliProjekti
{
    partial class Asiakkaiden_hallintaFM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            YlaPanel = new Panel();
            AsiakkaidenHallintaLB = new Label();
            AlaPanel = new Panel();
            ATyhjennaKentatBT = new Button();
            APoistaBT = new Button();
            AMuokkaBt = new Button();
            ALisääUusiAsiakasBT = new Button();
            ASalasanaTB = new TextBox();
            AkäyttäjätunnusTb = new TextBox();
            APostitoimipaikkaTB = new TextBox();
            APostinumeroTB = new TextBox();
            ASukunimiTB = new TextBox();
            ALahiosoiteTB = new TextBox();
            ASalasanaLB = new Label();
            AKäyttäjätunnusLB = new Label();
            APostitoimipaikkaLB = new Label();
            APostinumeroLB = new Label();
            ALahiosoiteLB = new Label();
            ASukunimiLB = new Label();
            AEtunimiTB = new TextBox();
            AsiakaidenHallintaDG = new DataGridView();
            AEtunimiLB = new Label();
            YlaPanel.SuspendLayout();
            AlaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AsiakaidenHallintaDG).BeginInit();
            SuspendLayout();
            // 
            // YlaPanel
            // 
            YlaPanel.BackColor = Color.SkyBlue;
            YlaPanel.Controls.Add(AsiakkaidenHallintaLB);
            YlaPanel.Dock = DockStyle.Top;
            YlaPanel.Location = new Point(0, 0);
            YlaPanel.Name = "YlaPanel";
            YlaPanel.Size = new Size(1258, 98);
            YlaPanel.TabIndex = 0;
            // 
            // AsiakkaidenHallintaLB
            // 
            AsiakkaidenHallintaLB.AutoSize = true;
            AsiakkaidenHallintaLB.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AsiakkaidenHallintaLB.ForeColor = Color.White;
            AsiakkaidenHallintaLB.Location = new Point(379, 18);
            AsiakkaidenHallintaLB.Name = "AsiakkaidenHallintaLB";
            AsiakkaidenHallintaLB.Size = new Size(578, 63);
            AsiakkaidenHallintaLB.TabIndex = 0;
            AsiakkaidenHallintaLB.Text = "Asiakkaiden Hallinta ";
            // 
            // AlaPanel
            // 
            AlaPanel.BackColor = Color.White;
            AlaPanel.Controls.Add(ATyhjennaKentatBT);
            AlaPanel.Controls.Add(APoistaBT);
            AlaPanel.Controls.Add(AMuokkaBt);
            AlaPanel.Controls.Add(ALisääUusiAsiakasBT);
            AlaPanel.Controls.Add(ASalasanaTB);
            AlaPanel.Controls.Add(AkäyttäjätunnusTb);
            AlaPanel.Controls.Add(APostitoimipaikkaTB);
            AlaPanel.Controls.Add(APostinumeroTB);
            AlaPanel.Controls.Add(ASukunimiTB);
            AlaPanel.Controls.Add(ALahiosoiteTB);
            AlaPanel.Controls.Add(ASalasanaLB);
            AlaPanel.Controls.Add(AKäyttäjätunnusLB);
            AlaPanel.Controls.Add(APostitoimipaikkaLB);
            AlaPanel.Controls.Add(APostinumeroLB);
            AlaPanel.Controls.Add(ALahiosoiteLB);
            AlaPanel.Controls.Add(ASukunimiLB);
            AlaPanel.Controls.Add(AEtunimiTB);
            AlaPanel.Controls.Add(AsiakaidenHallintaDG);
            AlaPanel.Controls.Add(AEtunimiLB);
            AlaPanel.Dock = DockStyle.Fill;
            AlaPanel.Location = new Point(0, 98);
            AlaPanel.Name = "AlaPanel";
            AlaPanel.Size = new Size(1258, 525);
            AlaPanel.TabIndex = 1;
            AlaPanel.Paint += AlaPanel_Paint;
            // 
            // ATyhjennaKentatBT
            // 
            ATyhjennaKentatBT.BackColor = Color.SkyBlue;
            ATyhjennaKentatBT.FlatStyle = FlatStyle.Popup;
            ATyhjennaKentatBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ATyhjennaKentatBT.ForeColor = Color.White;
            ATyhjennaKentatBT.Location = new Point(157, 385);
            ATyhjennaKentatBT.Name = "ATyhjennaKentatBT";
            ATyhjennaKentatBT.Size = new Size(222, 42);
            ATyhjennaKentatBT.TabIndex = 18;
            ATyhjennaKentatBT.Text = "Tyhjennä kentät";
            ATyhjennaKentatBT.UseVisualStyleBackColor = false;
            // 
            // APoistaBT
            // 
            APoistaBT.BackColor = Color.SkyBlue;
            APoistaBT.FlatStyle = FlatStyle.Popup;
            APoistaBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            APoistaBT.ForeColor = Color.White;
            APoistaBT.Location = new Point(12, 385);
            APoistaBT.Name = "APoistaBT";
            APoistaBT.Size = new Size(139, 42);
            APoistaBT.TabIndex = 17;
            APoistaBT.Text = "Poista";
            APoistaBT.UseVisualStyleBackColor = false;
            // 
            // AMuokkaBt
            // 
            AMuokkaBt.BackColor = Color.SkyBlue;
            AMuokkaBt.FlatStyle = FlatStyle.Popup;
            AMuokkaBt.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMuokkaBt.ForeColor = Color.White;
            AMuokkaBt.Location = new Point(269, 328);
            AMuokkaBt.Name = "AMuokkaBt";
            AMuokkaBt.Size = new Size(222, 42);
            AMuokkaBt.TabIndex = 16;
            AMuokkaBt.Text = "Muokka asiakas";
            AMuokkaBt.UseVisualStyleBackColor = false;
            // 
            // ALisääUusiAsiakasBT
            // 
            ALisääUusiAsiakasBT.BackColor = Color.SkyBlue;
            ALisääUusiAsiakasBT.FlatStyle = FlatStyle.Popup;
            ALisääUusiAsiakasBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ALisääUusiAsiakasBT.ForeColor = Color.Snow;
            ALisääUusiAsiakasBT.Location = new Point(12, 328);
            ALisääUusiAsiakasBT.Name = "ALisääUusiAsiakasBT";
            ALisääUusiAsiakasBT.Size = new Size(251, 42);
            ALisääUusiAsiakasBT.TabIndex = 15;
            ALisääUusiAsiakasBT.Text = "Lisää uusi asiakas";
            ALisääUusiAsiakasBT.UseVisualStyleBackColor = false;
            // 
            // ASalasanaTB
            // 
            ASalasanaTB.Font = new Font("Tahoma", 12F);
            ASalasanaTB.Location = new Point(231, 269);
            ASalasanaTB.Name = "ASalasanaTB";
            ASalasanaTB.Size = new Size(318, 36);
            ASalasanaTB.TabIndex = 14;
            // 
            // AkäyttäjätunnusTb
            // 
            AkäyttäjätunnusTb.Font = new Font("Tahoma", 12F);
            AkäyttäjätunnusTb.Location = new Point(231, 227);
            AkäyttäjätunnusTb.Name = "AkäyttäjätunnusTb";
            AkäyttäjätunnusTb.Size = new Size(318, 36);
            AkäyttäjätunnusTb.TabIndex = 13;
            // 
            // APostitoimipaikkaTB
            // 
            APostitoimipaikkaTB.Font = new Font("Tahoma", 12F);
            APostitoimipaikkaTB.Location = new Point(231, 185);
            APostitoimipaikkaTB.Name = "APostitoimipaikkaTB";
            APostitoimipaikkaTB.Size = new Size(318, 36);
            APostitoimipaikkaTB.TabIndex = 12;
            // 
            // APostinumeroTB
            // 
            APostinumeroTB.Font = new Font("Tahoma", 12F);
            APostinumeroTB.Location = new Point(231, 143);
            APostinumeroTB.Name = "APostinumeroTB";
            APostinumeroTB.Size = new Size(318, 36);
            APostinumeroTB.TabIndex = 11;
            // 
            // ASukunimiTB
            // 
            ASukunimiTB.Font = new Font("Tahoma", 12F);
            ASukunimiTB.Location = new Point(231, 59);
            ASukunimiTB.Name = "ASukunimiTB";
            ASukunimiTB.Size = new Size(318, 36);
            ASukunimiTB.TabIndex = 10;
            // 
            // ALahiosoiteTB
            // 
            ALahiosoiteTB.Font = new Font("Tahoma", 12F);
            ALahiosoiteTB.Location = new Point(231, 101);
            ALahiosoiteTB.Name = "ALahiosoiteTB";
            ALahiosoiteTB.Size = new Size(318, 36);
            ALahiosoiteTB.TabIndex = 9;
            // 
            // ASalasanaLB
            // 
            ASalasanaLB.AutoSize = true;
            ASalasanaLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ASalasanaLB.Location = new Point(12, 276);
            ASalasanaLB.Name = "ASalasanaLB";
            ASalasanaLB.Size = new Size(115, 29);
            ASalasanaLB.TabIndex = 8;
            ASalasanaLB.Text = "Salasana:";
            // 
            // AKäyttäjätunnusLB
            // 
            AKäyttäjätunnusLB.AutoSize = true;
            AKäyttäjätunnusLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AKäyttäjätunnusLB.Location = new Point(12, 234);
            AKäyttäjätunnusLB.Name = "AKäyttäjätunnusLB";
            AKäyttäjätunnusLB.Size = new Size(180, 29);
            AKäyttäjätunnusLB.TabIndex = 7;
            AKäyttäjätunnusLB.Text = "Käyttäjätunnus:";
            // 
            // APostitoimipaikkaLB
            // 
            APostitoimipaikkaLB.AutoSize = true;
            APostitoimipaikkaLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            APostitoimipaikkaLB.Location = new Point(12, 192);
            APostitoimipaikkaLB.Name = "APostitoimipaikkaLB";
            APostitoimipaikkaLB.Size = new Size(190, 29);
            APostitoimipaikkaLB.TabIndex = 6;
            APostitoimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // APostinumeroLB
            // 
            APostinumeroLB.AutoSize = true;
            APostinumeroLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            APostinumeroLB.Location = new Point(12, 150);
            APostinumeroLB.Name = "APostinumeroLB";
            APostinumeroLB.Size = new Size(152, 29);
            APostinumeroLB.TabIndex = 5;
            APostinumeroLB.Text = "Postinumero:";
            // 
            // ALahiosoiteLB
            // 
            ALahiosoiteLB.AutoSize = true;
            ALahiosoiteLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ALahiosoiteLB.Location = new Point(12, 108);
            ALahiosoiteLB.Name = "ALahiosoiteLB";
            ALahiosoiteLB.Size = new Size(127, 29);
            ALahiosoiteLB.TabIndex = 4;
            ALahiosoiteLB.Text = "Lähiosoite:";
            // 
            // ASukunimiLB
            // 
            ASukunimiLB.AutoSize = true;
            ASukunimiLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ASukunimiLB.Location = new Point(12, 66);
            ASukunimiLB.Name = "ASukunimiLB";
            ASukunimiLB.Size = new Size(115, 29);
            ASukunimiLB.TabIndex = 3;
            ASukunimiLB.Text = "Sukunimi:";
            // 
            // AEtunimiTB
            // 
            AEtunimiTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AEtunimiTB.Location = new Point(231, 14);
            AEtunimiTB.Name = "AEtunimiTB";
            AEtunimiTB.Size = new Size(318, 36);
            AEtunimiTB.TabIndex = 2;
            // 
            // AsiakaidenHallintaDG
            // 
            AsiakaidenHallintaDG.BackgroundColor = Color.WhiteSmoke;
            AsiakaidenHallintaDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AsiakaidenHallintaDG.Dock = DockStyle.Right;
            AsiakaidenHallintaDG.Location = new Point(607, 0);
            AsiakaidenHallintaDG.Name = "AsiakaidenHallintaDG";
            AsiakaidenHallintaDG.RowHeadersWidth = 62;
            AsiakaidenHallintaDG.Size = new Size(651, 525);
            AsiakaidenHallintaDG.TabIndex = 1;
            // 
            // AEtunimiLB
            // 
            AEtunimiLB.AutoSize = true;
            AEtunimiLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AEtunimiLB.Location = new Point(12, 21);
            AEtunimiLB.Name = "AEtunimiLB";
            AEtunimiLB.Size = new Size(98, 29);
            AEtunimiLB.TabIndex = 0;
            AEtunimiLB.Text = "Etunimi:";
            // 
            // Asiakkaiden_hallintaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 623);
            Controls.Add(AlaPanel);
            Controls.Add(YlaPanel);
            Name = "Asiakkaiden_hallintaFM";
            Text = "Asiakkaiden hallinta";
            YlaPanel.ResumeLayout(false);
            YlaPanel.PerformLayout();
            AlaPanel.ResumeLayout(false);
            AlaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AsiakaidenHallintaDG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel YlaPanel;
        private Label AsiakkaidenHallintaLB;
        private Panel AlaPanel;
        private Label AEtunimiLB;
        private DataGridView AsiakaidenHallintaDG;
        private Label ASukunimiLB;
        private TextBox AEtunimiTB;
        private Label label1;
        private Label ASalasanaLB;
        private Label AKäyttäjätunnusLB;
        private Label APostitoimipaikkaLB;
        private Label APostinumeroLB;
        private Label ALahiosoiteLB;
        private TextBox ASalasanaTB;
        private TextBox AkäyttäjätunnusTb;
        private TextBox APostitoimipaikkaTB;
        private TextBox APostinumeroTB;
        private TextBox ASukunimiTB;
        private TextBox ALahiosoiteTB;
        private Button AMuokkaBt;
        private Button ALisääUusiAsiakasBT;
        private Button ATyhjennaKentatBT;
        private Button APoistaBT;
    }
}