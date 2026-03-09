namespace HotelliProjekti
{
    partial class KirjautumisikkunaFM
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
            KaytajaNTB = new TextBox();
            label3 = new Label();
            SalasanaTB = new TextBox();
            KirjauduSisäänBT = new Button();
            label4 = new Label();
            VirheViestiLB = new Label();
            VirheViesti2LB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(437, 63);
            label1.TabIndex = 0;
            label1.Text = "Kirjaudu Sisään";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 1;
            label2.Text = "Käyttäjän nimi";
            // 
            // KaytajaNTB
            // 
            KaytajaNTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KaytajaNTB.Location = new Point(12, 179);
            KaytajaNTB.Name = "KaytajaNTB";
            KaytajaNTB.Size = new Size(353, 36);
            KaytajaNTB.TabIndex = 2;
           //
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(126, 34);
            label3.TabIndex = 3;
            label3.Text = "Salasana";
            // 
            // SalasanaTB
            // 
            SalasanaTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalasanaTB.Location = new Point(12, 313);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(353, 36);
            SalasanaTB.TabIndex = 4;
            // 
            // KirjauduSisäänBT
            // 
            KirjauduSisäänBT.BackColor = Color.SteelBlue;
            KirjauduSisäänBT.FlatStyle = FlatStyle.Popup;
            KirjauduSisäänBT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KirjauduSisäänBT.ForeColor = Color.Snow;
            KirjauduSisäänBT.Location = new Point(12, 407);
            KirjauduSisäänBT.Name = "KirjauduSisäänBT";
            KirjauduSisäänBT.Size = new Size(202, 66);
            KirjauduSisäänBT.TabIndex = 5;
            KirjauduSisäänBT.Text = "Kirjaudu sisään";
            KirjauduSisäänBT.UseVisualStyleBackColor = false;
            KirjauduSisäänBT.Click += KirjauduSisäänBT_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 6;
            // 
            // VirheViestiLB
            // 
            VirheViestiLB.AutoSize = true;
            VirheViestiLB.ForeColor = Color.Red;
            VirheViestiLB.Location = new Point(12, 218);
            VirheViestiLB.Name = "VirheViestiLB";
            VirheViestiLB.Size = new Size(282, 22);
            VirheViestiLB.TabIndex = 7;
            VirheViestiLB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViestiLB.Visible = false;
            // 
            // VirheViesti2LB
            // 
            VirheViesti2LB.AutoSize = true;
            VirheViesti2LB.ForeColor = Color.Red;
            VirheViesti2LB.Location = new Point(12, 352);
            VirheViesti2LB.Name = "VirheViesti2LB";
            VirheViesti2LB.Size = new Size(282, 22);
            VirheViesti2LB.TabIndex = 8;
            VirheViesti2LB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViesti2LB.Visible = false;
            // 
            // KirjautumisikkunaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(460, 485);
            Controls.Add(VirheViesti2LB);
            Controls.Add(VirheViestiLB);
            Controls.Add(label4);
            Controls.Add(KirjauduSisäänBT);
            Controls.Add(SalasanaTB);
            Controls.Add(label3);
            Controls.Add(KaytajaNTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "KirjautumisikkunaFM";
            Text = "Kirjautumisikkuna";
            Load += KirjautumisikkunaFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void KirjautumisikkunaFM_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void KaytajanNTB_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox KaytajaNTB;
        private Label label3;
        private TextBox SalasanaTB;
        private Button KirjauduSisäänBT;
        private Label label4;
        private Label VirheViestiLB;
        private Label VirheViesti2LB;
    }
}
