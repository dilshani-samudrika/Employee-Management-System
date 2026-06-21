using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Test database connection first
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Cannot connect to database. Please check your connection settings.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadLeaveData();
            LoadLeaveCounts();
            LoadLeaveHistory();
        }

        // LOAD PENDING LEAVE REQUESTS 
        private void LoadLeaveData()
        {
            try
            {
                string query = @"SELECT 
                    l.LeaveID,
                    e.FullName AS 'Employee Name',
                    l.LeaveType AS 'Leave Type',
                    l.FromDate AS 'From',
                    l.ToDate AS 'To',
                    l.TotalDays AS 'Days',
                    l.Reason,
                    l.ApprovalStatus AS 'Status',
                    CONVERT(VARCHAR, l.AppliedDate, 103) AS 'Applied Date'
                FROM LeaveRequests l
                INNER JOIN Employees e ON l.EmpNo = e.EmpNo
                WHERE l.ApprovalStatus = 'Pending'
                ORDER BY l.AppliedDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvPending.DataSource = dt;

                // Hide LeaveID column
                if (dgvPending.Columns["LeaveID"] != null)
                    dgvPending.Columns["LeaveID"].Visible = false;

                // Add Action column if it doesn't exist
                if (!dgvPending.Columns.Contains("Action"))
                {
                    DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
                    actionColumn.Name = "Action";
                    actionColumn.HeaderText = "Action";
                    actionColumn.Text = "Approve/Reject";
                    actionColumn.UseColumnTextForButtonValue = false;
                    dgvPending.Columns.Add(actionColumn);
                }

                dgvPending.AutoResizeColumns();

                // Set column widths
                if (dgvPending.Columns["Employee Name"] != null)
                    dgvPending.Columns["Employee Name"].Width = 150;
                if (dgvPending.Columns["Leave Type"] != null)
                    dgvPending.Columns["Leave Type"].Width = 100;
                if (dgvPending.Columns["Days"] != null)
                    dgvPending.Columns["Days"].Width = 60;
                if (dgvPending.Columns["Status"] != null)
                    dgvPending.Columns["Status"].Width = 100;
                if (dgvPending.Columns["Action"] != null)
                    dgvPending.Columns["Action"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LOAD LEAVE HISTORY 
        private void LoadLeaveHistory()
        {
            try
            {
                string query = @"SELECT 
                    e.FullName AS 'Employee Name',
                    l.LeaveType AS 'Leave Type',
                    l.FromDate AS 'From',
                    l.ToDate AS 'To',
                    l.TotalDays AS 'Days',
                    l.ApprovalStatus AS 'Status',
                    CONVERT(VARCHAR, l.AppliedDate, 103) AS 'Applied Date'
                FROM LeaveRequests l
                INNER JOIN Employees e ON l.EmpNo = e.EmpNo
                WHERE l.ApprovalStatus IN ('Approved', 'Rejected')
                ORDER BY l.AppliedDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvHistory.DataSource = dt;
                dgvHistory.AutoResizeColumns();

                // Set column widths
                if (dgvHistory.Columns["Employee Name"] != null)
                    dgvHistory.Columns["Employee Name"].Width = 150;
                if (dgvHistory.Columns["Leave Type"] != null)
                    dgvHistory.Columns["Leave Type"].Width = 100;
                if (dgvHistory.Columns["Days"] != null)
                    dgvHistory.Columns["Days"].Width = 60;
                if (dgvHistory.Columns["Status"] != null)
                    dgvHistory.Columns["Status"].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  LOAD LEAVE COUNTS (Dashboard Stats) 
        private void LoadLeaveCounts()
        {
            try
            {
                // Pending Count
                string pendingQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Pending'";
                object pendingCount = DatabaseHelper.ExecuteScalar(pendingQuery);
                lblPendingCount.Text = pendingCount?.ToString() ?? "0";

                // Approved Count
                string approvedQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Approved'";
                object approvedCount = DatabaseHelper.ExecuteScalar(approvedQuery);
                lblApprovedCount.Text = approvedCount?.ToString() ?? "0";

                // Rejected Count
                string rejectedQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Rejected'";
                object rejectedCount = DatabaseHelper.ExecuteScalar(rejectedQuery);
                lblRejectedCount.Text = rejectedCount?.ToString() ?? "0";

                // Today's Leave Count (employees on leave today)
                string todayQuery = @"SELECT COUNT(*) FROM LeaveRequests 
                                    WHERE ApprovalStatus = 'Approved' 
                                    AND CAST(GETDATE() AS DATE) BETWEEN FromDate AND ToDate";
                object todayCount = DatabaseHelper.ExecuteScalar(todayQuery);
                lblTodayLeaveCount.Text = todayCount?.ToString() ?? "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading counts: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  FORMAT STATUS COLUMN IN PENDING DATAGRIDVIEW 
        private void dgvPending_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format Status column with colors
            if (dgvPending.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                string status = e.Value?.ToString() ?? "";
                if (status == "Approved")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "✓ Approved";
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "✗ Rejected";
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "⏳ Pending";
                }
            }

            // Format Action column with buttons
            if (dgvPending.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                string status = dgvPending.Rows[e.RowIndex].Cells["Status"]?.Value?.ToString() ?? "";
                if (status.Contains("Pending"))
                {
                    e.Value = "Approve / Reject";
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else
                {
                    e.Value = "Completed";
                    e.CellStyle.ForeColor = Color.Gray;
                }
            }

            // Format Days column
            if (dgvPending.Columns[e.ColumnIndex].Name == "Days" && e.RowIndex >= 0)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int days = Convert.ToInt32(e.Value);
                    if (days > 5)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            }
        }

        //  FORMAT STATUS COLUMN IN HISTORY DATAGRIDVIEW 
        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format Status column with colors in history grid
            if (dgvHistory.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                string status = e.Value?.ToString() ?? "";
                if (status == "Approved")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "✓ Approved";
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "✗ Rejected";
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.Value = "⏳ " + status;
                }
            }

            // Format Days column
            if (dgvHistory.Columns[e.ColumnIndex].Name == "Days" && e.RowIndex >= 0)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int days = Convert.ToInt32(e.Value);
                    if (days > 5)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            }
        }

        //  UPDATE LEAVE STATUS IN DATABASE 
        private void UpdateLeaveStatus(int rowIndex, string newStatus)
        {
            try
            {
                int leaveId = Convert.ToInt32(dgvPending.Rows[rowIndex].Cells["LeaveID"].Value);
                string employeeName = dgvPending.Rows[rowIndex].Cells["Employee Name"].Value?.ToString() ?? "Unknown";

                // Confirm action
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to {newStatus} leave request for {employeeName}?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                string query = @"UPDATE LeaveRequests 
                               SET ApprovalStatus = @Status
                               WHERE LeaveID = @LeaveID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@LeaveID", leaveId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Leave {newStatus} successfully for {employeeName}!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Refresh all data
                    LoadLeaveData();
                    LoadLeaveCounts();
                    LoadLeaveHistory();

                    // Check if all leaves are processed
                    CheckAllProcessed();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating leave status: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //  CHECK IF ALL PENDING LEAVES ARE PROCESSED 
        private void CheckAllProcessed()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Pending'";
                object pendingCount = DatabaseHelper.ExecuteScalar(query);
                int count = pendingCount != null ? Convert.ToInt32(pendingCount) : 0;

                if (count == 0)
                {
                    MessageBox.Show("🎉 All pending leave requests have been processed!",
                        "Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void RefreshData()
        {
            LoadLeaveData();
            LoadLeaveCounts();
            LoadLeaveHistory();
        }

        //  FILTER LEAVE REQUESTS 
        private void FilterLeaveData(string filter)
        {
            try
            {
                string whereClause = "";
                if (filter != "All")
                    whereClause = $"WHERE l.ApprovalStatus = '{filter.Replace(" ", "")}'";
                else
                    whereClause = "WHERE l.ApprovalStatus IN ('Pending', 'Approved', 'Rejected')";

                string query = $@"SELECT 
                    l.LeaveID,
                    e.FullName AS 'Employee Name',
                    l.LeaveType AS 'Leave Type',
                    l.FromDate AS 'From',
                    l.ToDate AS 'To',
                    l.TotalDays AS 'Days',
                    l.ApprovalStatus AS 'Status',
                    CONVERT(VARCHAR, l.AppliedDate, 103) AS 'Applied Date'
                FROM LeaveRequests l
                INNER JOIN Employees e ON l.EmpNo = e.EmpNo
                {whereClause}
                ORDER BY l.AppliedDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvPending.DataSource = dt;

                if (dgvPending.Columns["LeaveID"] != null)
                    dgvPending.Columns["LeaveID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  FORM NAVIGATION EVENTS 
        private void btnAttendance_Click_1(object sender, EventArgs e)
        {
            AttendanceForm att = new AttendanceForm();
            att.Show();
            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void btnDepartment_Click_1(object sender, EventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.Show();
            this.Hide();
        }

        private void btnPayroll_Click_1(object sender, EventArgs e)
        {
            PayrollForm payroll = new PayrollForm();
            payroll.Show();
            this.Hide();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            reports report = new reports();
            report.Show();
            this.Hide();
        }

        //  DATAGRIDVIEW CELL CLICK EVENT 
        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the Action column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dgvPending.Columns[e.ColumnIndex].Name == "Action")
            {
                string status = dgvPending.Rows[e.RowIndex].Cells["Status"]?.Value?.ToString() ?? "";
                if (status.Contains("Pending"))
                {
                    // Create custom dialog for approve/reject
                    DialogResult result = MessageBox.Show(
                        "Select action for this leave request:\n\n" +
                        "Click YES to APPROVE\n" +
                        "Click NO to REJECT",
                        "Leave Approval",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        UpdateLeaveStatus(e.RowIndex, "Approved");
                    }
                    else if (result == DialogResult.No)
                    {
                        UpdateLeaveStatus(e.RowIndex, "Rejected");
                    }
                    // If Cancel, do nothing
                }
                else
                {
                    MessageBox.Show("This leave request has already been processed.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        //  MOUSE CLICK FOR CONTEXT MENU 
        private void dgvPending_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("✅ Approve", null, (s, ev) =>
                {
                    int rowIndex = dgvPending.CurrentCell?.RowIndex ?? -1;
                    if (rowIndex >= 0) UpdateLeaveStatus(rowIndex, "Approved");
                });
                contextMenu.Items.Add("❌ Reject", null, (s, ev) =>
                {
                    int rowIndex = dgvPending.CurrentCell?.RowIndex ?? -1;
                    if (rowIndex >= 0) UpdateLeaveStatus(rowIndex, "Rejected");
                });
                contextMenu.Items.Add("-");
                contextMenu.Items.Add("🔄 Refresh", null, (s, ev) => RefreshData());

                contextMenu.Show(dgvPending, e.Location);
            }
        }

        //  FORM CLOSING EVENT 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e) 
        {
        
        }
        private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
        
        }
    }
}