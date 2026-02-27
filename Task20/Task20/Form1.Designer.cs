namespace Task20
{
    partial class Form1
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
            a = new Label();
            b = new Label();
            c = new Label();
            d = new Label();
            f = new Label();
            g = new Label();
            TallennaTB = new Button();
            IdTB = new TextBox();
            EnimiTB = new TextBox();
            SnimiTB = new TextBox();
            PuhTB = new TextBox();
            EmailTB = new TextBox();
            ONroTB = new TextBox();
            TyhennaTB = new Button();
            PaivitaTB = new Button();
            PoistaBT = new Button();
            TietotauluDG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).BeginInit();
            SuspendLayout();
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(12, 42);
            a.Name = "a";
            a.Size = new Size(61, 38);
            a.TabIndex = 0;
            a.Text = "ID:";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b.Location = new Point(12, 104);
            b.Name = "b";
            b.Size = new Size(159, 38);
            b.TabIndex = 1;
            b.Text = "Etunimi:";
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c.Location = new Point(12, 156);
            c.Name = "c";
            c.Size = new Size(184, 38);
            c.TabIndex = 2;
            c.Text = "Sukunimi:";
            // 
            // d
            // 
            d.AutoSize = true;
            d.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            d.Location = new Point(444, 48);
            d.Name = "d";
            d.Size = new Size(163, 38);
            d.TabIndex = 3;
            d.Text = "Puhelin:";
            // 
            // f
            // 
            f.AutoSize = true;
            f.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            f.Location = new Point(444, 104);
            f.Name = "f";
            f.Size = new Size(222, 38);
            f.TabIndex = 4;
            f.Text = "Sähköposti:";
            // 
            // g
            // 
            g.AutoSize = true;
            g.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g.Location = new Point(444, 157);
            g.Name = "g";
            g.Size = new Size(270, 38);
            g.TabIndex = 5;
            g.Text = "OpiskelijaNro:";
            // 
            // TallennaTB
            // 
            TallennaTB.Location = new Point(227, 220);
            TallennaTB.Name = "TallennaTB";
            TallennaTB.Size = new Size(184, 51);
            TallennaTB.TabIndex = 6;
            TallennaTB.Text = "Tallenna";
            TallennaTB.UseVisualStyleBackColor = true;
            TallennaTB.Click += TallennaTB_Click;
            // 
            // IdTB
            // 
            IdTB.Location = new Point(184, 48);
            IdTB.Name = "IdTB";
            IdTB.Size = new Size(243, 31);
            IdTB.TabIndex = 7;
            // 
            // EnimiTB
            // 
            EnimiTB.Location = new Point(184, 110);
            EnimiTB.Name = "EnimiTB";
            EnimiTB.Size = new Size(243, 31);
            EnimiTB.TabIndex = 8;
            // 
            // SnimiTB
            // 
            SnimiTB.Location = new Point(195, 163);
            SnimiTB.Name = "SnimiTB";
            SnimiTB.Size = new Size(243, 31);
            SnimiTB.TabIndex = 9;
            // 
            // PuhTB
            // 
            PuhTB.Location = new Point(613, 48);
            PuhTB.Name = "PuhTB";
            PuhTB.Size = new Size(243, 31);
            PuhTB.TabIndex = 10;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(669, 110);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(243, 31);
            EmailTB.TabIndex = 11;
            // 
            // ONroTB
            // 
            ONroTB.Location = new Point(708, 156);
            ONroTB.Name = "ONroTB";
            ONroTB.Size = new Size(204, 31);
            ONroTB.TabIndex = 12;
            // 
            // TyhennaTB
            // 
            TyhennaTB.Location = new Point(12, 220);
            TyhennaTB.Name = "TyhennaTB";
            TyhennaTB.Size = new Size(184, 51);
            TyhennaTB.TabIndex = 13;
            TyhennaTB.Text = "Tyhjenna";
            TyhennaTB.UseVisualStyleBackColor = true;
            TyhennaTB.Click += TyhennaTB_Click;
            // 
            // PaivitaTB
            // 
            PaivitaTB.Location = new Point(444, 220);
            PaivitaTB.Name = "PaivitaTB";
            PaivitaTB.Size = new Size(184, 51);
            PaivitaTB.TabIndex = 14;
            PaivitaTB.Text = "PaivitaBT";
            PaivitaTB.UseVisualStyleBackColor = true;
            PaivitaTB.Click += PaivitaTB_Click;
            // 
            // PoistaBT
            // 
            PoistaBT.Location = new Point(672, 220);
            PoistaBT.Name = "PoistaBT";
            PoistaBT.Size = new Size(184, 51);
            PoistaBT.TabIndex = 15;
            PoistaBT.Text = "Poista";
            PoistaBT.UseVisualStyleBackColor = true;
            PoistaBT.Click += PoistaBT_Click_1;
            // 
            // TietotauluDG
            // 
            TietotauluDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TietotauluDG.Location = new Point(12, 289);
            TietotauluDG.Name = "TietotauluDG";
            TietotauluDG.RowHeadersWidth = 62;
            TietotauluDG.Size = new Size(900, 448);
            TietotauluDG.TabIndex = 16;
            TietotauluDG.CellContentClick += TietotauluDG_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 749);
            Controls.Add(TietotauluDG);
            Controls.Add(PoistaBT);
            Controls.Add(PaivitaTB);
            Controls.Add(TyhennaTB);
            Controls.Add(ONroTB);
            Controls.Add(EmailTB);
            Controls.Add(PuhTB);
            Controls.Add(SnimiTB);
            Controls.Add(EnimiTB);
            Controls.Add(IdTB);
            Controls.Add(TallennaTB);
            Controls.Add(g);
            Controls.Add(f);
            Controls.Add(d);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label a;
        private Label b;
        private Label c;
        private Label d;
        private Label f;
        private Label g;
        private Button TallennaTB;
        private TextBox IdTB;
        private TextBox EnimiTB;
        private TextBox SnimiTB;
        private TextBox PuhTB;
        private TextBox EmailTB;
        private TextBox ONroTB;
        private Button TyhennaTB;
        private Button PaivitaTB;
        private Button PoistaBT;
        private DataGridView TietotauluDG;
    }
}
