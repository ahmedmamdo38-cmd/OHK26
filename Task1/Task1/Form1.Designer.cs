namespace Task1
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
            OtsikkoLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Location = new Point(75, 35);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(73, 25);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Otsikko";
            // 
            // VaihdaBT
            // 
            VaihdaBT.Location = new Point(43, 76);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(145, 60);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Vaihda teksti";
            VaihdaBT.UseVisualStyleBackColor = true;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VaihdaBT);
            Controls.Add(OtsikkoLB);
            Name = "Form1";
            Text = "Harjoitus1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
    }
}
