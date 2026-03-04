namespace Task18
{
    partial class OppilaitosKeyFM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OppilaitoksetCB = new ComboBox();
            VastuuHloCB = new ComboBox();
            ONimiLB = new Label();
            OKatuosoiteLB = new Label();
            OPostinumeroLB = new Label();
            OPostitoimipaikkaLB = new Label();
            OPuhelinLB = new Label();
            VNimiLB = new Label();
            VTitteliLB = new Label();
            VSijaintiLB = new Label();
            VSahkopostiLB = new Label();
            VPuhelinLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(819, 100);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(288, 51);
            label2.TabIndex = 1;
            label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(478, 158);
            label3.Name = "label3";
            label3.Size = new Size(353, 51);
            label3.TabIndex = 2;
            label3.Text = "Valitse vastuuhenkilöt:";
            // 
            // OppilaitoksetCB
            // 
            OppilaitoksetCB.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OppilaitoksetCB.FormattingEnabled = true;
            OppilaitoksetCB.Location = new Point(22, 228);
            OppilaitoksetCB.Name = "OppilaitoksetCB";
            OppilaitoksetCB.Size = new Size(278, 52);
            OppilaitoksetCB.TabIndex = 3;
            OppilaitoksetCB.SelectedIndexChanged += OppilaitoksetCB_SelectedIndexChanged;
            // 
            // VastuuHloCB
            // 
            VastuuHloCB.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VastuuHloCB.FormattingEnabled = true;
            VastuuHloCB.Location = new Point(478, 228);
            VastuuHloCB.Name = "VastuuHloCB";
            VastuuHloCB.Size = new Size(353, 52);
            VastuuHloCB.TabIndex = 4;
            VastuuHloCB.SelectedIndexChanged += VastuuHloCB_SelectedIndexChanged;
            // 
            // ONimiLB
            // 
            ONimiLB.AutoSize = true;
            ONimiLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ONimiLB.Location = new Point(22, 310);
            ONimiLB.Name = "ONimiLB";
            ONimiLB.Size = new Size(107, 38);
            ONimiLB.TabIndex = 5;
            ONimiLB.Text = "ONIMI";
            // 
            // OKatuosoiteLB
            // 
            OKatuosoiteLB.AutoSize = true;
            OKatuosoiteLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OKatuosoiteLB.Location = new Point(22, 359);
            OKatuosoiteLB.Name = "OKatuosoiteLB";
            OKatuosoiteLB.Size = new Size(173, 38);
            OKatuosoiteLB.TabIndex = 6;
            OKatuosoiteLB.Text = "OKatuosoite";
            // 
            // OPostinumeroLB
            // 
            OPostinumeroLB.AutoSize = true;
            OPostinumeroLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OPostinumeroLB.Location = new Point(22, 413);
            OPostinumeroLB.Name = "OPostinumeroLB";
            OPostinumeroLB.Size = new Size(184, 38);
            OPostinumeroLB.TabIndex = 7;
            OPostinumeroLB.Text = "OPostinumero";
            // 
            // OPostitoimipaikkaLB
            // 
            OPostitoimipaikkaLB.AutoSize = true;
            OPostitoimipaikkaLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OPostitoimipaikkaLB.Location = new Point(22, 467);
            OPostitoimipaikkaLB.Name = "OPostitoimipaikkaLB";
            OPostitoimipaikkaLB.Size = new Size(227, 38);
            OPostitoimipaikkaLB.TabIndex = 8;
            OPostitoimipaikkaLB.Text = "OPostitoimipaikka";
            // 
            // OPuhelinLB
            // 
            OPuhelinLB.AutoSize = true;
            OPuhelinLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OPuhelinLB.Location = new Point(22, 519);
            OPuhelinLB.Name = "OPuhelinLB";
            OPuhelinLB.Size = new Size(129, 38);
            OPuhelinLB.TabIndex = 9;
            OPuhelinLB.Text = "OPuhelin";
            // 
            // VNimiLB
            // 
            VNimiLB.AutoSize = true;
            VNimiLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VNimiLB.Location = new Point(478, 310);
            VNimiLB.Name = "VNimiLB";
            VNimiLB.Size = new Size(88, 38);
            VNimiLB.TabIndex = 10;
            VNimiLB.Text = "VNimi";
            // 
            // VTitteliLB
            // 
            VTitteliLB.AutoSize = true;
            VTitteliLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VTitteliLB.Location = new Point(478, 359);
            VTitteliLB.Name = "VTitteliLB";
            VTitteliLB.Size = new Size(113, 38);
            VTitteliLB.TabIndex = 11;
            VTitteliLB.Text = "VTitteli";
            // 
            // VSijaintiLB
            // 
            VSijaintiLB.AutoSize = true;
            VSijaintiLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VSijaintiLB.Location = new Point(478, 413);
            VSijaintiLB.Name = "VSijaintiLB";
            VSijaintiLB.Size = new Size(121, 38);
            VSijaintiLB.TabIndex = 12;
            VSijaintiLB.Text = "VSijainti";
            // 
            // VSahkopostiLB
            // 
            VSahkopostiLB.AutoSize = true;
            VSahkopostiLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VSahkopostiLB.Location = new Point(478, 467);
            VSahkopostiLB.Name = "VSahkopostiLB";
            VSahkopostiLB.Size = new Size(171, 38);
            VSahkopostiLB.TabIndex = 13;
            VSahkopostiLB.Text = "VSahkoposti";
            // 
            // VPuhelinLB
            // 
            VPuhelinLB.AutoSize = true;
            VPuhelinLB.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VPuhelinLB.Location = new Point(478, 519);
            VPuhelinLB.Name = "VPuhelinLB";
            VPuhelinLB.Size = new Size(122, 38);
            VPuhelinLB.TabIndex = 14;
            VPuhelinLB.Text = "VPuhelin";
            // 
            // OppilaitosKeyFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 579);
            Controls.Add(VPuhelinLB);
            Controls.Add(VSahkopostiLB);
            Controls.Add(VSijaintiLB);
            Controls.Add(VTitteliLB);
            Controls.Add(VNimiLB);
            Controls.Add(OPuhelinLB);
            Controls.Add(OPostitoimipaikkaLB);
            Controls.Add(OPostinumeroLB);
            Controls.Add(OKatuosoiteLB);
            Controls.Add(ONimiLB);
            Controls.Add(VastuuHloCB);
            Controls.Add(OppilaitoksetCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OppilaitosKeyFM";
            Text = "Oppilaitosten avainhenkilöt";
            Load += OppilaitosKeyFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox OppilaitoksetCB;
        private ComboBox VastuuHloCB;
        private Label ONimiLB;
        private Label OKatuosoiteLB;
        private Label OPostinumeroLB;
        private Label OPostitoimipaikkaLB;
        private Label OPuhelinLB;
        private Label VNimiLB;
        private Label VTitteliLB;
        private Label VSijaintiLB;
        private Label VSahkopostiLB;
        private Label VPuhelinLB;
    }
}
