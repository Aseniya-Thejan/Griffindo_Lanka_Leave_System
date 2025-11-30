using System;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmAdminDashboard : Form
    {
        private int adminId;
        private string fullName;

        public FrmAdminDashboard(int adminId, string fullName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.adminId = adminId;
            this.fullName = fullName;
            lblWelcome.Text = "Admin Panel - " + fullName;
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            FrmRegisterEmployee frmRegisterEmployee = new FrmRegisterEmployee();
            frmRegisterEmployee.ShowDialog();
        }

        private void btnManageLeaveTypes_Click(object sender, EventArgs e)
        {
            FrmManageLeaveTypes frmManageLeaveTypes = new FrmManageLeaveTypes();
            frmManageLeaveTypes.ShowDialog();
        }

        private void btnApproveRejectLeaves_Click(object sender, EventArgs e)
        {
            FrmApproveRejectLeaves frmApproveRejectLeaves = new FrmApproveRejectLeaves(adminId);
            frmApproveRejectLeaves.ShowDialog();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            FrmGenerateReports frmGenerateReports = new FrmGenerateReports();
            frmGenerateReports.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                FrmAdminLogin loginForm = new FrmAdminLogin();
                loginForm.Show();
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
