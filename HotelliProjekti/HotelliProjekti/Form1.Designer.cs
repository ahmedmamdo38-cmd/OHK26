namespace HotelliProjekti
{
    partial class KirjautumisikkunaFM
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
            label2 = new Label();
            KäyttäjänNTB = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            KirjauduSisäänBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(437, 63);
            label1.TabIndex = 0;
            label1.Text = "Kirjaudu Sisään";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 1;
            label2.Text = "Käyttäjän nimi";
            // 
            // KäyttäjänNTB
            // 
            KäyttäjänNTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KäyttäjänNTB.Location = new Point(12, 179);
            KäyttäjänNTB.Name = "KäyttäjänNTB";
            KäyttäjänNTB.Size = new Size(353, 36);
            KäyttäjänNTB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(126, 34);
            label3.TabIndex = 3;
            label3.Text = "Salasana";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 36);
            textBox1.TabIndex = 4;
            // 
            // KirjauduSisäänBT
            // 
            KirjauduSisäänBT.BackColor = Color.SteelBlue;
            KirjauduSisäänBT.FlatStyle = FlatStyle.Popup;
            KirjauduSisäänBT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KirjauduSisäänBT.ForeColor = Color.Snow;
            KirjauduSisäänBT.Location = new Point(12, 372);
            KirjauduSisäänBT.Name = "KirjauduSisäänBT";
            KirjauduSisäänBT.Size = new Size(202, 66);
            KirjauduSisäänBT.TabIndex = 5;
            KirjauduSisäänBT.Text = "Kirjaudu sisään";
            KirjauduSisäänBT.UseVisualStyleBackColor = false;
            // 
            // KirjautumisikkunaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(460, 480);
            Controls.Add(KirjauduSisäänBT);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(KäyttäjänNTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "KirjautumisikkunaFM";
            Text = "Kirjautumisikkuna";
            Load += KirjautumisikkunaFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox KäyttäjänNTB;
        private Label label3;
        private TextBox textBox1;
        private Button KirjauduSisäänBT;
    }
}
