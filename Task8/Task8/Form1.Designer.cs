namespace Task8
{
    partial class RoomaNroFM
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
            label2 = new Label();
            label1 = new Label();
            TekstiTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 19);
            label2.Name = "label2";
            label2.Size = new Size(702, 114);
            label2.TabIndex = 1;
            label2.Text = "Roomalaiset numerot";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(856, 51);
            label1.TabIndex = 2;
            label1.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaseksi:";
            // 
            // TekstiTB
            // 
            TekstiTB.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TekstiTB.Location = new Point(905, 181);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(247, 53);
            TekstiTB.TabIndex = 3;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 279);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(224, 51);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus labeli";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.BackColor = Color.LightGoldenrodYellow;
            MuutaBT.Font = new Font("Papyrus", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MuutaBT.Location = new Point(905, 279);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(247, 61);
            MuutaBT.TabIndex = 5;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = false;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // RoomaNroFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Roman_numerals_2;
            ClientSize = new Size(1302, 595);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(TekstiTB);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "RoomaNroFM";
            Text = "Roomalaiset numerot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}
