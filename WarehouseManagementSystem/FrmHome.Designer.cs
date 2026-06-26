namespace WarehouseManagementSystem
{
    partial class FrmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStorageRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUnfinishedTaskCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStockOutRecordCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAbnormalItemCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAbnormalItemData = new WarehouseManagementSystem.Dgv();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUnfinishedTaskData = new WarehouseManagementSystem.Dgv();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnormalItemData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnfinishedTaskData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "主页";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStorageRecordCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 83);
            this.panel1.TabIndex = 2;
            // 
            // lblStorageRecordCount
            // 
            this.lblStorageRecordCount.AutoSize = true;
            this.lblStorageRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageRecordCount.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblStorageRecordCount.Location = new System.Drawing.Point(46, 32);
            this.lblStorageRecordCount.Name = "lblStorageRecordCount";
            this.lblStorageRecordCount.Size = new System.Drawing.Size(92, 31);
            this.lblStorageRecordCount.TabIndex = 1;
            this.lblStorageRecordCount.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "入库记录数量：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblUnfinishedTaskCount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(495, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 83);
            this.panel2.TabIndex = 3;
            // 
            // lblUnfinishedTaskCount
            // 
            this.lblUnfinishedTaskCount.AutoSize = true;
            this.lblUnfinishedTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfinishedTaskCount.ForeColor = System.Drawing.Color.Gray;
            this.lblUnfinishedTaskCount.Location = new System.Drawing.Point(46, 32);
            this.lblUnfinishedTaskCount.Name = "lblUnfinishedTaskCount";
            this.lblUnfinishedTaskCount.Size = new System.Drawing.Size(92, 31);
            this.lblUnfinishedTaskCount.TabIndex = 1;
            this.lblUnfinishedTaskCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "未完成任务数量：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblStockOutRecordCount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(173, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 83);
            this.panel3.TabIndex = 3;
            // 
            // lblStockOutRecordCount
            // 
            this.lblStockOutRecordCount.AutoSize = true;
            this.lblStockOutRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockOutRecordCount.ForeColor = System.Drawing.Color.Green;
            this.lblStockOutRecordCount.Location = new System.Drawing.Point(46, 32);
            this.lblStockOutRecordCount.Name = "lblStockOutRecordCount";
            this.lblStockOutRecordCount.Size = new System.Drawing.Size(92, 31);
            this.lblStockOutRecordCount.TabIndex = 1;
            this.lblStockOutRecordCount.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "出库记录数量：";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblAbnormalItemCount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(334, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 83);
            this.panel4.TabIndex = 3;
            // 
            // lblAbnormalItemCount
            // 
            this.lblAbnormalItemCount.AutoSize = true;
            this.lblAbnormalItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbnormalItemCount.ForeColor = System.Drawing.Color.Red;
            this.lblAbnormalItemCount.Location = new System.Drawing.Point(46, 32);
            this.lblAbnormalItemCount.Name = "lblAbnormalItemCount";
            this.lblAbnormalItemCount.Size = new System.Drawing.Size(92, 31);
            this.lblAbnormalItemCount.TabIndex = 1;
            this.lblAbnormalItemCount.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "危险物品数量：";
            // 
            // dgvAbnormalItemData
            // 
            this.dgvAbnormalItemData.AllowUserToAddRows = false;
            this.dgvAbnormalItemData.AllowUserToDeleteRows = false;
            this.dgvAbnormalItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbnormalItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnormalItemData.Location = new System.Drawing.Point(12, 348);
            this.dgvAbnormalItemData.Name = "dgvAbnormalItemData";
            this.dgvAbnormalItemData.RowHeadersVisible = false;
            this.dgvAbnormalItemData.RowTemplate.Height = 42;
            this.dgvAbnormalItemData.Size = new System.Drawing.Size(635, 120);
            this.dgvAbnormalItemData.TabIndex = 9;
            this.dgvAbnormalItemData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbnormalItemData_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "未完成任务：";
            // 
            // dgvUnfinishedTaskData
            // 
            this.dgvUnfinishedTaskData.AllowUserToAddRows = false;
            this.dgvUnfinishedTaskData.AllowUserToDeleteRows = false;
            this.dgvUnfinishedTaskData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnfinishedTaskData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnfinishedTaskData.Location = new System.Drawing.Point(12, 186);
            this.dgvUnfinishedTaskData.Name = "dgvUnfinishedTaskData";
            this.dgvUnfinishedTaskData.RowHeadersVisible = false;
            this.dgvUnfinishedTaskData.RowTemplate.Height = 42;
            this.dgvUnfinishedTaskData.Size = new System.Drawing.Size(635, 120);
            this.dgvUnfinishedTaskData.TabIndex = 11;
            this.dgvUnfinishedTaskData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnfinishedTaskData_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "异常物品：";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.dgvUnfinishedTaskData);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvAbnormalItemData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnormalItemData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnfinishedTaskData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStorageRecordCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUnfinishedTaskCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStockOutRecordCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAbnormalItemCount;
        private System.Windows.Forms.Label label9;
        private Dgv dgvAbnormalItemData;
        private System.Windows.Forms.Label label12;
        private Dgv dgvUnfinishedTaskData;
        private System.Windows.Forms.Label label13;
    }
}