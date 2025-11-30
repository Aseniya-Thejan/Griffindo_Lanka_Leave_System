using System;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmEmployeeDashboard : Form
    {
        private int employeeId;
        private string fullName;

        public FrmEmployeeDashboard(int employeeId, string fullName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.employeeId = employeeId;
            this.fullName = fullName;
            lblWelcome.Text = "Welcome, " + fullName;
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            FrmApplyLeave frmApplyLeave = new FrmApplyLeave(employeeId);
            frmApplyLeave.ShowDialog();
        }

        private void btnLeaveHistory_Click(object sender, EventArgs e)
        {
            FrmLeaveHistory frmLeaveHistory = new FrmLeaveHistory(employeeId);
            frmLeaveHistory.ShowDialog();
        }

        private void btnDeleteLeave_Click(object sender, EventArgs e)
        {
            FrmDeleteLeave frmDeleteLeave = new FrmDeleteLeave(employeeId);
            frmDeleteLeave.ShowDialog();
        }

        private void btnRemainingLeaves_Click(object sender, EventArgs e)
        {
            FrmRemainingLeaves frmRemainingLeaves = new FrmRemainingLeaves(employeeId);
            frmRemainingLeaves.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                FrmEmployeeLogin loginForm = new FrmEmployeeLogin();
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
