namespace WarehouseManagementSystem
{
    partial class UCAnomalyRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnomaly = new System.Windows.Forms.Label();
            this.lklblSolveTheAnomaly = new System.Windows.Forms.LinkLabel();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "异常：";
            // 
            // lblAnomaly
            // 
            this.lblAnomaly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnomaly.Location = new System.Drawing.Point(14, 36);
            this.lblAnomaly.Name = "lblAnomaly";
            this.lblAnomaly.Size = new System.Drawing.Size(698, 50);
            this.lblAnomaly.TabIndex = 1;
            this.lblAnomaly.Text = "label2";
            // 
            // lklblSolveTheAnomaly
            // 
            this.lklblSolveTheAnomaly.AutoSize = true;
            this.lklblSolveTheAnomaly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSolveTheAnomaly.Location = new System.Drawing.Point(626, 92);
            this.lklblSolveTheAnomaly.Name = "lklblSolveTheAnomaly";
            this.lklblSolveTheAnomaly.Size = new System.Drawing.Size(74, 21);
            this.lklblSolveTheAnomaly.TabIndex = 2;
            this.lklblSolveTheAnomaly.TabStop = true;
            this.lklblSolveTheAnomaly.Text = "解决异常";
            this.lklblSolveTheAnomaly.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSolveTheAnomaly_LinkClicked);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(644, 98);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 3;
            // 
            // UCAnomalyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lklblSolveTheAnomaly);
            this.Controls.Add(this.lblAnomaly);
            this.Controls.Add(this.label1);
            this.Name = "UCAnomalyRecord";
            this.Size = new System.Drawing.Size(715, 120);
            this.Load += new System.EventHandler(this.UCAnomalyRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnomaly;
        private System.Windows.Forms.LinkLabel lklblSolveTheAnomaly;
        private System.Windows.Forms.Label lblState;
    }
}
