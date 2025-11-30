using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmManageLeaveTypes : Form
    {
        private DataTable dtLeaveTypes;

        public FrmManageLeaveTypes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FrmManageLeaveTypes_Load(object sender, EventArgs e)
        {
            LoadLeaveTypes();
        }

        private void LoadLeaveTypes()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT LeaveTypeID, LeaveName, MaxDaysPerYear, IsPaid FROM LeaveTypes ORDER BY LeaveName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dtLeaveTypes = new DataTable();
                        adapter.Fill(dtLeaveTypes);

                        dgvLeaveTypes.DataSource = dtLeaveTypes;
                        dgvLeaveTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvLeaveTypes.AllowUserToAddRows = false;
                        dgvLeaveTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (dgvLeaveTypes.Columns.Count > 0)
                        {
                            dgvLeaveTypes.Columns["LeaveTypeID"].ReadOnly = true;
                            dgvLeaveTypes.Columns["LeaveName"].ReadOnly = true;
                            dgvLeaveTypes.Columns["MaxDaysPerYear"].ReadOnly = false;
                            dgvLeaveTypes.Columns["IsPaid"].ReadOnly = false;

                            dgvLeaveTypes.Columns["LeaveTypeID"].HeaderText = "Leave Type ID";
                            dgvLeaveTypes.Columns["LeaveName"].HeaderText = "Leave Name";
                            dgvLeaveTypes.Columns["MaxDaysPerYear"].HeaderText = "Max Days/Year";
                            dgvLeaveTypes.Columns["IsPaid"].HeaderText = "Is Paid";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave types: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    foreach (DataRow row in dtLeaveTypes.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string query = @"UPDATE LeaveTypes
                                           SET MaxDaysPerYear = @maxDays,
                                               IsPaid = @isPaid
                                           WHERE LeaveTypeID = @id";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@maxDays", row["MaxDaysPerYear"]);
                                cmd.Parameters.AddWithValue("@isPaid", row["IsPaid"]);
                                cmd.Parameters.AddWithValue("@id", row["LeaveTypeID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    dtLeaveTypes.AcceptChanges();
                    MessageBox.Show("Leave types updated successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
