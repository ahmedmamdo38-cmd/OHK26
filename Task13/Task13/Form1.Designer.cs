namespace Task13
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
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(708, 38);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // NimiTB
            // 
            NimiTB.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NimiTB.Location = new Point(749, 34);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(351, 36);
            NimiTB.TabIndex = 1;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TarkastaBT.Location = new Point(968, 99);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(132, 46);
            TarkastaBT.TabIndex = 2;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(35, 107);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(176, 38);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus labeli";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 251);
            Controls.Add(VastausLB);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Button TarkastaBT;
        private Label VastausLB;
    }
}
