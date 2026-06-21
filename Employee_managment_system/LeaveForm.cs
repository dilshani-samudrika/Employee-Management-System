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
            SetupActionButtons();
        }

        // ============ LOAD PENDING LEAVE REQUESTS ============
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
                    l.Reason,
                    l.ApprovalStatus AS 'Status'
                FROM LeaveRequests l
                INNER JOIN Employees e ON l.EmpNo = e.EmpNo
                WHERE l.ApprovalStatus = 'Pending'
                ORDER BY l.AppliedDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvPending.DataSource = dt;

                // Hide LeaveID column
                if (dgvPending.Columns["LeaveID"] != null)
                    dgvPending.Columns["LeaveID"].Visible = false;

                dgvPending.AutoResizeColumns();

                // Set Status column to auto-size
                if (dgvPending.Columns["Status"] != null)
                {
                    dgvPending.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ LOAD LEAVE HISTORY ============
        private void LoadLeaveHistory()
        {
            try
            {
                string query = @"SELECT 
                    e.FullName AS 'Employee Name',
                    l.LeaveType AS 'Leave Type',
                    l.FromDate AS 'From',
                    l.ToDate AS 'To',
                    l.ApprovalStatus AS 'Status'
                FROM LeaveRequests l
                INNER JOIN Employees e ON l.EmpNo = e.EmpNo
                WHERE l.ApprovalStatus IN ('Approved', 'Rejected')
                ORDER BY l.AppliedDate DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvHistory.DataSource = dt;
                dgvHistory.AutoResizeColumns();

                // Set Status column to auto-size
                if (dgvHistory.Columns["Status"] != null)
                {
                    dgvHistory.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ LOAD LEAVE COUNTS (Dashboard Stats) ============
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

                // Today's Leave Count
                string todayQuery = @"SELECT COUNT(*) FROM LeaveRequests 
                                    WHERE ApprovalStatus = 'Approved' 
                                    AND @Today BETWEEN FromDate AND ToDate";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Today", DateTime.Today)
                };
                object todayCount = DatabaseHelper.ExecuteScalar(todayQuery, parameters);
                lblTodayLeaveCount.Text = todayCount?.ToString() ?? "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading counts: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ SETUP ACTION BUTTONS IN DATAGRIDVIEW ============
        private void SetupActionButtons()
        {
            dgvPending.CellClick += dgvPending_CellClick;
            dgvPending.CellFormatting += dgvPending_CellFormatting;
            dgvHistory.CellFormatting += dgvHistory_CellFormatting;
        }

        // ============ FORMAT STATUS COLUMN IN PENDING DATAGRIDVIEW ============
        private void dgvPending_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format Action column
            if (dgvPending.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                string status = dgvPending.Rows[e.RowIndex].Cells["Status"]?.Value?.ToString() ?? "";
                if (status == "Pending")
                {
                    e.Value = "✅ Approve | ❌ Reject";
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else
                {
                    e.Value = "✓ " + status;
                    e.CellStyle.ForeColor = status == "Approved" ? Color.Green : Color.Red;
                }
            }

            // Format Status column with colors
            if (dgvPending.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                string status = e.Value?.ToString() ?? "";
                if (status == "Approved")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        // ============ FORMAT STATUS COLUMN IN HISTORY DATAGRIDVIEW ============
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
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        // ============ HANDLE ACTION CLICK (Approve/Reject) ============
        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPending.Columns[e.ColumnIndex].Name == "Action")
            {
                string status = dgvPending.Rows[e.RowIndex].Cells["Status"]?.Value?.ToString() ?? "";
                if (status == "Pending")
                {
                    DialogResult result = MessageBox.Show(
                        "Click YES to APPROVE or NO to REJECT this leave request.",
                        "Leave Approval",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        UpdateLeaveStatus(e.RowIndex, "Approved");
                    }
                    else
                    {
                        UpdateLeaveStatus(e.RowIndex, "Rejected");
                    }
                }
            }
        }

        // ============ UPDATE LEAVE STATUS IN DATABASE ============
        private void UpdateLeaveStatus(int rowIndex, string newStatus)
        {
            try
            {
                int leaveId = Convert.ToInt32(dgvPending.Rows[rowIndex].Cells["LeaveID"].Value);

                string query = @"UPDATE LeaveRequests 
                               SET ApprovalStatus = @Status, 
                                   ApprovedBy = 1,  -- Assuming UserID 1 is admin
                                   AppliedDate = GETDATE()
                               WHERE LeaveID = @LeaveID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@LeaveID", leaveId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Leave {newStatus} successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh all data
                    LoadLeaveData();
                    LoadLeaveCounts();
                    LoadLeaveHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ NAVIGATION - DASHBOARD ============
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard feature coming soon!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - EMPLOYEES ============
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employees feature coming soon!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - DEPARTMENT ============
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Department feature coming soon!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - ATTENDANCE ============
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Open Attendance Form (Form2)
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.Show();
            this.Hide(); // Hide current form
        }

        // ============ NAVIGATION - LEAVE (Current) ============
        private void btnLeave_Click(object sender, EventArgs e)
        {
            // Already on Leave Management page, just refresh data
            LoadLeaveData();
            LoadLeaveCounts();
            LoadLeaveHistory();
            MessageBox.Show("Leave data refreshed!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - PAYROLL ============
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payroll feature coming soon!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - REPORTS ============
        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports feature coming soon!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - LOGOUT ============
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close current form
                Application.Exit(); // Exit application
            }
        }

        // ============ PANEL PAINT EVENT (Optional) ============
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom painting
        }
    }
}