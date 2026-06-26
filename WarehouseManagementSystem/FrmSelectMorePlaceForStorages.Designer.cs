namespace WarehouseManagementSystem
{
    partial class FrmSelectMorePlaceForStorages
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvItemsData = new WarehouseManagementSystem.Dgv();
            this.cbmStorageRack = new WarehouseManagementSystem.Cbm();
            this.nudItemCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "存放位置";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(527, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvItemsData
            // 
            this.dgvItemsData.AllowUserToAddRows = false;
            this.dgvItemsData.AllowUserToDeleteRows = false;
            this.dgvItemsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsData.Location = new System.Drawing.Point(56, 112);
            this.dgvItemsData.Name = "dgvItemsData";
            this.dgvItemsData.RowHeadersVisible = false;
            this.dgvItemsData.RowTemplate.Height = 25;
            this.dgvItemsData.Size = new System.Drawing.Size(627, 237);
            this.dgvItemsData.TabIndex = 5;
            // 
            // cbmStorageRack
            // 
            this.cbmStorageRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmStorageRack.FormattingEnabled = true;
            this.cbmStorageRack.Location = new System.Drawing.Point(115, 73);
            this.cbmStorageRack.Name = "cbmStorageRack";
            this.cbmStorageRack.Size = new System.Drawing.Size(83, 21);
            this.cbmStorageRack.TabIndex = 6;
            // 
            // nudItemCount
            // 
            this.nudItemCount.Location = new System.Drawing.Point(293, 74);
            this.nudItemCount.Name = "nudItemCount";
            this.nudItemCount.Size = new System.Drawing.Size(120, 20);
            this.nudItemCount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "存放位置：";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(223, 77);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(61, 13);
            this.lblItemCount.TabIndex = 10;
            this.lblItemCount.Text = "物品数量：";
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(608, 71);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(75, 23);
            this.btnReduce.TabIndex = 11;
            this.btnReduce.Text = "减少";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(319, 366);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(106, 36);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(608, 71);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "更改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // FrmSelectMorePlaceForStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudItemCount);
            this.Controls.Add(this.cbmStorageRack);
            this.Controls.Add(this.dgvItemsData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "FrmSelectMorePlaceForStorages";
            this.Text = "FrmSelectMorePlaceForStorages";
            this.Load += new System.EventHandler(this.FrmSelectMorePlaceForStorages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private Dgv dgvItemsData;
        private Cbm cbmStorageRack;
        private System.Windows.Forms.NumericUpDown nudItemCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnChange;
    }
}