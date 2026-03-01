namespace Task4
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
            BirthDateDT = new DateTimePicker();
            LaskeBT = new Button();
            YearLB = new Label();
            MonthLB = new Label();
            DayLB = new Label();
            HourLB = new Label();
            MinuteLB = new Label();
            SecondLB = new Label();
            SuspendLayout();
            // 
            // BirthDateDT
            // 
            BirthDateDT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthDateDT.Location = new Point(25, 37);
            BirthDateDT.Name = "BirthDateDT";
            BirthDateDT.Size = new Size(559, 50);
            BirthDateDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.BackColor = Color.DarkTurquoise;
            LaskeBT.Location = new Point(631, 37);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(158, 50);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = false;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // YearLB
            // 
            YearLB.AutoSize = true;
            YearLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YearLB.Location = new Point(25, 119);
            YearLB.Name = "YearLB";
            YearLB.Size = new Size(142, 45);
            YearLB.TabIndex = 2;
            YearLB.Text = "Vuosissa";
            YearLB.Visible = false;
            // 
            // MonthLB
            // 
            MonthLB.AutoSize = true;
            MonthLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonthLB.Location = new Point(25, 188);
            MonthLB.Name = "MonthLB";
            MonthLB.Size = new Size(191, 45);
            MonthLB.TabIndex = 3;
            MonthLB.Text = "Kuukausissa";
            MonthLB.Visible = false;
            // 
            // DayLB
            // 
            DayLB.AutoSize = true;
            DayLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayLB.Location = new Point(25, 254);
            DayLB.Name = "DayLB";
            DayLB.Size = new Size(128, 45);
            DayLB.TabIndex = 4;
            DayLB.Text = "Päivissä";
            DayLB.Visible = false;
            // 
            // HourLB
            // 
            HourLB.AutoSize = true;
            HourLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HourLB.Location = new Point(393, 109);
            HourLB.Name = "HourLB";
            HourLB.Size = new Size(160, 45);
            HourLB.TabIndex = 5;
            HourLB.Text = "Tunneissa";
            HourLB.Visible = false;
            // 
            // MinuteLB
            // 
            MinuteLB.AutoSize = true;
            MinuteLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinuteLB.Location = new Point(393, 188);
            MinuteLB.Name = "MinuteLB";
            MinuteLB.Size = new Size(191, 45);
            MinuteLB.TabIndex = 6;
            MinuteLB.Text = "Minuuteissa";
            MinuteLB.Visible = false;
            // 
            // SecondLB
            // 
            SecondLB.AutoSize = true;
            SecondLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondLB.Location = new Point(393, 254);
            SecondLB.Name = "SecondLB";
            SecondLB.Size = new Size(193, 45);
            SecondLB.TabIndex = 7;
            SecondLB.Text = "Sekunneissa";
            SecondLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 323);
            Controls.Add(SecondLB);
            Controls.Add(MinuteLB);
            Controls.Add(HourLB);
            Controls.Add(DayLB);
            Controls.Add(MonthLB);
            Controls.Add(YearLB);
            Controls.Add(LaskeBT);
            Controls.Add(BirthDateDT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker BirthDateDT;
        private Button LaskeBT;
        private Label YearLB;
        private Label MonthLB;
        private Label DayLB;
        private Label HourLB;
        private Label MinuteLB;
        private Label SecondLB;
    }
}
