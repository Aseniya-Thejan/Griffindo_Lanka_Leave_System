using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmRegisterEmployee : Form
    {
        public FrmRegisterEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FrmRegisterEmployee_Load(object sender, EventArgs e)
        {
            dtpDateOfJoin.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string department = txtDepartment.Text.Trim();
            string designation = txtDesignation.Text.Trim();
            DateTime dateOfJoin = dtpDateOfJoin.Value.Date;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(department) || string.IsNullOrEmpty(designation))
            {
                lblMessage.Text = "Please fill in all fields.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!IsValidEmail(email))
            {
                lblMessage.Text = "Please enter a valid email address.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string insertEmployeeQuery = @"INSERT INTO Employee
                                                 (FullName, Email, Department, Designation, DateOfJoin, EmploymentStatus)
                                                 VALUES
                                                 (@name, @mail, @dept, @desig, @doj, 'Active');
                                                 SELECT SCOPE_IDENTITY();";

                    int newEmployeeId;

                    using (SqlCommand cmd = new SqlCommand(insertEmployeeQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@dept", department);
                        cmd.Parameters.AddWithValue("@desig", designation);
                        cmd.Parameters.AddWithValue("@doj", dateOfJoin);

                        newEmployeeId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string username = email.Split('@')[0];
                    string defaultPassword = "Employee123";

                    string insertLoginQuery = @"INSERT INTO Login
                                              (Username, PasswordHash, UserRole, LinkedEmployeeID, LinkedAdminID, IsLocked)
                                              VALUES
                                              (@username, @password, 'Employee', @empId, NULL, 0)";

                    using (SqlCommand cmd = new SqlCommand(insertLoginQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", defaultPassword);
                        cmd.Parameters.AddWithValue("@empId", newEmployeeId);

                        cmd.ExecuteNonQuery();
                    }

                    lblMessage.Text = "Employee registered successfully!\nUsername: " + username + "\nPassword: " + defaultPassword;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    ClearFields();
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    lblMessage.Text = "Email already exists. Please use a different email.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            lblMessage.Text = "";
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            dtpDateOfJoin.Value = DateTime.Now;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
