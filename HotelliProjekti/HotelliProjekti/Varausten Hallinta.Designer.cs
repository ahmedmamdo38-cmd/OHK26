namespace HotelliProjekti
{
    partial class VaraustenHallintaFM
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
            AlaPanel = new Panel();
            VUlosDTP = new DateTimePicker();
            VSisäänDTP = new DateTimePicker();
            VHuoneNroCB = new ComboBox();
            VHuoneTyyppiCB = new ComboBox();
            VAsiakasNroCB = new ComboBox();
            VTyhjennaKentatBT = new Button();
            VPoistaBT = new Button();
            VMuokkaBt = new Button();
            VLisääUusiVarausBT = new Button();
            VUlosLB = new Label();
            VSisäänLB = new Label();
            VHuoneenNroLB = new Label();
            VHuoneTyyppiLB = new Label();
            VAsiakaidenNroLB = new Label();
            VVarausNroTB = new TextBox();
            VaraustenHallintaDG = new DataGridView();
            VarausNroLB = new Label();
            YlaPanel = new Panel();
            VaraustenHallintaLB = new Label();
            AlaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VaraustenHallintaDG).BeginInit();
            YlaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AlaPanel
            // 
            AlaPanel.BackColor = Color.White;
            AlaPanel.Controls.Add(VUlosDTP);
            AlaPanel.Controls.Add(VSisäänDTP);
            AlaPanel.Controls.Add(VHuoneNroCB);
            AlaPanel.Controls.Add(VHuoneTyyppiCB);
            AlaPanel.Controls.Add(VAsiakasNroCB);
            AlaPanel.Controls.Add(VTyhjennaKentatBT);
            AlaPanel.Controls.Add(VPoistaBT);
            AlaPanel.Controls.Add(VMuokkaBt);
            AlaPanel.Controls.Add(VLisääUusiVarausBT);
            AlaPanel.Controls.Add(VUlosLB);
            AlaPanel.Controls.Add(VSisäänLB);
            AlaPanel.Controls.Add(VHuoneenNroLB);
            AlaPanel.Controls.Add(VHuoneTyyppiLB);
            AlaPanel.Controls.Add(VAsiakaidenNroLB);
            AlaPanel.Controls.Add(VVarausNroTB);
            AlaPanel.Controls.Add(VaraustenHallintaDG);
            AlaPanel.Controls.Add(VarausNroLB);
            AlaPanel.Dock = DockStyle.Fill;
            AlaPanel.Location = new Point(0, 98);
            AlaPanel.Name = "AlaPanel";
            AlaPanel.Size = new Size(1272, 450);
            AlaPanel.TabIndex = 3;
            // 
            // VUlosDTP
            // 
            VUlosDTP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VUlosDTP.Location = new Point(231, 227);
            VUlosDTP.Name = "VUlosDTP";
            VUlosDTP.Size = new Size(318, 36);
            VUlosDTP.TabIndex = 23;
            // 
            // VSisäänDTP
            // 
            VSisäänDTP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VSisäänDTP.Location = new Point(231, 185);
            VSisäänDTP.Name = "VSisäänDTP";
            VSisäänDTP.Size = new Size(318, 36);
            VSisäänDTP.TabIndex = 22;
            // 
            // VHuoneNroCB
            // 
            VHuoneNroCB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VHuoneNroCB.FormattingEnabled = true;
            VHuoneNroCB.Location = new Point(231, 142);
            VHuoneNroCB.Name = "VHuoneNroCB";
            VHuoneNroCB.Size = new Size(318, 37);
            VHuoneNroCB.TabIndex = 21;
            // 
            // VHuoneTyyppiCB
            // 
            VHuoneTyyppiCB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VHuoneTyyppiCB.FormattingEnabled = true;
            VHuoneTyyppiCB.Location = new Point(231, 99);
            VHuoneTyyppiCB.Name = "VHuoneTyyppiCB";
            VHuoneTyyppiCB.Size = new Size(318, 37);
            VHuoneTyyppiCB.TabIndex = 20;
            // 
            // VAsiakasNroCB
            // 
            VAsiakasNroCB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VAsiakasNroCB.FormattingEnabled = true;
            VAsiakasNroCB.Location = new Point(231, 56);
            VAsiakasNroCB.Name = "VAsiakasNroCB";
            VAsiakasNroCB.Size = new Size(318, 37);
            VAsiakasNroCB.TabIndex = 19;
            // 
            // VTyhjennaKentatBT
            // 
            VTyhjennaKentatBT.BackColor = Color.SkyBlue;
            VTyhjennaKentatBT.FlatStyle = FlatStyle.Popup;
            VTyhjennaKentatBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VTyhjennaKentatBT.ForeColor = Color.White;
            VTyhjennaKentatBT.Location = new Point(157, 343);
            VTyhjennaKentatBT.Name = "VTyhjennaKentatBT";
            VTyhjennaKentatBT.Size = new Size(222, 42);
            VTyhjennaKentatBT.TabIndex = 18;
            VTyhjennaKentatBT.Text = "Tyhjennä kentät";
            VTyhjennaKentatBT.UseVisualStyleBackColor = false;
            // 
            // VPoistaBT
            // 
            VPoistaBT.BackColor = Color.SkyBlue;
            VPoistaBT.FlatStyle = FlatStyle.Popup;
            VPoistaBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VPoistaBT.ForeColor = Color.White;
            VPoistaBT.Location = new Point(12, 343);
            VPoistaBT.Name = "VPoistaBT";
            VPoistaBT.Size = new Size(139, 42);
            VPoistaBT.TabIndex = 17;
            VPoistaBT.Text = "Poista";
            VPoistaBT.UseVisualStyleBackColor = false;
            // 
            // VMuokkaBt
            // 
            VMuokkaBt.BackColor = Color.SkyBlue;
            VMuokkaBt.FlatStyle = FlatStyle.Popup;
            VMuokkaBt.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VMuokkaBt.ForeColor = Color.White;
            VMuokkaBt.Location = new Point(269, 286);
            VMuokkaBt.Name = "VMuokkaBt";
            VMuokkaBt.Size = new Size(222, 42);
            VMuokkaBt.TabIndex = 16;
            VMuokkaBt.Text = "Muokka";
            VMuokkaBt.UseVisualStyleBackColor = false;
            // 
            // VLisääUusiVarausBT
            // 
            VLisääUusiVarausBT.BackColor = Color.SkyBlue;
            VLisääUusiVarausBT.FlatStyle = FlatStyle.Popup;
            VLisääUusiVarausBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VLisääUusiVarausBT.ForeColor = Color.Snow;
            VLisääUusiVarausBT.Location = new Point(12, 286);
            VLisääUusiVarausBT.Name = "VLisääUusiVarausBT";
            VLisääUusiVarausBT.Size = new Size(251, 42);
            VLisääUusiVarausBT.TabIndex = 15;
            VLisääUusiVarausBT.Text = "Lisää uusi varaus";
            VLisääUusiVarausBT.UseVisualStyleBackColor = false;
            // 
            // VUlosLB
            // 
            VUlosLB.AutoSize = true;
            VUlosLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VUlosLB.Location = new Point(12, 234);
            VUlosLB.Name = "VUlosLB";
            VUlosLB.Size = new Size(66, 29);
            VUlosLB.TabIndex = 7;
            VUlosLB.Text = "Ulos:";
            // 
            // VSisäänLB
            // 
            VSisäänLB.AutoSize = true;
            VSisäänLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VSisäänLB.Location = new Point(12, 192);
            VSisäänLB.Name = "VSisäänLB";
            VSisäänLB.Size = new Size(89, 29);
            VSisäänLB.TabIndex = 6;
            VSisäänLB.Text = "Sisään:";
            // 
            // VHuoneenNroLB
            // 
            VHuoneenNroLB.AutoSize = true;
            VHuoneenNroLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VHuoneenNroLB.Location = new Point(12, 150);
            VHuoneenNroLB.Name = "VHuoneenNroLB";
            VHuoneenNroLB.Size = new Size(204, 29);
            VHuoneenNroLB.TabIndex = 5;
            VHuoneenNroLB.Text = "Huoneen numero:";
            // 
            // VHuoneTyyppiLB
            // 
            VHuoneTyyppiLB.AutoSize = true;
            VHuoneTyyppiLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VHuoneTyyppiLB.Location = new Point(12, 108);
            VHuoneTyyppiLB.Name = "VHuoneTyyppiLB";
            VHuoneTyyppiLB.Size = new Size(152, 29);
            VHuoneTyyppiLB.TabIndex = 4;
            VHuoneTyyppiLB.Text = "Huonetyyppi:";
            // 
            // VAsiakaidenNroLB
            // 
            VAsiakaidenNroLB.AutoSize = true;
            VAsiakaidenNroLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VAsiakaidenNroLB.Location = new Point(12, 66);
            VAsiakaidenNroLB.Name = "VAsiakaidenNroLB";
            VAsiakaidenNroLB.Size = new Size(189, 29);
            VAsiakaidenNroLB.TabIndex = 3;
            VAsiakaidenNroLB.Text = "Asiakas numero:";
            // 
            // VVarausNroTB
            // 
            VVarausNroTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VVarausNroTB.Location = new Point(231, 14);
            VVarausNroTB.Name = "VVarausNroTB";
            VVarausNroTB.Size = new Size(318, 36);
            VVarausNroTB.TabIndex = 2;
            // 
            // VaraustenHallintaDG
            // 
            VaraustenHallintaDG.BackgroundColor = Color.WhiteSmoke;
            VaraustenHallintaDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VaraustenHallintaDG.Dock = DockStyle.Right;
            VaraustenHallintaDG.Location = new Point(621, 0);
            VaraustenHallintaDG.Name = "VaraustenHallintaDG";
            VaraustenHallintaDG.RowHeadersWidth = 62;
            VaraustenHallintaDG.Size = new Size(651, 450);
            VaraustenHallintaDG.TabIndex = 1;
            // 
            // VarausNroLB
            // 
            VarausNroLB.AutoSize = true;
            VarausNroLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VarausNroLB.Location = new Point(12, 21);
            VarausNroLB.Name = "VarausNroLB";
            VarausNroLB.Size = new Size(183, 29);
            VarausNroLB.TabIndex = 0;
            VarausNroLB.Text = "Varaus numero:";
            // 
            // YlaPanel
            // 
            YlaPanel.BackColor = Color.SkyBlue;
            YlaPanel.Controls.Add(VaraustenHallintaLB);
            YlaPanel.Dock = DockStyle.Top;
            YlaPanel.Location = new Point(0, 0);
            YlaPanel.Name = "YlaPanel";
            YlaPanel.Size = new Size(1272, 98);
            YlaPanel.TabIndex = 2;
            // 
            // VaraustenHallintaLB
            // 
            VaraustenHallintaLB.AutoSize = true;
            VaraustenHallintaLB.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VaraustenHallintaLB.ForeColor = Color.White;
            VaraustenHallintaLB.Location = new Point(379, 18);
            VaraustenHallintaLB.Name = "VaraustenHallintaLB";
            VaraustenHallintaLB.Size = new Size(513, 63);
            VaraustenHallintaLB.TabIndex = 0;
            VaraustenHallintaLB.Text = "Varausten Hallinta";
            // 
            // VaraustenHallintaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 548);
            Controls.Add(AlaPanel);
            Controls.Add(YlaPanel);
            Name = "VaraustenHallintaFM";
            Text = "Varausten_Hallinta";
            AlaPanel.ResumeLayout(false);
            AlaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VaraustenHallintaDG).EndInit();
            YlaPanel.ResumeLayout(false);
            YlaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AlaPanel;
        private Button VTyhjennaKentatBT;
        private Button VPoistaBT;
        private Button VMuokkaBt;
        private Button VLisääUusiVarausBT;
        private TextBox APostinumeroTB;
        private TextBox ASukunimiTB;
        private TextBox ALahiosoiteTB;
        private Label VUlosLB;
        private Label VSisäänLB;
        private Label VHuoneenNroLB;
        private Label VHuoneTyyppiLB;
        private Label VAsiakaidenNroLB;
        private TextBox VVarausNroTB;
        private DataGridView VaraustenHallintaDG;
        private Label VarausNroLB;
        private Panel YlaPanel;
        private Label VaraustenHallintaLB;
        private ComboBox VHuoneNroCB;
        private ComboBox VHuoneTyyppiCB;
        private ComboBox VAsiakasNroCB;
        private DateTimePicker VSisäänDTP;
        private DateTimePicker VUlosDTP;
    }
}