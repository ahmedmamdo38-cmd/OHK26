namespace Task15
{
    partial class SekkariFM
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
            components = new System.ComponentModel.Container();
            ajastimTM = new System.Windows.Forms.Timer(components);
            AikaLB = new Label();
            StartBT = new Button();
            StopBT = new Button();
            ResetBT = new Button();
            SuspendLayout();
            // 
            // ajastimTM
            // 
            ajastimTM.Enabled = true;
            ajastimTM.Tick += ajastimTM_Tick;
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Papyrus", 55F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AikaLB.Location = new Point(72, 32);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(721, 173);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            StartBT.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBT.Location = new Point(24, 254);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(259, 71);
            StartBT.TabIndex = 1;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBT.Location = new Point(306, 254);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(284, 71);
            StopBT.TabIndex = 2;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Font = new Font("Papyrus", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBT.Location = new Point(613, 254);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(259, 71);
            ResetBT.TabIndex = 3;
            ResetBT.Text = " Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // SekkariFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 359);
            Controls.Add(ResetBT);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(AikaLB);
            Name = "SekkariFM";
            Text = "Sekuntikello ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer ajastimTM;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
    }
}
