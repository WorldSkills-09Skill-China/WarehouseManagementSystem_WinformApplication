namespace WarehouseManagementSystem
{
    partial class FrmWarehouseRecords
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbmItemType = new WarehouseManagementSystem.Cbm();
            this.cbmItem = new WarehouseManagementSystem.Cbm();
            this.tbSearch = new WarehouseManagementSystem.Tb();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRecordsData = new WarehouseManagementSystem.Dgv();
            this.cbOnlyLoadUnfinishedTask = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFirstTime = new System.Windows.Forms.DateTimePicker();
            this.dtpLastTime = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库记录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "物品类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "物品：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "查询：";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(548, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 21);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbmItemType
            // 
            this.cbmItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmItemType.FormattingEnabled = true;
            this.cbmItemType.Location = new System.Drawing.Point(86, 13);
            this.cbmItemType.Name = "cbmItemType";
            this.cbmItemType.Size = new System.Drawing.Size(88, 21);
            this.cbmItemType.TabIndex = 8;
            this.cbmItemType.SelectedIndexChanged += new System.EventHandler(this.cbmItemType_SelectedIndexChanged);
            // 
            // cbmItem
            // 
            this.cbmItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmItem.FormattingEnabled = true;
            this.cbmItem.Location = new System.Drawing.Point(235, 14);
            this.cbmItem.Name = "cbmItem";
            this.cbmItem.Size = new System.Drawing.Size(92, 21);
            this.cbmItem.TabIndex = 9;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(437, 12);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 21);
            this.tbSearch.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.cbmItem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbmItemType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(19, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 46);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvRecordsData);
            this.panel2.Controls.Add(this.cbOnlyLoadUnfinishedTask);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFirstTime);
            this.panel2.Controls.Add(this.dtpLastTime);
            this.panel2.Location = new System.Drawing.Point(19, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 308);
            this.panel2.TabIndex = 20;
            // 
            // dgvRecordsData
            // 
            this.dgvRecordsData.AllowUserToAddRows = false;
            this.dgvRecordsData.AllowUserToDeleteRows = false;
            this.dgvRecordsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecordsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordsData.Location = new System.Drawing.Point(4, 38);
            this.dgvRecordsData.Name = "dgvRecordsData";
            this.dgvRecordsData.RowHeadersVisible = false;
            this.dgvRecordsData.RowTemplate.Height = 25;
            this.dgvRecordsData.Size = new System.Drawing.Size(618, 267);
            this.dgvRecordsData.TabIndex = 22;
            this.dgvRecordsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordsData_CellClick_1);
            // 
            // cbOnlyLoadUnfinishedTask
            // 
            this.cbOnlyLoadUnfinishedTask.AutoSize = true;
            this.cbOnlyLoadUnfinishedTask.Location = new System.Drawing.Point(7, 14);
            this.cbOnlyLoadUnfinishedTask.Name = "cbOnlyLoadUnfinishedTask";
            this.cbOnlyLoadUnfinishedTask.Size = new System.Drawing.Size(110, 17);
            this.cbOnlyLoadUnfinishedTask.TabIndex = 21;
            this.cbOnlyLoadUnfinishedTask.Text = "只看未完成任务";
            this.cbOnlyLoadUnfinishedTask.UseVisualStyleBackColor = true;
            this.cbOnlyLoadUnfinishedTask.CheckedChanged += new System.EventHandler(this.cbOnlyLoadUnfinishedTask_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "----->";
            // 
            // dtpFirstTime
            // 
            this.dtpFirstTime.CustomFormat = "yyyy/MM/dd";
            this.dtpFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFirstTime.Location = new System.Drawing.Point(381, 12);
            this.dtpFirstTime.Name = "dtpFirstTime";
            this.dtpFirstTime.Size = new System.Drawing.Size(100, 20);
            this.dtpFirstTime.TabIndex = 19;
            this.dtpFirstTime.Value = new System.DateTime(1920, 1, 9, 15, 53, 0, 0);
            this.dtpFirstTime.ValueChanged += new System.EventHandler(this.dtpFirstTime_ValueChanged);
            // 
            // dtpLastTime
            // 
            this.dtpLastTime.CustomFormat = "yyyy/MM/dd";
            this.dtpLastTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastTime.Location = new System.Drawing.Point(522, 12);
            this.dtpLastTime.Name = "dtpLastTime";
            this.dtpLastTime.Size = new System.Drawing.Size(100, 20);
            this.dtpLastTime.TabIndex = 18;
            this.dtpLastTime.ValueChanged += new System.EventHandler(this.dtpLastTime_ValueChanged);
            // 
            // FrmWarehouseRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWarehouseRecords";
            this.Text = "FrmWarehouseRecords";
            this.Load += new System.EventHandler(this.FrmWarehouseRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private Cbm cbmItemType;
        private Cbm cbmItem;
        private Tb tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFirstTime;
        private System.Windows.Forms.DateTimePicker dtpLastTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbOnlyLoadUnfinishedTask;
        private Dgv dgvRecordsData;
    }
}