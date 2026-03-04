namespace Task9
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
            label1 = new Label();
            VastausLB = new Label();
            AsteetTB = new TextBox();
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelsiusRB = new RadioButton();
            MuunnaBT = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 99);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(28, 237);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(127, 45);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // AsteetTB
            // 
            AsteetTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AsteetTB.Location = new Point(229, 99);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(150, 50);
            AsteetTB.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Location = new Point(403, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunat?";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Location = new Point(21, 92);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(118, 29);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Location = new Point(21, 46);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(91, 29);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(736, 96);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(125, 62);
            MuunnaBT.TabIndex = 2;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 450);
            Controls.Add(MuunnaBT);
            Controls.Add(groupBox1);
            Controls.Add(AsteetTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox AsteetTB;
        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Button MuunnaBT;
    }
}
