namespace HotelProject
{
    partial class HomePage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            manageCustomersToolStripMenuItem = new ToolStripMenuItem();
            manageRoomsToolStripMenuItem = new ToolStripMenuItem();
            manageReseversationsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 55);
            label1.Name = "label1";
            label1.Size = new Size(438, 139);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(432, 170);
            label2.Name = "label2";
            label2.Size = new Size(538, 104);
            label2.TabIndex = 1;
            label2.Text = "-------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(563, 259);
            label3.Name = "label3";
            label3.Size = new Size(271, 75);
            label3.TabIndex = 2;
            label3.Text = "Royal Hotel ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(328, 334);
            label4.Name = "label4";
            label4.Size = new Size(796, 189);
            label4.TabIndex = 3;
            label4.Text = "Welcome to the Royal Hotel websites\r\nChose from sections, what you need \r\n\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageCustomersToolStripMenuItem, manageRoomsToolStripMenuItem, manageReseversationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1403, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageCustomersToolStripMenuItem
            // 
            manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            manageCustomersToolStripMenuItem.Size = new Size(182, 29);
            manageCustomersToolStripMenuItem.Text = "Manage Customers";
            manageCustomersToolStripMenuItem.Click += manageCustomersToolStripMenuItem_Click;
            // 
            // manageRoomsToolStripMenuItem
            // 
            manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            manageRoomsToolStripMenuItem.Size = new Size(153, 29);
            manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            manageRoomsToolStripMenuItem.Click += manageRoomsToolStripMenuItem_Click;
            // 
            // manageReseversationsToolStripMenuItem
            // 
            manageReseversationsToolStripMenuItem.Name = "manageReseversationsToolStripMenuItem";
            manageReseversationsToolStripMenuItem.Size = new Size(213, 29);
            manageReseversationsToolStripMenuItem.Text = "Manage Reseversations";
            manageReseversationsToolStripMenuItem.Click += manageReseversationsToolStripMenuItem_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 626);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "HomePage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageCustomersToolStripMenuItem;
        private ToolStripMenuItem manageRoomsToolStripMenuItem;
        private ToolStripMenuItem manageReseversationsToolStripMenuItem;
    }
}