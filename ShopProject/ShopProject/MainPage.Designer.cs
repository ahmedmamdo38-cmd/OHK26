namespace ShopProject
{
    partial class MainPage
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
            menuStrip1 = new MenuStrip();
            menToolStripMenuItem = new ToolStripMenuItem();
            womenToolStripMenuItem = new ToolStripMenuItem();
            childrenToolStripMenuItem = new ToolStripMenuItem();
            basketToolStripMenuItem = new ToolStripMenuItem();
            editInformationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 201);
            label1.Name = "label1";
            label1.Size = new Size(955, 97);
            label1.TabIndex = 0;
            label1.Text = "Welcome to FAshion Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 289);
            label2.Name = "label2";
            label2.Size = new Size(1106, 97);
            label2.TabIndex = 1;
            label2.Text = "The best place to buy your outfit";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menToolStripMenuItem, womenToolStripMenuItem, childrenToolStripMenuItem, basketToolStripMenuItem, editInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1357, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menToolStripMenuItem
            // 
            menToolStripMenuItem.Name = "menToolStripMenuItem";
            menToolStripMenuItem.Size = new Size(63, 29);
            menToolStripMenuItem.Text = "Men";
            menToolStripMenuItem.Click += miehetToolStripMenuItem_Click;
            // 
            // womenToolStripMenuItem
            // 
            womenToolStripMenuItem.Name = "womenToolStripMenuItem";
            womenToolStripMenuItem.Size = new Size(90, 29);
            womenToolStripMenuItem.Text = "Women";
            // 
            // childrenToolStripMenuItem
            // 
            childrenToolStripMenuItem.Name = "childrenToolStripMenuItem";
            childrenToolStripMenuItem.Size = new Size(93, 29);
            childrenToolStripMenuItem.Text = "Children";
            // 
            // basketToolStripMenuItem
            // 
            basketToolStripMenuItem.Name = "basketToolStripMenuItem";
            basketToolStripMenuItem.Size = new Size(79, 29);
            basketToolStripMenuItem.Text = "Basket";
            // 
            // editInformationToolStripMenuItem
            // 
            editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
            editInformationToolStripMenuItem.Size = new Size(157, 29);
            editInformationToolStripMenuItem.Text = "Edit Information";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 763);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "MainPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menToolStripMenuItem;
        private ToolStripMenuItem womenToolStripMenuItem;
        private ToolStripMenuItem childrenToolStripMenuItem;
        private ToolStripMenuItem basketToolStripMenuItem;
        private ToolStripMenuItem editInformationToolStripMenuItem;
    }
}