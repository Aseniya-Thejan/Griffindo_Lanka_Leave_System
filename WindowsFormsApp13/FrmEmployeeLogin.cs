using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmEmployeeLogin : Form
    {
        public FrmEmployeeLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter username and password.";
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT L.LoginID, L.UserRole, E.EmployeeID, E.FullName
                                   FROM Login L
                                   INNER JOIN Employee E ON L.LinkedEmployeeID = E.EmployeeID
                                   WHERE L.Username = @username
                                     AND L.PasswordHash = @password
                                     AND L.UserRole = 'Employee'
                                     AND E.EmploymentStatus = 'Active'
                                     AND L.IsLocked = 0";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int employeeId = reader.GetInt32(2);
                                string fullName = reader.GetString(3);

                                FrmEmployeeDashboard dashboard = new FrmEmployeeDashboard(employeeId, fullName);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                lblError.Text = "Invalid username or password.";
                                lblError.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblError.Text = "";
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
