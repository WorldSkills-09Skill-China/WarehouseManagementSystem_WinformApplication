namespace WarehouseManagementSystem
{
    partial class FrmEdtiItemSpecification
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
            this.dgvItemSpecifications = new WarehouseManagementSystem.Dgv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbValue = new WarehouseManagementSystem.Tb();
            this.tbKey = new WarehouseManagementSystem.Tb();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSpecifications)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(328, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 47);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "物品规格";
            // 
            // dgvItemSpecifications
            // 
            this.dgvItemSpecifications.AllowUserToAddRows = false;
            this.dgvItemSpecifications.AllowUserToDeleteRows = false;
            this.dgvItemSpecifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemSpecifications.Location = new System.Drawing.Point(87, 80);
            this.dgvItemSpecifications.Name = "dgvItemSpecifications";
            this.dgvItemSpecifications.RowHeadersVisible = false;
            this.dgvItemSpecifications.RowTemplate.Height = 25;
            this.dgvItemSpecifications.Size = new System.Drawing.Size(350, 323);
            this.dgvItemSpecifications.TabIndex = 25;
            this.dgvItemSpecifications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemSpecifications_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.tbKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(457, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 322);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(10, 151);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(254, 20);
            this.tbValue.TabIndex = 32;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(10, 54);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(254, 20);
            this.tbKey.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "规格值：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "规格名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 34);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(351, 415);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(110, 23);
            this.btnCommit.TabIndex = 28;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // FrmEdtiItemSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItemSpecifications);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmEdtiItemSpecification";
            this.Text = "EdtiItemDetail";
            this.Load += new System.EventHandler(this.EdtiItemSpecification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSpecifications)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Dgv dgvItemSpecifications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Tb tbValue;
        private Tb tbKey;
        private System.Windows.Forms.Button btnCommit;
    }
}