namespace WarehouseManagementSystem
{
    partial class FrmEditItem
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
            this.btnGetImage = new System.Windows.Forms.Button();
            this.tbImagePath = new WarehouseManagementSystem.Tb();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.tbItemName = new WarehouseManagementSystem.Tb();
            this.nudSafeStock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmType = new WarehouseManagementSystem.Cbm();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFixedAsset = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFixedAssetEdit = new System.Windows.Forms.GroupBox();
            this.cbmUser = new WarehouseManagementSystem.Cbm();
            this.cbmPlaceforStorage = new WarehouseManagementSystem.Cbm();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.dgvFixedAsset = new WarehouseManagementSystem.Dgv();
            this.btnChangePlaceForStorage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsFixedAsset = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUnit = new WarehouseManagementSystem.Tb();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.gbFixedAssetEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixedAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(553, 115);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage.TabIndex = 22;
            this.btnGetImage.Text = "物品图片";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(434, 115);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(113, 20);
            this.tbImagePath.TabIndex = 21;
            // 
            // pbItemImage
            // 
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Location = new System.Drawing.Point(652, 76);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(136, 63);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 20;
            this.pbItemImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "物品名：";
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(83, 490);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(118, 37);
            this.btnCommit.TabIndex = 19;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(106, 74);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(154, 20);
            this.tbItemName.TabIndex = 14;
            // 
            // nudSafeStock
            // 
            this.nudSafeStock.Location = new System.Drawing.Point(106, 116);
            this.nudSafeStock.Name = "nudSafeStock";
            this.nudSafeStock.Size = new System.Drawing.Size(154, 20);
            this.nudSafeStock.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(276, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "物品类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "安全库存：";
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Location = new System.Drawing.Point(365, 77);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(85, 21);
            this.cbmType.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(311, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 47);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "物品添加";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(566, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 37);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFixedAsset
            // 
            this.btnAddFixedAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFixedAsset.Location = new System.Drawing.Point(169, 27);
            this.btnAddFixedAsset.Name = "btnAddFixedAsset";
            this.btnAddFixedAsset.Size = new System.Drawing.Size(93, 20);
            this.btnAddFixedAsset.TabIndex = 26;
            this.btnAddFixedAsset.Text = "添加";
            this.btnAddFixedAsset.UseVisualStyleBackColor = true;
            this.btnAddFixedAsset.Click += new System.EventHandler(this.btnAddFixedAsset_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(62, 27);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(92, 20);
            this.nudCount.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "数量：";
            // 
            // gbFixedAssetEdit
            // 
            this.gbFixedAssetEdit.Controls.Add(this.cbmUser);
            this.gbFixedAssetEdit.Controls.Add(this.cbmPlaceforStorage);
            this.gbFixedAssetEdit.Controls.Add(this.btnChangeUser);
            this.gbFixedAssetEdit.Controls.Add(this.dgvFixedAsset);
            this.gbFixedAssetEdit.Controls.Add(this.label5);
            this.gbFixedAssetEdit.Controls.Add(this.btnAddFixedAsset);
            this.gbFixedAssetEdit.Controls.Add(this.btnChangePlaceForStorage);
            this.gbFixedAssetEdit.Controls.Add(this.label6);
            this.gbFixedAssetEdit.Controls.Add(this.nudCount);
            this.gbFixedAssetEdit.Controls.Add(this.label1);
            this.gbFixedAssetEdit.Location = new System.Drawing.Point(21, 159);
            this.gbFixedAssetEdit.Name = "gbFixedAssetEdit";
            this.gbFixedAssetEdit.Size = new System.Drawing.Size(767, 313);
            this.gbFixedAssetEdit.TabIndex = 29;
            this.gbFixedAssetEdit.TabStop = false;
            this.gbFixedAssetEdit.Text = "固定资产";
            // 
            // cbmUser
            // 
            this.cbmUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmUser.FormattingEnabled = true;
            this.cbmUser.Location = new System.Drawing.Point(451, 261);
            this.cbmUser.Name = "cbmUser";
            this.cbmUser.Size = new System.Drawing.Size(102, 21);
            this.cbmUser.TabIndex = 37;
            // 
            // cbmPlaceforStorage
            // 
            this.cbmPlaceforStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPlaceforStorage.FormattingEnabled = true;
            this.cbmPlaceforStorage.Location = new System.Drawing.Point(97, 262);
            this.cbmPlaceforStorage.Name = "cbmPlaceforStorage";
            this.cbmPlaceforStorage.Size = new System.Drawing.Size(121, 21);
            this.cbmPlaceforStorage.TabIndex = 36;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUser.Location = new System.Drawing.Point(559, 263);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(69, 20);
            this.btnChangeUser.TabIndex = 35;
            this.btnChangeUser.Text = "更改";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // dgvFixedAsset
            // 
            this.dgvFixedAsset.AllowUserToAddRows = false;
            this.dgvFixedAsset.AllowUserToDeleteRows = false;
            this.dgvFixedAsset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFixedAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFixedAsset.Location = new System.Drawing.Point(6, 67);
            this.dgvFixedAsset.Name = "dgvFixedAsset";
            this.dgvFixedAsset.RowHeadersVisible = false;
            this.dgvFixedAsset.RowTemplate.Height = 25;
            this.dgvFixedAsset.Size = new System.Drawing.Size(755, 178);
            this.dgvFixedAsset.TabIndex = 29;
            this.dgvFixedAsset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFixedAsset_CellClick_1);
            // 
            // btnChangePlaceForStorage
            // 
            this.btnChangePlaceForStorage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePlaceForStorage.Location = new System.Drawing.Point(224, 262);
            this.btnChangePlaceForStorage.Name = "btnChangePlaceForStorage";
            this.btnChangePlaceForStorage.Size = new System.Drawing.Size(69, 20);
            this.btnChangePlaceForStorage.TabIndex = 34;
            this.btnChangePlaceForStorage.Text = "更改";
            this.btnChangePlaceForStorage.UseVisualStyleBackColor = true;
            this.btnChangePlaceForStorage.Click += new System.EventHandler(this.btnChangePlaceForStorage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(379, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "使用人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(8, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "存放位置：";
            // 
            // cbIsFixedAsset
            // 
            this.cbIsFixedAsset.AutoSize = true;
            this.cbIsFixedAsset.Location = new System.Drawing.Point(280, 120);
            this.cbIsFixedAsset.Name = "cbIsFixedAsset";
            this.cbIsFixedAsset.Size = new System.Drawing.Size(74, 17);
            this.cbIsFixedAsset.TabIndex = 30;
            this.cbIsFixedAsset.Text = "固定资产";
            this.cbIsFixedAsset.UseVisualStyleBackColor = true;
            this.cbIsFixedAsset.CheckedChanged += new System.EventHandler(this.cbIsFixedAsset_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(472, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "单位：";
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(544, 76);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(83, 20);
            this.tbUnit.TabIndex = 32;
            // 
            // FrmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.cbIsFixedAsset);
            this.Controls.Add(this.gbFixedAssetEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.nudSafeStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmType);
            this.Name = "FrmEditItem";
            this.Text = "FrmEditItem";
            this.Load += new System.EventHandler(this.FrmEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.gbFixedAssetEdit.ResumeLayout(false);
            this.gbFixedAssetEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixedAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetImage;
        private Tb tbImagePath;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCommit;
        private Tb tbItemName;
        private System.Windows.Forms.NumericUpDown nudSafeStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Cbm cbmType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddFixedAsset;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbFixedAssetEdit;
        private System.Windows.Forms.CheckBox cbIsFixedAsset;
        private Dgv dgvFixedAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangePlaceForStorage;
        private System.Windows.Forms.Button btnChangeUser;
        private Cbm cbmPlaceforStorage;
        private Cbm cbmUser;
        private System.Windows.Forms.Label label7;
        private Tb tbUnit;
    }
}