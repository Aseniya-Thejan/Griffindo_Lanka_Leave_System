using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmRemainingLeaves : Form
    {
        private int employeeId;

        public FrmRemainingLeaves(int employeeId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.employeeId = employeeId;
        }

        private void FrmRemainingLeaves_Load(object sender, EventArgs e)
        {
            LoadRemainingLeaves();
        }

        private void LoadRemainingLeaves()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT LT.LeaveName,
                                          LT.MaxDaysPerYear,
                                          ISNULL(SUM(AL.NumberOfDays), 0) AS TakenDays,
                                          (LT.MaxDaysPerYear - ISNULL(SUM(AL.NumberOfDays), 0)) AS RemainingDays
                                   FROM LeaveTypes LT
                                   LEFT JOIN AppliedLeaves AL
                                        ON LT.LeaveTypeID = AL.LeaveTypeID
                                       AND AL.EmployeeID = @empId
                                       AND AL.Status = 'Approved'
                                   GROUP BY LT.LeaveName, LT.MaxDaysPerYear
                                   ORDER BY LT.LeaveName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", employeeId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvBalances.DataSource = dt;
                        dgvBalances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvBalances.ReadOnly = true;
                        dgvBalances.AllowUserToAddRows = false;
                        dgvBalances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (dgvBalances.Columns.Count > 0)
                        {
                            dgvBalances.Columns["LeaveName"].HeaderText = "Leave Type";
                            dgvBalances.Columns["MaxDaysPerYear"].HeaderText = "Max Days/Year";
                            dgvBalances.Columns["TakenDays"].HeaderText = "Taken Days";
                            dgvBalances.Columns["RemainingDays"].HeaderText = "Remaining Days";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading remaining leaves: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
