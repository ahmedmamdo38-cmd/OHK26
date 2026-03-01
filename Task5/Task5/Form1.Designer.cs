namespace Task5
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
            UusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(394, 45);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (0-999 lopetus):";
            // 
            // UusiLukuTB
            // 
            UusiLukuTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UusiLukuTB.Location = new Point(440, 38);
            UusiLukuTB.Name = "UusiLukuTB";
            UusiLukuTB.Size = new Size(373, 50);
            UusiLukuTB.TabIndex = 1;
            UusiLukuTB.KeyPress += UusiLukuTB_KeyPress;
            UusiLukuTB.KeyUp += UusiLukuTB_KeyUp;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(40, 130);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(124, 45);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "vastaus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 422);
            Controls.Add(VastausLB);
            Controls.Add(UusiLukuTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UusiLukuTB;
        private Label VastausLB;
    }
}
