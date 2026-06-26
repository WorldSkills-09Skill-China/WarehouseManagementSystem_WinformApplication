namespace WarehouseManagementSystem
{
    partial class FrmFixedAssetDetail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFirstTime = new System.Windows.Forms.DateTimePicker();
            this.dtpLastTime = new System.Windows.Forms.DateTimePicker();
            this.dgvFixedAssetHistoryList = new WarehouseManagementSystem.Dgv();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixedAssetHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(280, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 47);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "物品历史记录";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "----->";
            // 
            // dtpFirstTime
            // 
            this.dtpFirstTime.CustomFormat = "yyyy/MM/dd";
            this.dtpFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFirstTime.Location = new System.Drawing.Point(493, 84);
            this.dtpFirstTime.Name = "dtpFirstTime";
            this.dtpFirstTime.Size = new System.Drawing.Size(100, 20);
            this.dtpFirstTime.TabIndex = 27;
            this.dtpFirstTime.Value = new System.DateTime(1920, 1, 9, 15, 53, 0, 0);
            this.dtpFirstTime.ValueChanged += new System.EventHandler(this.dtpFirstTime_ValueChanged);
            // 
            // dtpLastTime
            // 
            this.dtpLastTime.CustomFormat = "yyyy/MM/dd";
            this.dtpLastTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastTime.Location = new System.Drawing.Point(634, 84);
            this.dtpLastTime.Name = "dtpLastTime";
            this.dtpLastTime.Size = new System.Drawing.Size(100, 20);
            this.dtpLastTime.TabIndex = 26;
            this.dtpLastTime.ValueChanged += new System.EventHandler(this.dtpLastTime_ValueChanged);
            // 
            // dgvFixedAssetHistoryList
            // 
            this.dgvFixedAssetHistoryList.AllowUserToAddRows = false;
            this.dgvFixedAssetHistoryList.AllowUserToDeleteRows = false;
            this.dgvFixedAssetHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFixedAssetHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFixedAssetHistoryList.Location = new System.Drawing.Point(61, 110);
            this.dgvFixedAssetHistoryList.Name = "dgvFixedAssetHistoryList";
            this.dgvFixedAssetHistoryList.RowHeadersVisible = false;
            this.dgvFixedAssetHistoryList.RowTemplate.Height = 25;
            this.dgvFixedAssetHistoryList.Size = new System.Drawing.Size(673, 298);
            this.dgvFixedAssetHistoryList.TabIndex = 29;
            // 
            // FrmFixedAssetDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFixedAssetHistoryList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFirstTime);
            this.Controls.Add(this.dtpLastTime);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmFixedAssetDetail";
            this.Text = "FrmFixedAssetDetail";
            this.Load += new System.EventHandler(this.FrmFixedAssetDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixedAssetHistoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFirstTime;
        private System.Windows.Forms.DateTimePicker dtpLastTime;
        private Dgv dgvFixedAssetHistoryList;
    }
}