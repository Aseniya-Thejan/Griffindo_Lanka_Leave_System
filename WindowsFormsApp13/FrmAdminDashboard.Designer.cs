namespace WindowsFormsApp13
{
    partial class FrmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.btnManageLeaveTypes = new System.Windows.Forms.Button();
            this.btnApproveRejectLeaves = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(364, 22);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(187, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Admin Panel";
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegisterEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterEmployee.Location = new System.Drawing.Point(196, 435);
            this.btnRegisterEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(264, 74);
            this.btnRegisterEmployee.TabIndex = 1;
            this.btnRegisterEmployee.Text = "Register Employee";
            this.btnRegisterEmployee.UseVisualStyleBackColor = false;
            this.btnRegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // btnManageLeaveTypes
            // 
            this.btnManageLeaveTypes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnManageLeaveTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLeaveTypes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageLeaveTypes.Location = new System.Drawing.Point(479, 435);
            this.btnManageLeaveTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageLeaveTypes.Name = "btnManageLeaveTypes";
            this.btnManageLeaveTypes.Size = new System.Drawing.Size(214, 81);
            this.btnManageLeaveTypes.TabIndex = 2;
            this.btnManageLeaveTypes.Text = "Manage Leave Types";
            this.btnManageLeaveTypes.UseVisualStyleBackColor = false;
            this.btnManageLeaveTypes.Click += new System.EventHandler(this.btnManageLeaveTypes_Click);
            // 
            // btnApproveRejectLeaves
            // 
            this.btnApproveRejectLeaves.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApproveRejectLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveRejectLeaves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApproveRejectLeaves.Location = new System.Drawing.Point(198, 524);
            this.btnApproveRejectLeaves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApproveRejectLeaves.Name = "btnApproveRejectLeaves";
            this.btnApproveRejectLeaves.Size = new System.Drawing.Size(257, 77);
            this.btnApproveRejectLeaves.TabIndex = 3;
            this.btnApproveRejectLeaves.Text = "Approve/Reject Leaves";
            this.btnApproveRejectLeaves.UseVisualStyleBackColor = false;
            this.btnApproveRejectLeaves.Click += new System.EventHandler(this.btnApproveRejectLeaves_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateReports.Location = new System.Drawing.Point(490, 526);
            this.btnGenerateReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(226, 73);
            this.btnGenerateReports.TabIndex = 4;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(425, 619);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(273, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administration - Griffindo Lanka";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(278, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 332);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnApproveRejectLeaves);
            this.Controls.Add(this.btnManageLeaveTypes);
            this.Controls.Add(this.btnRegisterEmployee);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminDashboard";
            this.Text = "Admin Dashboard - Griffindo Lanka Toys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private System.Windows.Forms.Button btnManageLeaveTypes;
        private System.Windows.Forms.Button btnApproveRejectLeaves;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
