using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmLeaveHistory : Form
    {
        private int employeeId;

        public FrmLeaveHistory(int employeeId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.employeeId = employeeId;
        }

        private void FrmLeaveHistory_Load(object sender, EventArgs e)
        {
            LoadLeaveHistory();
        }

        private void LoadLeaveHistory()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT AL.LeaveRequestID,
                                          LT.LeaveName,
                                          AL.StartDate,
                                          AL.EndDate,
                                          AL.NumberOfDays,
                                          AL.Status,
                                          AL.RequestedOn,
                                          AL.DecisionDate
                                   FROM AppliedLeaves AL
                                   INNER JOIN LeaveTypes LT ON AL.LeaveTypeID = LT.LeaveTypeID
                                   WHERE AL.EmployeeID = @empId
                                   ORDER BY AL.RequestedOn DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", employeeId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvHistory.DataSource = dt;
                        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvHistory.ReadOnly = true;
                        dgvHistory.AllowUserToAddRows = false;
                        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (dgvHistory.Columns.Count > 0)
                        {
                            dgvHistory.Columns["LeaveRequestID"].HeaderText = "Request ID";
                            dgvHistory.Columns["LeaveName"].HeaderText = "Leave Type";
                            dgvHistory.Columns["StartDate"].HeaderText = "Start Date";
                            dgvHistory.Columns["EndDate"].HeaderText = "End Date";
                            dgvHistory.Columns["NumberOfDays"].HeaderText = "Days";
                            dgvHistory.Columns["Status"].HeaderText = "Status";
                            dgvHistory.Columns["RequestedOn"].HeaderText = "Requested On";
                            dgvHistory.Columns["DecisionDate"].HeaderText = "Decision Date";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave history: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLeaveHistory();
        }
    }
}
