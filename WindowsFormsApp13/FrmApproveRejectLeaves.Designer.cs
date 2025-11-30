namespace WindowsFormsApp13
{
    partial class FrmApproveRejectLeaves
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvPendingLeaves = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendingLeaves
            // 
            this.dgvPendingLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingLeaves.Location = new System.Drawing.Point(30, 108);
            this.dgvPendingLeaves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPendingLeaves.Name = "dgvPendingLeaves";
            this.dgvPendingLeaves.RowHeadersWidth = 62;
            this.dgvPendingLeaves.Size = new System.Drawing.Size(1290, 538);
            this.dgvPendingLeaves.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApprove.Location = new System.Drawing.Point(435, 677);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(210, 54);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReject.Location = new System.Drawing.Point(720, 677);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(210, 54);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(30, 754);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 22);
            this.lblStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(435, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Approve / Reject Leave Requests";
            // 
            // FrmApproveRejectLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 802);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvPendingLeaves);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmApproveRejectLeaves";
            this.Text = "Approve/Reject Leaves - Griffindo Lanka Toys";
            this.Load += new System.EventHandler(this.FrmApproveRejectLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPendingLeaves;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}
