namespace HotelliProjekti
{
    partial class Paaikkuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ValikkoMS = new MenuStrip();
            hallitseAsiakkaitaToolStripMenuItem = new ToolStripMenuItem();
            hallitseToolStripMenuItem = new ToolStripMenuItem();
            hallitseHuoneitaToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ValikkoMS.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.hotelimage;
            pictureBox1.Location = new Point(0, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1250, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(568, 130);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 1;
            label1.Text = " Tervetuloa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 182);
            label2.Name = "label2";
            label2.Size = new Size(284, 26);
            label2.TabIndex = 2;
            label2.Text = "----------------------------------";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(472, 225);
            label3.Name = "label3";
            label3.Size = new Size(329, 68);
            label3.TabIndex = 3;
            label3.Text = " Royal Hotel";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ValikkoMS
            // 
            ValikkoMS.BackColor = Color.PaleTurquoise;
            ValikkoMS.ImageScalingSize = new Size(24, 24);
            ValikkoMS.Items.AddRange(new ToolStripItem[] { hallitseAsiakkaitaToolStripMenuItem, hallitseToolStripMenuItem, hallitseHuoneitaToolStripMenuItem });
            ValikkoMS.Location = new Point(0, 0);
            ValikkoMS.Name = "ValikkoMS";
            ValikkoMS.Size = new Size(1250, 33);
            ValikkoMS.TabIndex = 4;
            ValikkoMS.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            hallitseAsiakkaitaToolStripMenuItem.Size = new Size(171, 29);
            hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita ";
            // 
            // hallitseToolStripMenuItem
            // 
            hallitseToolStripMenuItem.Name = "hallitseToolStripMenuItem";
            hallitseToolStripMenuItem.Size = new Size(163, 29);
            hallitseToolStripMenuItem.Text = "Hallitse varauksia";
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            hallitseHuoneitaToolStripMenuItem.Size = new Size(159, 29);
            hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 314);
            label4.Name = "label4";
            label4.Size = new Size(396, 58);
            label4.TabIndex = 5;
            label4.Text = "Tervetuloa Hotellisovellukseen.\r\nValitse valikoista, mitä haluat tehdä.\r\n";
            // 
            // Paaikkuna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1250, 554);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ValikkoMS);
            MainMenuStrip = ValikkoMS;
            Name = "Paaikkuna";
            Text = "Paaikkuna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ValikkoMS.ResumeLayout(false);
            ValikkoMS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip ValikkoMS;
        private ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private ToolStripMenuItem hallitseToolStripMenuItem;
        private ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
        private Label label4;
    }
}