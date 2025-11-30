using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmGenerateReports : Form
    {
        public FrmGenerateReports()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FrmGenerateReports_Load(object sender, EventArgs e)
        {
            LoadEmployeeReport();
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            LoadEmployeeReport();
        }

        private void btnLeaveTypeReport_Click(object sender, EventArgs e)
        {
            LoadLeaveTypeReport();
        }

        private void btnStatusReport_Click(object sender, EventArgs e)
        {
            LoadStatusReport();
        }

        private void LoadEmployeeReport()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT E.FullName,
                                          COUNT(*) AS TotalRequests,
                                          SUM(CASE WHEN AL.Status = 'Approved' THEN 1 ELSE 0 END) AS ApprovedRequests,
                                          SUM(CASE WHEN AL.Status = 'Rejected' THEN 1 ELSE 0 END) AS RejectedRequests,
                                          SUM(CASE WHEN AL.Status = 'Pending' THEN 1 ELSE 0 END) AS PendingRequests
                                   FROM AppliedLeaves AL
                                   INNER JOIN Employee E ON AL.EmployeeID = E.EmployeeID
                                   GROUP BY E.FullName
                                   ORDER BY TotalRequests DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvReports.DataSource = dt;
                        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvReports.ReadOnly = true;
                        dgvReports.AllowUserToAddRows = false;

                        if (dgvReports.Columns.Count > 0)
                        {
                            dgvReports.Columns["FullName"].HeaderText = "Employee Name";
                            dgvReports.Columns["TotalRequests"].HeaderText = "Total Requests";
                            dgvReports.Columns["ApprovedRequests"].HeaderText = "Approved";
                            dgvReports.Columns["RejectedRequests"].HeaderText = "Rejected";
                            dgvReports.Columns["PendingRequests"].HeaderText = "Pending";
                        }

                        lblReportTitle.Text = "Leave Requests by Employee";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee report: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLeaveTypeReport()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT LT.LeaveName,
                                          COUNT(*) AS TotalRequests,
                                          SUM(CASE WHEN AL.Status = 'Approved' THEN 1 ELSE 0 END) AS ApprovedRequests,
                                          SUM(CASE WHEN AL.Status = 'Rejected' THEN 1 ELSE 0 END) AS RejectedRequests,
                                          SUM(CASE WHEN AL.Status = 'Pending' THEN 1 ELSE 0 END) AS PendingRequests
                                   FROM AppliedLeaves AL
                                   INNER JOIN LeaveTypes LT ON AL.LeaveTypeID = LT.LeaveTypeID
                                   GROUP BY LT.LeaveName
                                   ORDER BY TotalRequests DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvReports.DataSource = dt;
                        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvReports.ReadOnly = true;
                        dgvReports.AllowUserToAddRows = false;

                        if (dgvReports.Columns.Count > 0)
                        {
                            dgvReports.Columns["LeaveName"].HeaderText = "Leave Type";
                            dgvReports.Columns["TotalRequests"].HeaderText = "Total Requests";
                            dgvReports.Columns["ApprovedRequests"].HeaderText = "Approved";
                            dgvReports.Columns["RejectedRequests"].HeaderText = "Rejected";
                            dgvReports.Columns["PendingRequests"].HeaderText = "Pending";
                        }

                        lblReportTitle.Text = "Leave Requests by Leave Type";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave type report: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatusReport()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT Status,
                                          COUNT(*) AS Total,
                                          SUM(NumberOfDays) AS TotalDays
                                   FROM AppliedLeaves
                                   GROUP BY Status
                                   ORDER BY Total DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvReports.DataSource = dt;
                        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvReports.ReadOnly = true;
                        dgvReports.AllowUserToAddRows = false;

                        if (dgvReports.Columns.Count > 0)
                        {
                            dgvReports.Columns["Status"].HeaderText = "Status";
                            dgvReports.Columns["Total"].HeaderText = "Total Requests";
                            dgvReports.Columns["TotalDays"].HeaderText = "Total Days";
                        }

                        lblReportTitle.Text = "Leave Requests by Status";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading status report: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
