namespace WarehouseManagementSystem
{
    partial class FrmMain
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
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnItemManagement = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReleaseTask = new System.Windows.Forms.Button();
            this.btnWarehouseRecords = new System.Windows.Forms.Button();
            this.plFrm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(7, 76);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "🏠  主页";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.btnItemManagement);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReleaseTask);
            this.panel1.Controls.Add(this.btnWarehouseRecords);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 480);
            this.panel1.TabIndex = 1;
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.btnItemManagement.FlatAppearance.BorderSize = 0;
            this.btnItemManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManagement.ForeColor = System.Drawing.Color.White;
            this.btnItemManagement.Location = new System.Drawing.Point(7, 274);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.Size = new System.Drawing.Size(124, 60);
            this.btnItemManagement.TabIndex = 5;
            this.btnItemManagement.Text = "📦  物品管理";
            this.btnItemManagement.UseVisualStyleBackColor = false;
            this.btnItemManagement.Click += new System.EventHandler(this.btnItemManagement_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 70);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库管理系统 \r\n               1.0";
            // 
            // btnReleaseTask
            // 
            this.btnReleaseTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.btnReleaseTask.FlatAppearance.BorderSize = 0;
            this.btnReleaseTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseTask.ForeColor = System.Drawing.Color.White;
            this.btnReleaseTask.Location = new System.Drawing.Point(7, 208);
            this.btnReleaseTask.Name = "btnReleaseTask";
            this.btnReleaseTask.Size = new System.Drawing.Size(124, 60);
            this.btnReleaseTask.TabIndex = 3;
            this.btnReleaseTask.Text = "📝  发布任务";
            this.btnReleaseTask.UseVisualStyleBackColor = false;
            this.btnReleaseTask.Click += new System.EventHandler(this.btnReleaseTask_Click);
            // 
            // btnWarehouseRecords
            // 
            this.btnWarehouseRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.btnWarehouseRecords.FlatAppearance.BorderSize = 0;
            this.btnWarehouseRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouseRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouseRecords.ForeColor = System.Drawing.Color.White;
            this.btnWarehouseRecords.Location = new System.Drawing.Point(7, 142);
            this.btnWarehouseRecords.Name = "btnWarehouseRecords";
            this.btnWarehouseRecords.Size = new System.Drawing.Size(124, 60);
            this.btnWarehouseRecords.TabIndex = 4;
            this.btnWarehouseRecords.Text = "🏭  仓库记录";
            this.btnWarehouseRecords.UseVisualStyleBackColor = false;
            this.btnWarehouseRecords.Click += new System.EventHandler(this.btnWarehouseRecords_Click);
            // 
            // plFrm
            // 
            this.plFrm.Location = new System.Drawing.Point(137, 0);
            this.plFrm.Name = "plFrm";
            this.plFrm.Size = new System.Drawing.Size(663, 480);
            this.plFrm.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.plFrm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemManagement;
        private System.Windows.Forms.Button btnWarehouseRecords;
        public System.Windows.Forms.Panel plFrm;
        public System.Windows.Forms.Button btnReleaseTask;
    }
}