namespace WarehouseManagementSystem
{
    partial class FrmReleaseTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudItemCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReleaseTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIsUserExistingItems = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbPlaceForStorage = new System.Windows.Forms.PictureBox();
            this.cbmBatch = new WarehouseManagementSystem.Cbm();
            this.tbNote = new WarehouseManagementSystem.Tb();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.cbmPlaceForStorage = new WarehouseManagementSystem.Cbm();
            this.cbmOperator = new WarehouseManagementSystem.Cbm();
            this.cbmItem = new WarehouseManagementSystem.Cbm();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceForStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(139, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "发布任务";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "物品：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(81, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "数量：";
            // 
            // nudItemCount
            // 
            this.nudItemCount.Location = new System.Drawing.Point(138, 86);
            this.nudItemCount.Name = "nudItemCount";
            this.nudItemCount.Size = new System.Drawing.Size(198, 20);
            this.nudItemCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "任务类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(47, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "截止时间：";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy/MM/dd  mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(138, 260);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(198, 20);
            this.dtpEndTime.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(49, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "存放位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(48, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "操作人员：";
            // 
            // btnReleaseTask
            // 
            this.btnReleaseTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(122)))));
            this.btnReleaseTask.Location = new System.Drawing.Point(152, 355);
            this.btnReleaseTask.Name = "btnReleaseTask";
            this.btnReleaseTask.Size = new System.Drawing.Size(109, 42);
            this.btnReleaseTask.TabIndex = 25;
            this.btnReleaseTask.Text = "发布";
            this.btnReleaseTask.UseVisualStyleBackColor = false;
            this.btnReleaseTask.Click += new System.EventHandler(this.btnReleaseTask_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbmBatch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbIsUserExistingItems);
            this.panel1.Controls.Add(this.tbNote);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbmType);
            this.panel1.Controls.Add(this.cbmPlaceForStorage);
            this.panel1.Controls.Add(this.cbmOperator);
            this.panel1.Controls.Add(this.cbmItem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReleaseTask);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nudItemCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpEndTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 429);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(81, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "批次：";
            // 
            // cbIsUserExistingItems
            // 
            this.cbIsUserExistingItems.AutoSize = true;
            this.cbIsUserExistingItems.Location = new System.Drawing.Point(226, 332);
            this.cbIsUserExistingItems.Name = "cbIsUserExistingItems";
            this.cbIsUserExistingItems.Size = new System.Drawing.Size(110, 17);
            this.cbIsUserExistingItems.TabIndex = 34;
            this.cbIsUserExistingItems.Text = "入库以有的物品";
            this.cbIsUserExistingItems.UseVisualStyleBackColor = true;
            this.cbIsUserExistingItems.CheckedChanged += new System.EventHandler(this.cbIsUserExistingItems_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(80, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "备注：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbItem);
            this.groupBox1.Location = new System.Drawing.Point(420, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 203);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物品";
            // 
            // pbItem
            // 
            this.pbItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbItem.Location = new System.Drawing.Point(3, 16);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(213, 184);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbPlaceForStorage);
            this.groupBox2.Location = new System.Drawing.Point(423, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 220);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存放位置";
            // 
            // pbPlaceForStorage
            // 
            this.pbPlaceForStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlaceForStorage.Location = new System.Drawing.Point(3, 16);
            this.pbPlaceForStorage.Name = "pbPlaceForStorage";
            this.pbPlaceForStorage.Size = new System.Drawing.Size(213, 201);
            this.pbPlaceForStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaceForStorage.TabIndex = 0;
            this.pbPlaceForStorage.TabStop = false;
            // 
            // cbmBatch
            // 
            this.cbmBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBatch.FormattingEnabled = true;
            this.cbmBatch.Location = new System.Drawing.Point(138, 155);
            this.cbmBatch.Name = "cbmBatch";
            this.cbmBatch.Size = new System.Drawing.Size(198, 21);
            this.cbmBatch.TabIndex = 36;
            this.cbmBatch.SelectedIndexChanged += new System.EventHandler(this.cbmBatch_SelectedIndexChanged);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(138, 294);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(198, 20);
            this.tbNote.TabIndex = 33;
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(138, 225);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(198, 21);
            this.cbmType.TabIndex = 30;
            this.cbmType.SelectedIndexChanged += new System.EventHandler(this.cbmType_SelectedIndexChanged);
            // 
            // cbmPlaceForStorage
            // 
            this.cbmPlaceForStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPlaceForStorage.FormattingEnabled = true;
            this.cbmPlaceForStorage.Location = new System.Drawing.Point(138, 190);
            this.cbmPlaceForStorage.Name = "cbmPlaceForStorage";
            this.cbmPlaceForStorage.Size = new System.Drawing.Size(198, 21);
            this.cbmPlaceForStorage.TabIndex = 29;
            this.cbmPlaceForStorage.SelectedIndexChanged += new System.EventHandler(this.cbmPlaceForStorage_SelectedIndexChanged);
            // 
            // cbmOperator
            // 
            this.cbmOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmOperator.FormattingEnabled = true;
            this.cbmOperator.Location = new System.Drawing.Point(138, 120);
            this.cbmOperator.Name = "cbmOperator";
            this.cbmOperator.Size = new System.Drawing.Size(198, 21);
            this.cbmOperator.TabIndex = 28;
            // 
            // cbmItem
            // 
            this.cbmItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmItem.FormattingEnabled = true;
            this.cbmItem.Location = new System.Drawing.Point(138, 51);
            this.cbmItem.Name = "cbmItem";
            this.cbmItem.Size = new System.Drawing.Size(198, 21);
            this.cbmItem.TabIndex = 27;
            this.cbmItem.SelectedIndexChanged += new System.EventHandler(this.cbmItem_SelectedIndexChanged);
            // 
            // FrmReleaseTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReleaseTask";
            this.Text = "FrmReleaseTask";
            this.Load += new System.EventHandler(this.FrmReleaseTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceForStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudItemCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReleaseTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.PictureBox pbPlaceForStorage;
        private Cbm cbmItem;
        private Cbm cbmType;
        private Cbm cbmPlaceForStorage;
        private Cbm cbmOperator;
        private Tb tbNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbIsUserExistingItems;
        private Cbm cbmBatch;
        private System.Windows.Forms.Label label8;
    }
}