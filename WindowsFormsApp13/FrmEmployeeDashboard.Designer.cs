namespace WindowsFormsApp13
{
    partial class FrmEmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeDashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.btnLeaveHistory = new System.Windows.Forms.Button();
            this.btnDeleteLeave = new System.Windows.Forms.Button();
            this.btnRemainingLeaves = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(420, 81);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(139, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApplyLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApplyLeave.Location = new System.Drawing.Point(322, 523);
            this.btnApplyLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(168, 55);
            this.btnApplyLeave.TabIndex = 1;
            this.btnApplyLeave.Text = "Apply Leave";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // btnLeaveHistory
            // 
            this.btnLeaveHistory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLeaveHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeaveHistory.Location = new System.Drawing.Point(535, 523);
            this.btnLeaveHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeaveHistory.Name = "btnLeaveHistory";
            this.btnLeaveHistory.Size = new System.Drawing.Size(193, 55);
            this.btnLeaveHistory.TabIndex = 2;
            this.btnLeaveHistory.Text = "Leave History";
            this.btnLeaveHistory.UseVisualStyleBackColor = false;
            this.btnLeaveHistory.Click += new System.EventHandler(this.btnLeaveHistory_Click);
            // 
            // btnDeleteLeave
            // 
            this.btnDeleteLeave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteLeave.Location = new System.Drawing.Point(296, 595);
            this.btnDeleteLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteLeave.Name = "btnDeleteLeave";
            this.btnDeleteLeave.Size = new System.Drawing.Size(194, 69);
            this.btnDeleteLeave.TabIndex = 3;
            this.btnDeleteLeave.Text = "Delete Leave Request";
            this.btnDeleteLeave.UseVisualStyleBackColor = false;
            this.btnDeleteLeave.Click += new System.EventHandler(this.btnDeleteLeave_Click);
            // 
            // btnRemainingLeaves
            // 
            this.btnRemainingLeaves.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemainingLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemainingLeaves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemainingLeaves.Location = new System.Drawing.Point(535, 610);
            this.btnRemainingLeaves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemainingLeaves.Name = "btnRemainingLeaves";
            this.btnRemainingLeaves.Size = new System.Drawing.Size(236, 54);
            this.btnRemainingLeaves.TabIndex = 4;
            this.btnRemainingLeaves.Text = "Remaining Leaves";
            this.btnRemainingLeaves.UseVisualStyleBackColor = false;
            this.btnRemainingLeaves.Click += new System.EventHandler(this.btnRemainingLeaves_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(449, 691);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 43);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(350, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Dashboard - Griffindo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(368, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 329);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // FrmEmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 768);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemainingLeaves);
            this.Controls.Add(this.btnDeleteLeave);
            this.Controls.Add(this.btnLeaveHistory);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmployeeDashboard";
            this.Text = "Employee Dashboard - Griffindo Lanka Toys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Button btnLeaveHistory;
        private System.Windows.Forms.Button btnDeleteLeave;
        private System.Windows.Forms.Button btnRemainingLeaves;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
