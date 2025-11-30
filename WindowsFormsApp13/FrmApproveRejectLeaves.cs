using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmApproveRejectLeaves : Form
    {
        private int adminId;

        public FrmApproveRejectLeaves(int adminId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.adminId = adminId;
        }

        private void FrmApproveRejectLeaves_Load(object sender, EventArgs e)
        {
            LoadPendingLeaves();
        }

        private void LoadPendingLeaves()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT AL.LeaveRequestID,
                                          E.FullName,
                                          LT.LeaveName,
                                          AL.StartDate,
                                          AL.EndDate,
                                          AL.NumberOfDays,
                                          AL.Status,
                                          AL.Reason
                                   FROM AppliedLeaves AL
                                   INNER JOIN Employee E ON AL.EmployeeID = E.EmployeeID
                                   INNER JOIN LeaveTypes LT ON AL.LeaveTypeID = LT.LeaveTypeID
                                   WHERE AL.Status = 'Pending'
                                   ORDER BY AL.RequestedOn ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPendingLeaves.DataSource = dt;
                        dgvPendingLeaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPendingLeaves.ReadOnly = true;
                        dgvPendingLeaves.AllowUserToAddRows = false;
                        dgvPendingLeaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (dgvPendingLeaves.Columns.Count > 0)
                        {
                            dgvPendingLeaves.Columns["LeaveRequestID"].HeaderText = "Request ID";
                            dgvPendingLeaves.Columns["FullName"].HeaderText = "Employee Name";
                            dgvPendingLeaves.Columns["LeaveName"].HeaderText = "Leave Type";
                            dgvPendingLeaves.Columns["StartDate"].HeaderText = "Start Date";
                            dgvPendingLeaves.Columns["EndDate"].HeaderText = "End Date";
                            dgvPendingLeaves.Columns["NumberOfDays"].HeaderText = "Days";
                            dgvPendingLeaves.Columns["Status"].HeaderText = "Status";
                            dgvPendingLeaves.Columns["Reason"].HeaderText = "Reason";
                        }

                        if (dt.Rows.Count == 0)
                        {
                            lblStatus.Text = "No pending leave requests.";
                            lblStatus.ForeColor = System.Drawing.Color.Blue;
                        }
                        else
                        {
                            lblStatus.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending leaves: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ProcessLeaveRequest("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ProcessLeaveRequest("Rejected");
        }

        private void ProcessLeaveRequest(string status)
        {
            if (dgvPendingLeaves.SelectedRows.Count == 0)
            {
                lblStatus.Text = "Please select a leave request to process.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int leaveRequestId = Convert.ToInt32(dgvPendingLeaves.SelectedRows[0].Cells["LeaveRequestID"].Value);
            string employeeName = dgvPendingLeaves.SelectedRows[0].Cells["FullName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {status.ToLower()} the leave request for {employeeName}?", 
                "Confirm " + status, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = @"UPDATE AppliedLeaves
                                       SET Status = @status,
                                           AdminID = @adminId,
                                           DecisionDate = GETDATE()
                                       WHERE LeaveRequestID = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@adminId", adminId);
                            cmd.Parameters.AddWithValue("@id", leaveRequestId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                lblStatus.Text = $"Leave request {status.ToLower()} successfully.";
                                lblStatus.ForeColor = System.Drawing.Color.Green;
                                LoadPendingLeaves();
                            }
                            else
                            {
                                lblStatus.Text = "Failed to process leave request.";
                                lblStatus.ForeColor = System.Drawing.Color.Red;
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
        }
    }
}
