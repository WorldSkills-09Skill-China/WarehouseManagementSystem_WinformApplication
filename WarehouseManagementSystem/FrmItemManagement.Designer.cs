namespace WarehouseManagementSystem
{
    partial class FrmItemManagement
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemName = new WarehouseManagementSystem.Tb();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.dgvItemsData = new WarehouseManagementSystem.Dgv();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "物品管理";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(438, 12);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(87, 40);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "添加物品";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(8, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "物品：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "物品名：";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(80, 74);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(100, 22);
            this.tbItemName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(202, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "物品类型：";
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(291, 75);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(121, 21);
            this.cbmType.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(554, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 22);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.BackColor = System.Drawing.Color.Green;
            this.btnImportData.Location = new System.Drawing.Point(541, 8);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(100, 44);
            this.btnImportData.TabIndex = 22;
            this.btnImportData.Text = "导入批量数据";
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // dgvItemsData
            // 
            this.dgvItemsData.AllowUserToAddRows = false;
            this.dgvItemsData.AllowUserToDeleteRows = false;
            this.dgvItemsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsData.Location = new System.Drawing.Point(12, 182);
            this.dgvItemsData.Name = "dgvItemsData";
            this.dgvItemsData.RowHeadersVisible = false;
            this.dgvItemsData.RowTemplate.Height = 25;
            this.dgvItemsData.Size = new System.Drawing.Size(629, 267);
            this.dgvItemsData.TabIndex = 23;
            this.dgvItemsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsData_CellClick_1);
            // 
            // FrmItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.dgvItemsData);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddItem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemManagement";
            this.Text = "FrmItemManagement";
            this.Load += new System.EventHandler(this.FrmItemManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Tb tbItemName;
        private System.Windows.Forms.Label label3;
        private Cbm cbmType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnImportData;
        private Dgv dgvItemsData;
    }
}