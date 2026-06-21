using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_managment_system
{

    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                //  Total Employees
                string empQuery = "SELECT COUNT(*) FROM Employees";
                object? empResult = DatabaseHelper.ExecuteScalar(empQuery);
                int totalEmployees = empResult != null ? Convert.ToInt32(empResult) : 0;

                //  Total Departments
                string deptQuery = "SELECT COUNT(*) FROM Departments";
                object? deptResult = DatabaseHelper.ExecuteScalar(deptQuery);
                lblCardCount2.Text = deptResult?.ToString() ?? "0";

                //  Total Designations
                string desigQuery = "SELECT COUNT(*) FROM Designations";
                object? desigResult = DatabaseHelper.ExecuteScalar(desigQuery);
                lblCardCount3.Text = desigResult?.ToString() ?? "0";

                //  Today's Attendance
                string todayQuery = "SELECT COUNT(*) FROM Attendance WHERE AttendDate = CAST(GETDATE() AS DATE)";
                object? todayResult = DatabaseHelper.ExecuteScalar(todayQuery);
                int todayCount = todayResult != null ? Convert.ToInt32(todayResult) : 0;
                lblCardCount5.Text = todayCount.ToString();

                // Attendance percentage
                int totalEmployeesForAtt = totalEmployees > 0 ? totalEmployees : 1;
                int percent = (todayCount * 100) / totalEmployeesForAtt;
                lblAttendancePercent.Text = $"{percent}% today";
                lblAttendancePercent.ForeColor = percent >= 80 ? Color.Green : percent >= 50 ? Color.Orange : Color.Red;

                // Pending Leave Requests
                string pendingLeaveQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Pending'";
                object? pendingResult = DatabaseHelper.ExecuteScalar(pendingLeaveQuery);

                // Monthly Payroll
                string payrollQuery = @"
            SELECT ISNULL(SUM(NetSalary), 0) 
            FROM Payroll 
            WHERE PayMonth = MONTH(GETDATE()) AND PayYear = YEAR(GETDATE())";
                object? payrollResult = DatabaseHelper.ExecuteScalar(payrollQuery);
                decimal monthlyPayroll = payrollResult != null ? Convert.ToDecimal(payrollResult) : 0;
                lblCardCount7.Text = $"LKR {monthlyPayroll:N0}";

                // Payroll trend
                string lastMonthQuery = @"
            SELECT ISNULL(SUM(NetSalary), 0) 
            FROM Payroll 
            WHERE PayMonth = MONTH(DATEADD(MONTH, -1, GETDATE())) 
            AND PayYear = YEAR(DATEADD(MONTH, -1, GETDATE()))";
                object? lastMonthResult = DatabaseHelper.ExecuteScalar(lastMonthQuery);
                decimal lastMonthPayroll = lastMonthResult != null ? Convert.ToDecimal(lastMonthResult) : 0;

                if (lastMonthPayroll > 0)
                {
                    decimal change = ((monthlyPayroll - lastMonthPayroll) / lastMonthPayroll) * 100;
                    if (change > 0)
                    {
                        lblPayrollTrend.Text = $"▲ +{change:F1}%";
                        lblPayrollTrend.ForeColor = Color.Green;
                    }
                    else if (change < 0)
                    {
                        lblPayrollTrend.Text = $"▼ {change:F1}%";
                        lblPayrollTrend.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblPayrollTrend.Text = "━ 0%";
                        lblPayrollTrend.ForeColor = Color.Gray;
                    }
                }
                else
                {
                    lblPayrollTrend.Text = "First month";
                    lblPayrollTrend.ForeColor = Color.Gray;
                }

                // Active / Total Employee Balance
                int activeEmployees = 0;
                string activeQuery = "SELECT COUNT(*) FROM Employees WHERE Status = 'Active'";
                object? activeResult = DatabaseHelper.ExecuteScalar(activeQuery);
                activeEmployees = activeResult != null ? Convert.ToInt32(activeResult) : 0;
                lblCardCount8.Text = $"{activeEmployees} / {totalEmployees}";

                //  Weekly Attendance
                LoadWeeklyAttendance();
            }
            catch
            {
                // Handle exceptions silently
                lblCardCount2.Text = "0";
                lblCardCount3.Text = "0";
                lblCardCount5.Text = "0";
                lblCardCount7.Text = "LKR 0";
                lblCardCount8.Text = "0 / 0";
                lblAttendancePercent.Text = "0% today";
            }
        }
        private void LoadWeeklyAttendance()
        {
            try
            {
                string query = @"
            SELECT 
                DATENAME(WEEKDAY, AttendDate) AS DayName,
                COUNT(*) AS Count
            FROM Attendance
            WHERE AttendDate >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE))
            AND AttendDate <= CAST(GETDATE() AS DATE)
            GROUP BY DATENAME(WEEKDAY, AttendDate)
            ORDER BY AttendDate";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                // Reset all counts
                lblMonCount.Text = "0";
                lblTueCount.Text = "0";
                lblWedCount.Text = "0";
                lblThuCount.Text = "0";
                lblFriCount.Text = "0";
                lblSatCount.Text = "0";
                lblSunCount.Text = "0";

                // Update with actual data
                foreach (DataRow row in dt.Rows)
                {
                    string day = row["DayName"].ToString()!.Substring(0, 3);
                    string count = row["Count"].ToString()!;

                    switch (day)
                    {
                        case "Mon": lblMonCount.Text = count; break;
                        case "Tue": lblTueCount.Text = count; break;
                        case "Wed": lblWedCount.Text = count; break;
                        case "Thu": lblThuCount.Text = count; break;
                        case "Fri": lblFriCount.Text = count; break;
                        case "Sat": lblSatCount.Text = count; break;
                        case "Sun": lblSunCount.Text = count; break;
                    }
                }
            }
            catch
            {
                // If attendance table doesn't exist, show zeros
                lblMonCount.Text = "0";
                lblTueCount.Text = "0";
                lblWedCount.Text = "0";
                lblThuCount.Text = "0";
                lblFriCount.Text = "0";
                lblSatCount.Text = "0";
                lblSunCount.Text = "0";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();

        }

        private void btnQuickAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickAttendance_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickApproveLeave_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickPayroll_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickReports_Click(object sender, EventArgs e)
        {

        }


        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentForm deptForm = new DepartmentForm();
            deptForm.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm att = new AttendanceForm();
            att.Show();
            this.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveForm leave = new LeaveForm();
            leave.Show();
            this.Hide();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm payroll = new PayrollForm();
            payroll.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            reports report = new reports();
            report.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void ChangePassword()
        {
            string currentPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Current Password:",
                "Change Password - Verify Identity",
                "",
                -1, -1);

            if (string.IsNullOrEmpty(currentPassword))
                return;

            string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter New Password (min 6 characters):",
                "Change Password",
                "",
                -1, -1);

            if (string.IsNullOrEmpty(newPassword))
                return;

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string confirmPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Confirm New Password:",
                "Change Password",
                "",
                -1, -1);

            if (string.IsNullOrEmpty(confirmPassword))
                return;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Direct password update in database (without AuthService)
            try
            {
                string updateQuery = "UPDATE Users SET PasswordHash = @PasswordHash WHERE Username = @Username";
                SqlParameter[] parameters = {
            new SqlParameter("@Username", "admin"),
            new SqlParameter("@PasswordHash", newPassword)
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully! Please login again.",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password change failed. Please try again.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing password: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                        "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();

            }

        }
    }
}