namespace WindowsFormsApp13
{
    partial class FrmGenerateReports
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.btnLeaveTypeReport = new System.Windows.Forms.Button();
            this.btnStatusReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(30, 169);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.Size = new System.Drawing.Size(1290, 538);
            this.dgvReports.TabIndex = 0;
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmployeeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeReport.Location = new System.Drawing.Point(261, 738);
            this.btnEmployeeReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(189, 54);
            this.btnEmployeeReport.TabIndex = 1;
            this.btnEmployeeReport.Text = "By Employee";
            this.btnEmployeeReport.UseVisualStyleBackColor = false;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // btnLeaveTypeReport
            // 
            this.btnLeaveTypeReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLeaveTypeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveTypeReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeaveTypeReport.Location = new System.Drawing.Point(610, 738);
            this.btnLeaveTypeReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeaveTypeReport.Name = "btnLeaveTypeReport";
            this.btnLeaveTypeReport.Size = new System.Drawing.Size(200, 54);
            this.btnLeaveTypeReport.TabIndex = 2;
            this.btnLeaveTypeReport.Text = "By Leave Type";
            this.btnLeaveTypeReport.UseVisualStyleBackColor = false;
            this.btnLeaveTypeReport.Click += new System.EventHandler(this.btnLeaveTypeReport_Click);
            // 
            // btnStatusReport
            // 
            this.btnStatusReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStatusReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatusReport.Location = new System.Drawing.Point(937, 738);
            this.btnStatusReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatusReport.Name = "btnStatusReport";
            this.btnStatusReport.Size = new System.Drawing.Size(154, 54);
            this.btnStatusReport.TabIndex = 3;
            this.btnStatusReport.Text = "By Status";
            this.btnStatusReport.UseVisualStyleBackColor = false;
            this.btnStatusReport.Click += new System.EventHandler(this.btnStatusReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(480, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Leave Request Reports";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.Location = new System.Drawing.Point(30, 123);
            this.lblReportTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(328, 26);
            this.lblReportTitle.TabIndex = 5;
            this.lblReportTitle.Text = "Leave Requests by Employee";
            // 
            // FrmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 832);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatusReport);
            this.Controls.Add(this.btnLeaveTypeReport);
            this.Controls.Add(this.btnEmployeeReport);
            this.Controls.Add(this.dgvReports);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGenerateReports";
            this.Text = "Generate Reports - Griffindo Lanka Toys";
            this.Load += new System.EventHandler(this.FrmGenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.Button btnLeaveTypeReport;
        private System.Windows.Forms.Button btnStatusReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReportTitle;
    }
}
