namespace Task11
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
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            HeitaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 114);
            label1.TabIndex = 0;
            label1.Text = "Nopan heitto";
            // 
            // noppa01PB
            // 
            noppa01PB.Image = Properties.Resources.dice01;
            noppa01PB.Location = new Point(60, 182);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(198, 226);
            noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa01PB.TabIndex = 1;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.dice01;
            noppa02PB.Location = new Point(291, 182);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(203, 226);
            noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa02PB.TabIndex = 2;
            noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            HeitaBT.BackColor = Color.OliveDrab;
            HeitaBT.Location = new Point(60, 441);
            HeitaBT.Name = "HeitaBT";
            HeitaBT.Size = new Size(434, 98);
            HeitaBT.TabIndex = 3;
            HeitaBT.Text = "Heitä ";
            HeitaBT.UseVisualStyleBackColor = false;
            HeitaBT.Click += HeitaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(546, 591);
            Controls.Add(HeitaBT);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button HeitaBT;
    }
}
