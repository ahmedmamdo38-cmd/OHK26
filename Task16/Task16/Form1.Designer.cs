namespace Task16
{
    partial class LaskuriFM
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
            label1 = new Label();
            label2 = new Label();
            AikaLB = new Label();
            MinuuttiCB = new ComboBox();
            SekunniCB = new ComboBox();
            StartBT = new Button();
            StopBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(159, 51);
            label1.TabIndex = 0;
            label1.Text = "Minuutit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 36);
            label2.Name = "label2";
            label2.Size = new Size(166, 51);
            label2.TabIndex = 1;
            label2.Text = "Sekuntit:";
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Papyrus", 58F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AikaLB.Location = new Point(23, 152);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(375, 182);
            AikaLB.TabIndex = 2;
            AikaLB.Text = "00:00";
            // 
            // MinuuttiCB
            // 
            MinuuttiCB.Font = new Font("Papyrus", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinuuttiCB.FormattingEnabled = true;
            MinuuttiCB.Location = new Point(23, 90);
            MinuuttiCB.Name = "MinuuttiCB";
            MinuuttiCB.Size = new Size(149, 59);
            MinuuttiCB.TabIndex = 3;
            // 
            // SekunniCB
            // 
            SekunniCB.Font = new Font("Papyrus", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SekunniCB.FormattingEnabled = true;
            SekunniCB.Location = new Point(228, 90);
            SekunniCB.Name = "SekunniCB";
            SekunniCB.Size = new Size(149, 59);
            SekunniCB.TabIndex = 4;
            // 
            // StartBT
            // 
            StartBT.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBT.Location = new Point(23, 316);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(149, 81);
            StartBT.TabIndex = 5;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Papyrus", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBT.Location = new Point(228, 316);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(149, 81);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // LaskuriFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 463);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(SekunniCB);
            Controls.Add(MinuuttiCB);
            Controls.Add(AikaLB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LaskuriFM";
            Text = "V";
            Load += LaskuriFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label AikaLB;
        private ComboBox MinuuttiCB;
        private ComboBox SekunniCB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
