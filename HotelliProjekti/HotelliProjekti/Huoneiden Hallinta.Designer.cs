namespace HotelliProjekti
{
    partial class Huoneiden_Hallinta
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            HPuhelinTB = new TextBox();
            HHuonetyyppiCB = new ComboBox();
            HTyhjennaKentatBT = new Button();
            HPoistaBT = new Button();
            HMuokkaBt = new Button();
            HLisääUusiHuoneBT = new Button();
            HVapaaLB = new Label();
            HPuhelinLB = new Label();
            HuoneTyyppiLB = new Label();
            HHuoneNroTB = new TextBox();
            HuoneidenHallintaDG = new DataGridView();
            HuonenNroLB = new Label();
            YlaPanel = new Panel();
            HuoneidenHallintaLB = new Label();
            AlaPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HuoneidenHallintaDG).BeginInit();
            YlaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AlaPanel
            // 
            AlaPanel.BackColor = Color.White;
            AlaPanel.Controls.Add(groupBox1);
            AlaPanel.Controls.Add(HPuhelinTB);
            AlaPanel.Controls.Add(HHuonetyyppiCB);
            AlaPanel.Controls.Add(HTyhjennaKentatBT);
            AlaPanel.Controls.Add(HPoistaBT);
            AlaPanel.Controls.Add(HMuokkaBt);
            AlaPanel.Controls.Add(HLisääUusiHuoneBT);
            AlaPanel.Controls.Add(HVapaaLB);
            AlaPanel.Controls.Add(HPuhelinLB);
            AlaPanel.Controls.Add(HuoneTyyppiLB);
            AlaPanel.Controls.Add(HHuoneNroTB);
            AlaPanel.Controls.Add(HuoneidenHallintaDG);
            AlaPanel.Controls.Add(HuonenNroLB);
            AlaPanel.Dock = DockStyle.Fill;
            AlaPanel.Location = new Point(0, 98);
            AlaPanel.Name = "AlaPanel";
            AlaPanel.Size = new Size(1271, 405);
            AlaPanel.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(231, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 96);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vaihtoehdot";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.Red;
            radioButton2.Location = new Point(183, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 33);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "EI";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Green;
            radioButton1.Location = new Point(17, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 33);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "KYLLÄ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // HPuhelinTB
            // 
            HPuhelinTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HPuhelinTB.Location = new Point(231, 99);
            HPuhelinTB.Name = "HPuhelinTB";
            HPuhelinTB.Size = new Size(318, 36);
            HPuhelinTB.TabIndex = 22;
            // 
            // HHuonetyyppiCB
            // 
            HHuonetyyppiCB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HHuonetyyppiCB.FormattingEnabled = true;
            HHuonetyyppiCB.Location = new Point(231, 56);
            HHuonetyyppiCB.Name = "HHuonetyyppiCB";
            HHuonetyyppiCB.Size = new Size(318, 37);
            HHuonetyyppiCB.TabIndex = 19;
            // 
            // HTyhjennaKentatBT
            // 
            HTyhjennaKentatBT.BackColor = Color.SkyBlue;
            HTyhjennaKentatBT.FlatStyle = FlatStyle.Popup;
            HTyhjennaKentatBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HTyhjennaKentatBT.ForeColor = Color.White;
            HTyhjennaKentatBT.Location = new Point(157, 322);
            HTyhjennaKentatBT.Name = "HTyhjennaKentatBT";
            HTyhjennaKentatBT.Size = new Size(222, 42);
            HTyhjennaKentatBT.TabIndex = 18;
            HTyhjennaKentatBT.Text = "Tyhjennä kentät";
            HTyhjennaKentatBT.UseVisualStyleBackColor = false;
            // 
            // HPoistaBT
            // 
            HPoistaBT.BackColor = Color.SkyBlue;
            HPoistaBT.FlatStyle = FlatStyle.Popup;
            HPoistaBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HPoistaBT.ForeColor = Color.White;
            HPoistaBT.Location = new Point(12, 322);
            HPoistaBT.Name = "HPoistaBT";
            HPoistaBT.Size = new Size(139, 42);
            HPoistaBT.TabIndex = 17;
            HPoistaBT.Text = "Poista";
            HPoistaBT.UseVisualStyleBackColor = false;
            // 
            // HMuokkaBt
            // 
            HMuokkaBt.BackColor = Color.SkyBlue;
            HMuokkaBt.FlatStyle = FlatStyle.Popup;
            HMuokkaBt.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HMuokkaBt.ForeColor = Color.White;
            HMuokkaBt.Location = new Point(269, 265);
            HMuokkaBt.Name = "HMuokkaBt";
            HMuokkaBt.Size = new Size(222, 42);
            HMuokkaBt.TabIndex = 16;
            HMuokkaBt.Text = "Muokka";
            HMuokkaBt.UseVisualStyleBackColor = false;
            // 
            // HLisääUusiHuoneBT
            // 
            HLisääUusiHuoneBT.BackColor = Color.SkyBlue;
            HLisääUusiHuoneBT.FlatStyle = FlatStyle.Popup;
            HLisääUusiHuoneBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HLisääUusiHuoneBT.ForeColor = Color.Snow;
            HLisääUusiHuoneBT.Location = new Point(12, 265);
            HLisääUusiHuoneBT.Name = "HLisääUusiHuoneBT";
            HLisääUusiHuoneBT.Size = new Size(251, 42);
            HLisääUusiHuoneBT.TabIndex = 15;
            HLisääUusiHuoneBT.Text = "Lisää uusi huone";
            HLisääUusiHuoneBT.UseVisualStyleBackColor = false;
            // 
            // HVapaaLB
            // 
            HVapaaLB.AutoSize = true;
            HVapaaLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HVapaaLB.Location = new Point(12, 150);
            HVapaaLB.Name = "HVapaaLB";
            HVapaaLB.Size = new Size(87, 29);
            HVapaaLB.TabIndex = 5;
            HVapaaLB.Text = "Vapaa:";
            // 
            // HPuhelinLB
            // 
            HPuhelinLB.AutoSize = true;
            HPuhelinLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HPuhelinLB.Location = new Point(12, 108);
            HPuhelinLB.Name = "HPuhelinLB";
            HPuhelinLB.Size = new Size(96, 29);
            HPuhelinLB.TabIndex = 4;
            HPuhelinLB.Text = "Puhelin:";
            // 
            // HuoneTyyppiLB
            // 
            HuoneTyyppiLB.AutoSize = true;
            HuoneTyyppiLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HuoneTyyppiLB.Location = new Point(12, 66);
            HuoneTyyppiLB.Name = "HuoneTyyppiLB";
            HuoneTyyppiLB.Size = new Size(165, 29);
            HuoneTyyppiLB.TabIndex = 3;
            HuoneTyyppiLB.Text = "Huonentyyppi:";
            // 
            // HHuoneNroTB
            // 
            HHuoneNroTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HHuoneNroTB.Location = new Point(221, 18);
            HHuoneNroTB.Name = "HHuoneNroTB";
            HHuoneNroTB.Size = new Size(318, 36);
            HHuoneNroTB.TabIndex = 2;
            // 
            // HuoneidenHallintaDG
            // 
            HuoneidenHallintaDG.BackgroundColor = Color.WhiteSmoke;
            HuoneidenHallintaDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HuoneidenHallintaDG.Dock = DockStyle.Right;
            HuoneidenHallintaDG.Location = new Point(620, 0);
            HuoneidenHallintaDG.Name = "HuoneidenHallintaDG";
            HuoneidenHallintaDG.RowHeadersWidth = 62;
            HuoneidenHallintaDG.Size = new Size(651, 405);
            HuoneidenHallintaDG.TabIndex = 1;
            // 
            // HuonenNroLB
            // 
            HuonenNroLB.AutoSize = true;
            HuonenNroLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HuonenNroLB.Location = new Point(12, 21);
            HuonenNroLB.Name = "HuonenNroLB";
            HuonenNroLB.Size = new Size(191, 29);
            HuonenNroLB.TabIndex = 0;
            HuonenNroLB.Text = "Huonen numero:";
            // 
            // YlaPanel
            // 
            YlaPanel.BackColor = Color.SkyBlue;
            YlaPanel.Controls.Add(HuoneidenHallintaLB);
            YlaPanel.Dock = DockStyle.Top;
            YlaPanel.Location = new Point(0, 0);
            YlaPanel.Name = "YlaPanel";
            YlaPanel.Size = new Size(1271, 98);
            YlaPanel.TabIndex = 4;
            // 
            // HuoneidenHallintaLB
            // 
            HuoneidenHallintaLB.AutoSize = true;
            HuoneidenHallintaLB.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuoneidenHallintaLB.ForeColor = Color.White;
            HuoneidenHallintaLB.Location = new Point(379, 18);
            HuoneidenHallintaLB.Name = "HuoneidenHallintaLB";
            HuoneidenHallintaLB.Size = new Size(529, 63);
            HuoneidenHallintaLB.TabIndex = 0;
            HuoneidenHallintaLB.Text = "Huoneiden Hallinta";
            // 
            // Huoneiden_Hallinta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 503);
            Controls.Add(AlaPanel);
            Controls.Add(YlaPanel);
            Name = "Huoneiden_Hallinta";
            Text = "Huoneiden_Hallinta";
            AlaPanel.ResumeLayout(false);
            AlaPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HuoneidenHallintaDG).EndInit();
            YlaPanel.ResumeLayout(false);
            YlaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AlaPanel;
        private ComboBox HHuonetyyppiCB;
        private Button HTyhjennaKentatBT;
        private Button HPoistaBT;
        private Button HMuokkaBt;
        private Button HLisääUusiHuoneBT;
        private Label HVapaaLB;
        private Label HPuhelinLB;
        private Label HuoneTyyppiLB;
        private TextBox HHuoneNroTB;
        private DataGridView HuoneidenHallintaDG;
        private Label HuonenNroLB;
        private Panel YlaPanel;
        private Label HuoneidenHallintaLB;
        private TextBox HPuhelinTB;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}