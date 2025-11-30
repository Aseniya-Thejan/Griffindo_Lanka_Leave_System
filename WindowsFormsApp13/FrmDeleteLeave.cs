using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmDeleteLeave : Form
    {
        private int employeeId;

        public FrmDeleteLeave(int employeeId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.employeeId = employeeId;
        }

        private void FrmDeleteLeave_Load(object sender, EventArgs e)
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
                    string query = @"SELECT LeaveRequestID, StartDate, EndDate, NumberOfDays, Status
                                   FROM AppliedLeaves
                                   WHERE EmployeeID = @empId AND Status = 'Pending'
                                   ORDER BY RequestedOn DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", employeeId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPending.DataSource = dt;
                        dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPending.ReadOnly = true;
                        dgvPending.AllowUserToAddRows = false;
                        dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (dgvPending.Columns.Count > 0)
                        {
                            dgvPending.Columns["LeaveRequestID"].HeaderText = "Request ID";
                            dgvPending.Columns["StartDate"].HeaderText = "Start Date";
                            dgvPending.Columns["EndDate"].HeaderText = "End Date";
                            dgvPending.Columns["NumberOfDays"].HeaderText = "Days";
                            dgvPending.Columns["Status"].HeaderText = "Status";
                        }

                        if (dt.Rows.Count == 0)
                        {
                            lblStatus.Text = "No pending leave requests found.";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedRows.Count == 0)
            {
                lblStatus.Text = "Please select a leave request to delete.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int leaveRequestId = Convert.ToInt32(dgvPending.SelectedRows[0].Cells["LeaveRequestID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this leave request?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = @"DELETE FROM AppliedLeaves
                                       WHERE LeaveRequestID = @id AND Status = 'Pending'";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", leaveRequestId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                lblStatus.Text = "Leave request deleted successfully.";
                                lblStatus.ForeColor = System.Drawing.Color.Green;
                                LoadPendingLeaves();
                            }
                            else
                            {
                                lblStatus.Text = "Failed to delete leave request.";
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
