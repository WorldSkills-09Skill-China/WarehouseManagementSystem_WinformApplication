namespace WarehouseManagementSystem
{
    partial class FrmImportData
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
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItemData = new WarehouseManagementSystem.Dgv();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入数据";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Green;
            this.btnCommit.Location = new System.Drawing.Point(293, 380);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(174, 33);
            this.btnCommit.TabIndex = 22;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.BackColor = System.Drawing.Color.Green;
            this.btnImportData.Location = new System.Drawing.Point(633, 61);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(100, 33);
            this.btnImportData.TabIndex = 23;
            this.btnImportData.Text = "导入csv/xlsx";
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.Red;
            this.btnClearData.Location = new System.Drawing.Point(516, 61);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(100, 33);
            this.btnClearData.TabIndex = 24;
            this.btnClearData.Text = "清空数据";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "提示：列头格式为（\"ItemName,ItemType,SafeCount,Count,IsFixedAsset,PlaceForStorageDetail,Un" +
    "it\"）";
            // 
            // dgvItemData
            // 
            this.dgvItemData.AllowDrop = true;
            this.dgvItemData.AllowUserToAddRows = false;
            this.dgvItemData.AllowUserToDeleteRows = false;
            this.dgvItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemData.Location = new System.Drawing.Point(44, 115);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.RowHeadersVisible = false;
            this.dgvItemData.RowTemplate.Height = 25;
            this.dgvItemData.Size = new System.Drawing.Size(689, 259);
            this.dgvItemData.TabIndex = 26;
            this.dgvItemData.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvItemData_DragDrop_1);
            this.dgvItemData.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvItemData_DragEnter_1);
            // 
            // FrmImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvItemData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.label1);
            this.Name = "FrmImportData";
            this.Text = "FrmImportData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label label2;
        private Dgv dgvItemData;
    }
}