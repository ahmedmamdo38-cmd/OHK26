namespace Task6
{
    partial class SalasanaTarkustusFM
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
            SalasanaPanel = new Panel();
            SalasanaOikeanPanel = new Panel();
            label3 = new Label();
            VirheViestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeanPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(SalasanaOikeanPanel);
            SalasanaPanel.Controls.Add(VirheViestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(917, 341);
            SalasanaPanel.TabIndex = 0;
            // 
            // SalasanaOikeanPanel
            // 
            SalasanaOikeanPanel.BackColor = Color.DarkRed;
            SalasanaOikeanPanel.Controls.Add(label3);
            SalasanaOikeanPanel.Dock = DockStyle.Fill;
            SalasanaOikeanPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SalasanaOikeanPanel.ForeColor = Color.Snow;
            SalasanaOikeanPanel.Location = new Point(0, 0);
            SalasanaOikeanPanel.Name = "SalasanaOikeanPanel";
            SalasanaOikeanPanel.Size = new Size(917, 341);
            SalasanaOikeanPanel.TabIndex = 1;
            SalasanaOikeanPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(896, 120);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleini";
            label3.Click += label3_Click;
            // 
            // VirheViestiLB
            // 
            VirheViestiLB.AutoSize = true;
            VirheViestiLB.Location = new Point(35, 233);
            VirheViestiLB.Name = "VirheViestiLB";
            VirheViestiLB.Size = new Size(103, 48);
            VirheViestiLB.TabIndex = 5;
            VirheViestiLB.Text = "Virhe";
            VirheViestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.BackColor = Color.Gold;
            TarkistaBT.ForeColor = Color.MediumBlue;
            TarkistaBT.Location = new Point(696, 73);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(162, 77);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = false;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalasanaTB.Location = new Point(293, 137);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(345, 50);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KayttajaTB.Location = new Point(293, 40);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(345, 50);
            KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 137);
            label2.Name = "label2";
            label2.Size = new Size(143, 44);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(200, 44);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjänimi:";
            // 
            // SalasanaTarkustusFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 341);
            Controls.Add(SalasanaPanel);
            Name = "SalasanaTarkustusFM";
            Text = "Salasana tarkustus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeanPanel.ResumeLayout(false);
            SalasanaOikeanPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label label2;
        private Label label1;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label VirheViestiLB;
        private Panel SalasanaOikeanPanel;
        private Label label3;
    }
}
