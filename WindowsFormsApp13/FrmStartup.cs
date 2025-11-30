using System;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmStartup : Form
    {
        public FrmStartup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            FrmEmployeeLogin employeeLogin = new FrmEmployeeLogin();
            employeeLogin.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin adminLogin = new FrmAdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {

        }
    }
}
