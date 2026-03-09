namespace HotelliProjekti
{
    partial class Testi
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
            VirheViesti1LB = new Label();
            VirheViesti0LB = new Label();
            KirjauduSisään1BT = new Button();
            Salasana1TB = new TextBox();
            label3 = new Label();
            Kaytaja1NTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // VirheViesti1LB
            // 
            VirheViesti1LB.AutoSize = true;
            VirheViesti1LB.ForeColor = Color.Red;
            VirheViesti1LB.Location = new Point(22, 391);
            VirheViesti1LB.Name = "VirheViesti1LB";
            VirheViesti1LB.Size = new Size(281, 25);
            VirheViesti1LB.TabIndex = 16;
            VirheViesti1LB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViesti1LB.Visible = false;
            // 
            // VirheViesti0LB
            // 
            VirheViesti0LB.AutoSize = true;
            VirheViesti0LB.ForeColor = Color.Red;
            VirheViesti0LB.Location = new Point(22, 257);
            VirheViesti0LB.Name = "VirheViesti0LB";
            VirheViesti0LB.Size = new Size(281, 25);
            VirheViesti0LB.TabIndex = 15;
            VirheViesti0LB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViesti0LB.Visible = false;
            // 
            // KirjauduSisään1BT
            // 
            KirjauduSisään1BT.BackColor = Color.SteelBlue;
            KirjauduSisään1BT.FlatStyle = FlatStyle.Popup;
            KirjauduSisään1BT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KirjauduSisään1BT.ForeColor = Color.Snow;
            KirjauduSisään1BT.Location = new Point(22, 446);
            KirjauduSisään1BT.Name = "KirjauduSisään1BT";
            KirjauduSisään1BT.Size = new Size(202, 66);
            KirjauduSisään1BT.TabIndex = 14;
            KirjauduSisään1BT.Text = "Kirjaudu sisään";
            KirjauduSisään1BT.UseVisualStyleBackColor = false;
            KirjauduSisään1BT.Click += KirjauduSisään1BT_Click;
            // 
            // Salasana1TB
            // 
            Salasana1TB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salasana1TB.Location = new Point(22, 352);
            Salasana1TB.Name = "Salasana1TB";
            Salasana1TB.Size = new Size(353, 36);
            Salasana1TB.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 304);
            label3.Name = "label3";
            label3.Size = new Size(126, 34);
            label3.TabIndex = 12;
            label3.Text = "Salasana";
            // 
            // Kaytaja1NTB
            // 
            Kaytaja1NTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kaytaja1NTB.Location = new Point(22, 218);
            Kaytaja1NTB.Name = "Kaytaja1NTB";
            Kaytaja1NTB.Size = new Size(353, 36);
            Kaytaja1NTB.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 175);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 10;
            label2.Text = "Käyttäjän nimi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(437, 63);
            label1.TabIndex = 9;
            label1.Text = "Kirjaudu Sisään";
            // 
            // Testi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 587);
            Controls.Add(VirheViesti1LB);
            Controls.Add(VirheViesti0LB);
            Controls.Add(KirjauduSisään1BT);
            Controls.Add(Salasana1TB);
            Controls.Add(label3);
            Controls.Add(Kaytaja1NTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Testi";
            Text = "Testi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VirheViesti1LB;
        private Label VirheViesti0LB;
        private Button KirjauduSisään1BT;
        private TextBox Salasana1TB;
        private Label label3;
        private TextBox Kaytaja1NTB;
        private Label label2;
        private Label label1;
    }
}