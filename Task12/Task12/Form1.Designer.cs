namespace Task12
{
    partial class KysymysLomakeFM
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
            KysymysLB = new Label();
            VastausLB = new Label();
            groupBox1 = new GroupBox();
            p = new RadioButton();
            ARB = new RadioButton();
            BRB = new RadioButton();
            CRB = new RadioButton();
            DRB = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            KysymysLB.Location = new Point(40, 23);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(393, 51);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 10.kysymykseen:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(40, 209);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(224, 51);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus labeli";
            VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DRB);
            groupBox1.Controls.Add(CRB);
            groupBox1.Controls.Add(BRB);
            groupBox1.Controls.Add(ARB);
            groupBox1.Controls.Add(p);
            groupBox1.Font = new Font("Papyrus", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(465, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 262);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vastaus";
            // 
            // p
            // 
            p.AutoSize = true;
            p.Location = new Point(17, 45);
            p.Name = "p";
            p.Size = new Size(53, 38);
            p.TabIndex = 0;
            p.Text = "p";
            p.UseVisualStyleBackColor = true;
            p.Visible = false;
            // 
            // ARB
            // 
            ARB.AutoSize = true;
            ARB.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARB.Location = new Point(17, 49);
            ARB.Name = "ARB";
            ARB.Size = new Size(56, 32);
            ARB.TabIndex = 1;
            ARB.Text = "A";
            ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            BRB.AutoSize = true;
            BRB.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRB.Location = new Point(17, 98);
            BRB.Name = "BRB";
            BRB.Size = new Size(55, 32);
            BRB.TabIndex = 2;
            BRB.Text = "B";
            BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            CRB.AutoSize = true;
            CRB.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CRB.Location = new Point(17, 146);
            CRB.Name = "CRB";
            CRB.Size = new Size(56, 32);
            CRB.TabIndex = 3;
            CRB.Text = "C";
            CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            DRB.AutoSize = true;
            DRB.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DRB.Location = new Point(17, 199);
            DRB.Name = "DRB";
            DRB.Size = new Size(55, 32);
            DRB.TabIndex = 4;
            DRB.Text = "D";
            DRB.UseVisualStyleBackColor = true;
            // 
            // KysymysLomakeFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 310);
            Controls.Add(groupBox1);
            Controls.Add(VastausLB);
            Controls.Add(KysymysLB);
            Name = "KysymysLomakeFM";
            Text = "Kysmyslomeke";
            Load += KysymysLomakeFM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton DRB;
        private RadioButton CRB;
        private RadioButton BRB;
        private RadioButton ARB;
        private RadioButton p;
    }
}
