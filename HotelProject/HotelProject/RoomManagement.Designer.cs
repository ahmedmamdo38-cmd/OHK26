namespace HotelProject
{
    partial class RoomManagement
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
            AlaPanel = new Panel();
            groupBox1 = new GroupBox();
            VariantsNoRB = new RadioButton();
            VariantsYesRB = new RadioButton();
            PhoneNumberTB = new TextBox();
            RoomTypeCB = new ComboBox();
            RoomClearFieldsBT = new Button();
            RoomRemoveBT = new Button();
            RoomEditBT = new Button();
            RoomAddBT = new Button();
            RoomFreeLb = new Label();
            PhoneNumberLB = new Label();
            RoomTypeLB = new Label();
            RoomNumberTB = new TextBox();
            RoomManagementDG = new DataGridView();
            RoomNumberLB = new Label();
            YlaPanel = new Panel();
            RoomManagementLB = new Label();
            AlaPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomManagementDG).BeginInit();
            YlaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AlaPanel
            // 
            AlaPanel.BackColor = Color.White;
            AlaPanel.Controls.Add(groupBox1);
            AlaPanel.Controls.Add(PhoneNumberTB);
            AlaPanel.Controls.Add(RoomTypeCB);
            AlaPanel.Controls.Add(RoomClearFieldsBT);
            AlaPanel.Controls.Add(RoomRemoveBT);
            AlaPanel.Controls.Add(RoomEditBT);
            AlaPanel.Controls.Add(RoomAddBT);
            AlaPanel.Controls.Add(RoomFreeLb);
            AlaPanel.Controls.Add(PhoneNumberLB);
            AlaPanel.Controls.Add(RoomTypeLB);
            AlaPanel.Controls.Add(RoomNumberTB);
            AlaPanel.Controls.Add(RoomManagementDG);
            AlaPanel.Controls.Add(RoomNumberLB);
            AlaPanel.Dock = DockStyle.Fill;
            AlaPanel.Location = new Point(0, 98);
            AlaPanel.Name = "AlaPanel";
            AlaPanel.Size = new Size(1393, 462);
            AlaPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(VariantsNoRB);
            groupBox1.Controls.Add(VariantsYesRB);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(231, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 96);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Variants";
            // 
            // VariantsNoRB
            // 
            VariantsNoRB.AutoSize = true;
            VariantsNoRB.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VariantsNoRB.ForeColor = Color.Red;
            VariantsNoRB.Location = new Point(183, 30);
            VariantsNoRB.Name = "VariantsNoRB";
            VariantsNoRB.Size = new Size(75, 33);
            VariantsNoRB.TabIndex = 1;
            VariantsNoRB.TabStop = true;
            VariantsNoRB.Text = "NO";
            VariantsNoRB.UseVisualStyleBackColor = true;
            // 
            // VariantsYesRB
            // 
            VariantsYesRB.AutoSize = true;
            VariantsYesRB.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VariantsYesRB.ForeColor = Color.Green;
            VariantsYesRB.Location = new Point(17, 30);
            VariantsYesRB.Name = "VariantsYesRB";
            VariantsYesRB.Size = new Size(84, 33);
            VariantsYesRB.TabIndex = 0;
            VariantsYesRB.TabStop = true;
            VariantsYesRB.Text = "YES";
            VariantsYesRB.UseVisualStyleBackColor = true;
            // 
            // PhoneNumberTB
            // 
            PhoneNumberTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberTB.Location = new Point(231, 99);
            PhoneNumberTB.Name = "PhoneNumberTB";
            PhoneNumberTB.Size = new Size(318, 36);
            PhoneNumberTB.TabIndex = 22;
            // 
            // RoomTypeCB
            // 
            RoomTypeCB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoomTypeCB.FormattingEnabled = true;
            RoomTypeCB.Items.AddRange(new object[] { "Yhden hengen", "Kahden hengen", "Perhe ", "Sviitti" });
            RoomTypeCB.Location = new Point(231, 56);
            RoomTypeCB.Name = "RoomTypeCB";
            RoomTypeCB.Size = new Size(318, 37);
            RoomTypeCB.TabIndex = 19;
            // 
            // RoomClearFieldsBT
            // 
            RoomClearFieldsBT.BackColor = Color.SkyBlue;
            RoomClearFieldsBT.FlatStyle = FlatStyle.Popup;
            RoomClearFieldsBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomClearFieldsBT.ForeColor = Color.White;
            RoomClearFieldsBT.Location = new Point(157, 322);
            RoomClearFieldsBT.Name = "RoomClearFieldsBT";
            RoomClearFieldsBT.Size = new Size(222, 42);
            RoomClearFieldsBT.TabIndex = 18;
            RoomClearFieldsBT.Text = "Clear Fields\r\n";
            RoomClearFieldsBT.UseVisualStyleBackColor = false;
            RoomClearFieldsBT.Click += RoomClearFieldsBT_Click;
            // 
            // RoomRemoveBT
            // 
            RoomRemoveBT.BackColor = Color.SkyBlue;
            RoomRemoveBT.FlatStyle = FlatStyle.Popup;
            RoomRemoveBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomRemoveBT.ForeColor = Color.White;
            RoomRemoveBT.Location = new Point(12, 322);
            RoomRemoveBT.Name = "RoomRemoveBT";
            RoomRemoveBT.Size = new Size(139, 42);
            RoomRemoveBT.TabIndex = 17;
            RoomRemoveBT.Text = "Remove";
            RoomRemoveBT.UseVisualStyleBackColor = false;
            RoomRemoveBT.Click += RoomRemoveBT_Click;
            // 
            // RoomEditBT
            // 
            RoomEditBT.BackColor = Color.SkyBlue;
            RoomEditBT.FlatStyle = FlatStyle.Popup;
            RoomEditBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomEditBT.ForeColor = Color.White;
            RoomEditBT.Location = new Point(269, 265);
            RoomEditBT.Name = "RoomEditBT";
            RoomEditBT.Size = new Size(222, 42);
            RoomEditBT.TabIndex = 16;
            RoomEditBT.Text = "Edit";
            RoomEditBT.UseVisualStyleBackColor = false;
            RoomEditBT.Click += RoomEditBT_Click;
            // 
            // RoomAddBT
            // 
            RoomAddBT.BackColor = Color.SkyBlue;
            RoomAddBT.FlatStyle = FlatStyle.Popup;
            RoomAddBT.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomAddBT.ForeColor = Color.Snow;
            RoomAddBT.Location = new Point(12, 265);
            RoomAddBT.Name = "RoomAddBT";
            RoomAddBT.Size = new Size(251, 42);
            RoomAddBT.TabIndex = 15;
            RoomAddBT.Text = "Add new room";
            RoomAddBT.UseVisualStyleBackColor = false;
            RoomAddBT.Click += RoomAddBT_Click;
            // 
            // RoomFreeLb
            // 
            RoomFreeLb.AutoSize = true;
            RoomFreeLb.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoomFreeLb.Location = new Point(12, 150);
            RoomFreeLb.Name = "RoomFreeLb";
            RoomFreeLb.Size = new Size(69, 29);
            RoomFreeLb.TabIndex = 5;
            RoomFreeLb.Text = "Free:";
            // 
            // PhoneNumberLB
            // 
            PhoneNumberLB.AutoSize = true;
            PhoneNumberLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLB.Location = new Point(12, 108);
            PhoneNumberLB.Name = "PhoneNumberLB";
            PhoneNumberLB.Size = new Size(178, 29);
            PhoneNumberLB.TabIndex = 4;
            PhoneNumberLB.Text = "Phone Number:";
            // 
            // RoomTypeLB
            // 
            RoomTypeLB.AutoSize = true;
            RoomTypeLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoomTypeLB.Location = new Point(12, 66);
            RoomTypeLB.Name = "RoomTypeLB";
            RoomTypeLB.Size = new Size(153, 29);
            RoomTypeLB.TabIndex = 3;
            RoomTypeLB.Text = "Rooms Type:";
            // 
            // RoomNumberTB
            // 
            RoomNumberTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoomNumberTB.Location = new Point(231, 14);
            RoomNumberTB.Name = "RoomNumberTB";
            RoomNumberTB.Size = new Size(318, 36);
            RoomNumberTB.TabIndex = 2;
            // 
            // RoomManagementDG
            // 
            RoomManagementDG.BackgroundColor = Color.WhiteSmoke;
            RoomManagementDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomManagementDG.Dock = DockStyle.Right;
            RoomManagementDG.Location = new Point(742, 0);
            RoomManagementDG.Name = "RoomManagementDG";
            RoomManagementDG.RowHeadersWidth = 62;
            RoomManagementDG.Size = new Size(651, 462);
            RoomManagementDG.TabIndex = 1;
            RoomManagementDG.CellContentClick += RoomManagementDG_CellContentClick;
            // 
            // RoomNumberLB
            // 
            RoomNumberLB.AutoSize = true;
            RoomNumberLB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoomNumberLB.Location = new Point(12, 21);
            RoomNumberLB.Name = "RoomNumberLB";
            RoomNumberLB.Size = new Size(190, 29);
            RoomNumberLB.TabIndex = 0;
            RoomNumberLB.Text = "Room's Number:";
            // 
            // YlaPanel
            // 
            YlaPanel.BackColor = Color.SkyBlue;
            YlaPanel.Controls.Add(RoomManagementLB);
            YlaPanel.Dock = DockStyle.Top;
            YlaPanel.Location = new Point(0, 0);
            YlaPanel.Name = "YlaPanel";
            YlaPanel.Size = new Size(1393, 98);
            YlaPanel.TabIndex = 6;
            // 
            // RoomManagementLB
            // 
            RoomManagementLB.AutoSize = true;
            RoomManagementLB.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            RoomManagementLB.ForeColor = Color.White;
            RoomManagementLB.Location = new Point(414, 9);
            RoomManagementLB.Name = "RoomManagementLB";
            RoomManagementLB.Size = new Size(562, 63);
            RoomManagementLB.TabIndex = 0;
            RoomManagementLB.Text = "Rooms Management";
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 560);
            Controls.Add(AlaPanel);
            Controls.Add(YlaPanel);
            Name = "RoomManagement";
            Text = "RoomManagement";
            Load += RoomManagement_Load;
            AlaPanel.ResumeLayout(false);
            AlaPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomManagementDG).EndInit();
            YlaPanel.ResumeLayout(false);
            YlaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AlaPanel;
        private GroupBox groupBox1;
        private RadioButton VariantsNoRB;
        private RadioButton VariantsYesRB;
        private TextBox PhoneNumberTB;
        private ComboBox RoomTypeCB;
        private Button RoomClearFieldsBT;
        private Button RoomRemoveBT;
        private Button RoomEditBT;
        private Button RoomAddBT;
        private Label RoomFreeLb;
        private Label PhoneNumberLB;
        private Label RoomTypeLB;
        private TextBox RoomNumberTB;
        private DataGridView RoomManagementDG;
        private Label RoomNumberLB;
        private Panel YlaPanel;
        private Label RoomManagementLB;
    }
}