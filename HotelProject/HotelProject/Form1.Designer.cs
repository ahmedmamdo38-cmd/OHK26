namespace HotelProject
{
    partial class LogInFM
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
            VirheViesti2LB = new Label();
            VirheViestiLB = new Label();
            KirjauduSisaanBT = new Button();
            PasswordTB = new TextBox();
            label3 = new Label();
            UserNameTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // VirheViesti2LB
            // 
            VirheViesti2LB.AutoSize = true;
            VirheViesti2LB.ForeColor = Color.Red;
            VirheViesti2LB.Location = new Point(24, 375);
            VirheViesti2LB.Name = "VirheViesti2LB";
            VirheViesti2LB.Size = new Size(281, 25);
            VirheViesti2LB.TabIndex = 16;
            VirheViesti2LB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViesti2LB.Visible = false;
            // 
            // VirheViestiLB
            // 
            VirheViestiLB.AutoSize = true;
            VirheViestiLB.ForeColor = Color.Red;
            VirheViestiLB.Location = new Point(24, 240);
            VirheViestiLB.Name = "VirheViestiLB";
            VirheViestiLB.Size = new Size(281, 25);
            VirheViestiLB.TabIndex = 15;
            VirheViestiLB.Text = "Jokin meni pieleen, yritä uudelleen";
            VirheViestiLB.Visible = false;
            // 
            // KirjauduSisaanBT
            // 
            KirjauduSisaanBT.BackColor = Color.SteelBlue;
            KirjauduSisaanBT.FlatStyle = FlatStyle.Popup;
            KirjauduSisaanBT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KirjauduSisaanBT.ForeColor = Color.Snow;
            KirjauduSisaanBT.Location = new Point(24, 438);
            KirjauduSisaanBT.Name = "KirjauduSisaanBT";
            KirjauduSisaanBT.Size = new Size(202, 66);
            KirjauduSisaanBT.TabIndex = 14;
            KirjauduSisaanBT.Text = "Kirjaudu sisään";
            KirjauduSisaanBT.UseVisualStyleBackColor = false;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(24, 336);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(353, 36);
            PasswordTB.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 299);
            label3.Name = "label3";
            label3.Size = new Size(132, 34);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // UserNameTB
            // 
            UserNameTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTB.Location = new Point(24, 201);
            UserNameTB.Name = "UserNameTB";
            UserNameTB.Size = new Size(353, 36);
            UserNameTB.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 148);
            label2.Name = "label2";
            label2.Size = new Size(150, 34);
            label2.TabIndex = 10;
            label2.Text = "User name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(195, 63);
            label1.TabIndex = 9;
            label1.Text = "Log In";
            // 
            // LogInFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 539);
            Controls.Add(VirheViesti2LB);
            Controls.Add(VirheViestiLB);
            Controls.Add(KirjauduSisaanBT);
            Controls.Add(PasswordTB);
            Controls.Add(label3);
            Controls.Add(UserNameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInFM";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VirheViesti2LB;
        private Label VirheViestiLB;
        private Button KirjauduSisaanBT;
        private TextBox PasswordTB;
        private Label label3;
        private TextBox UserNameTB;
        private Label label2;
        private Label label1;
    }
}
