using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmApplyLeave : Form
    {
        private int employeeId;

        public FrmApplyLeave(int employeeId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.employeeId = employeeId;
        }

        private void FrmApplyLeave_Load(object sender, EventArgs e)
        {
            LoadLeaveTypes();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadLeaveTypes()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT LeaveTypeID, LeaveName FROM LeaveTypes ORDER BY LeaveName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbLeaveType.DataSource = dt;
                        cmbLeaveType.DisplayMember = "LeaveName";
                        cmbLeaveType.ValueMember = "LeaveTypeID";
                        cmbLeaveType.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave types: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbLeaveType.SelectedIndex == -1)
            {
                lblMessage.Text = "Please select a leave type.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                lblMessage.Text = "End date cannot be before start date.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                lblMessage.Text = "Please provide a reason for leave.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                int leaveTypeId = Convert.ToInt32(cmbLeaveType.SelectedValue);
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;
                int numberOfDays = (endDate - startDate).Days + 1;
                string reason = txtReason.Text.Trim();

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO AppliedLeaves
                                   (EmployeeID, LeaveTypeID, AdminID, StartDate, EndDate,
                                    NumberOfDays, Status, Reason, RequestedOn)
                                   VALUES
                                   (@empId, @typeId, NULL, @start, @end,
                                    @days, 'Pending', @reason, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", employeeId);
                        cmd.Parameters.AddWithValue("@typeId", leaveTypeId);
                        cmd.Parameters.AddWithValue("@start", startDate);
                        cmd.Parameters.AddWithValue("@end", endDate);
                        cmd.Parameters.AddWithValue("@days", numberOfDays);
                        cmd.Parameters.AddWithValue("@reason", reason);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            lblMessage.Text = "Leave request submitted successfully!";
                            lblMessage.ForeColor = System.Drawing.Color.Green;
                            ClearFields();
                        }
                        else
                        {
                            lblMessage.Text = "Failed to submit leave request.";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                        }
                    }
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
            cmbLeaveType.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtReason.Clear();
        }
    }
}
