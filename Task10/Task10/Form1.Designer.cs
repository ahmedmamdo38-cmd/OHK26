namespace Task10
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
            P = new Label();
            label1 = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P.Location = new Point(43, 69);
            P.Name = "P";
            P.Size = new Size(209, 51);
            P.TabIndex = 0;
            P.Text = "Anna paino :";
            P.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 160);
            label1.Name = "label1";
            label1.Size = new Size(212, 51);
            label1.TabIndex = 1;
            label1.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PainoTB.Location = new Point(258, 68);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(150, 52);
            PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            PituusTB.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PituusTB.Location = new Point(258, 162);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(150, 52);
            PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskeBT.Location = new Point(43, 240);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(365, 56);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Papyrus", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(43, 326);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(131, 44);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus ";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(474, 465);
            Controls.Add(VastausLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(label1);
            Controls.Add(P);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label P;
        private Label label1;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label VastausLB;
    }
}
