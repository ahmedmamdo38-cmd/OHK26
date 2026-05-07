namespace ShopProject
{
    partial class LoginFM
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
            ErrorMessage1LB = new Label();
            ErrorMessage0LB = new Label();
            LogInBT = new Button();
            PasswordTB = new TextBox();
            label3 = new Label();
            UserNameTB = new TextBox();
            label2 = new Label();
            LogInLB = new Label();
            SuspendLayout();
            // 
            // ErrorMessage1LB
            // 
            ErrorMessage1LB.AutoSize = true;
            ErrorMessage1LB.ForeColor = Color.Red;
            ErrorMessage1LB.Location = new Point(24, 357);
            ErrorMessage1LB.Name = "ErrorMessage1LB";
            ErrorMessage1LB.Size = new Size(281, 25);
            ErrorMessage1LB.TabIndex = 32;
            ErrorMessage1LB.Text = " Something went wrong, try again";
            ErrorMessage1LB.Visible = false;
            // 
            // ErrorMessage0LB
            // 
            ErrorMessage0LB.AutoSize = true;
            ErrorMessage0LB.ForeColor = Color.Red;
            ErrorMessage0LB.Location = new Point(24, 222);
            ErrorMessage0LB.Name = "ErrorMessage0LB";
            ErrorMessage0LB.Size = new Size(276, 25);
            ErrorMessage0LB.TabIndex = 31;
            ErrorMessage0LB.Text = "Something went wrong, try again";
            ErrorMessage0LB.Visible = false;
            // 
            // LogInBT
            // 
            LogInBT.BackColor = Color.SteelBlue;
            LogInBT.FlatStyle = FlatStyle.Popup;
            LogInBT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInBT.ForeColor = Color.Snow;
            LogInBT.Location = new Point(24, 420);
            LogInBT.Name = "LogInBT";
            LogInBT.Size = new Size(202, 66);
            LogInBT.TabIndex = 30;
            LogInBT.Text = "Log In";
            LogInBT.UseVisualStyleBackColor = false;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(24, 318);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(353, 36);
            PasswordTB.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 281);
            label3.Name = "label3";
            label3.Size = new Size(132, 34);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // UserNameTB
            // 
            UserNameTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTB.Location = new Point(24, 183);
            UserNameTB.Name = "UserNameTB";
            UserNameTB.Size = new Size(353, 36);
            UserNameTB.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 130);
            label2.Name = "label2";
            label2.Size = new Size(141, 34);
            label2.TabIndex = 26;
            label2.Text = "Username";
            // 
            // LogInLB
            // 
            LogInLB.AutoSize = true;
            LogInLB.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            LogInLB.ForeColor = Color.Black;
            LogInLB.Location = new Point(12, 26);
            LogInLB.Name = "LogInLB";
            LogInLB.Size = new Size(195, 63);
            LogInLB.TabIndex = 25;
            LogInLB.Text = "Log In";
            // 
            // LoginFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 555);
            Controls.Add(ErrorMessage1LB);
            Controls.Add(ErrorMessage0LB);
            Controls.Add(LogInBT);
            Controls.Add(PasswordTB);
            Controls.Add(label3);
            Controls.Add(UserNameTB);
            Controls.Add(label2);
            Controls.Add(LogInLB);
            Name = "LoginFM";
            Text = "Login page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorMessage1LB;
        private Label ErrorMessage0LB;
        private Button LogInBT;
        private TextBox PasswordTB;
        private Label label3;
        private TextBox UserNameTB;
        private Label label2;
        private Label LogInLB;
    }
}
