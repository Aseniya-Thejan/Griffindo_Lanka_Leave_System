namespace WindowsFormsApp13
{
    partial class FrmStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartup));
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(294, 599);
            this.btnEmployeeLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(229, 75);
            this.btnEmployeeLogin.TabIndex = 0;
            this.btnEmployeeLogin.Text = "Employee Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdminLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminLogin.Location = new System.Drawing.Point(553, 608);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(229, 66);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(444, 699);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 54);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(308, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Griffindo Lanka Toys (Pvt) Ltd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(378, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leave Management System v1.0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(383, 164);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 387);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 803);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnEmployeeLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStartup";
            this.Text = "Leave Management System - Griffindo Lanka Toys";
            this.Load += new System.EventHandler(this.FrmStartup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
