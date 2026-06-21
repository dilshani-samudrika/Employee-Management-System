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
                // TOTAL EMPLOYEES
                string empQuery = "SELECT COUNT(*) FROM Employees";
                object empResult = DatabaseHelper.ExecuteScalar(empQuery);
                int totalEmployees = empResult != null ? Convert.ToInt32(empResult) : 0;

                //  TOTAL DEPARTMENTS 
                string deptQuery = "SELECT COUNT(*) FROM Departments";
                object deptResult = DatabaseHelper.ExecuteScalar(deptQuery);
                lblCardCount2.Text = deptResult?.ToString() ?? "0";

                //  TOTAL DESIGNATIONS 
                string desigQuery = "SELECT COUNT(*) FROM Designations";
                object desigResult = DatabaseHelper.ExecuteScalar(desigQuery);
                lblCardCount3.Text = desigResult?.ToString() ?? "0";

                // ACTIVE EMPLOYEES 
                string activeQuery = "SELECT COUNT(*) FROM Employees WHERE Status = 'Active'";
                object activeResult = DatabaseHelper.ExecuteScalar(activeQuery);
                int activeEmployees = activeResult != null ? Convert.ToInt32(activeResult) : 0;

                // TODAY'S ATTENDANCE 
                string todayQuery = @"
                    SELECT COUNT(*) 
                    FROM Attendance 
                    WHERE AttendDate = CAST(GETDATE() AS DATE) 
                    AND Status IN ('Present', 'Late', 'Half Day')";
                object todayResult = DatabaseHelper.ExecuteScalar(todayQuery);
                int todayCount = todayResult != null ? Convert.ToInt32(todayResult) : 0;
                lblCardCount5.Text = todayCount.ToString();

                // Attendance percentage
                int totalEmployeesForAtt = totalEmployees > 0 ? totalEmployees : 1;
                int percent = (todayCount * 100) / totalEmployeesForAtt;
                lblAttendancePercent.Text = $"{percent}% today";
                lblAttendancePercent.ForeColor = percent >= 80 ? Color.Green : percent >= 50 ? Color.Orange : Color.Red;

                // MONTHLY PAYROLL 
                string payrollQuery = @"
                    SELECT ISNULL(SUM(NetSalary), 0) 
                    FROM Payroll 
                    WHERE PayMonth = MONTH(GETDATE()) 
                    AND PayYear = YEAR(GETDATE())
                    AND Status = 'Paid'";
                object payrollResult = DatabaseHelper.ExecuteScalar(payrollQuery);
                decimal monthlyPayroll = payrollResult != null ? Convert.ToDecimal(payrollResult) : 0;
                lblCardCount7.Text = $"LKR {monthlyPayroll:N0}";

                // Payroll trend
                string lastMonthQuery = @"
                    SELECT ISNULL(SUM(NetSalary), 0) 
                    FROM Payroll 
                    WHERE PayMonth = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                    AND PayYear = YEAR(DATEADD(MONTH, -1, GETDATE()))
                    AND Status = 'Paid'";
                object lastMonthResult = DatabaseHelper.ExecuteScalar(lastMonthQuery);
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

                // ACTIVE / TOTAL EMPLOYEE BALANCE 
                lblCardCount8.Text = $"{activeEmployees} / {totalEmployees}";

                // WEEKLY ATTENDANCE TREND 
                LoadWeeklyAttendance();
            }
            catch (Exception)
            {
                // Handle exceptions - show zeros
                lblCardCount2.Text = "0";
                lblCardCount3.Text = "0";
                lblCardCount5.Text = "0";
                lblCardCount7.Text = "LKR 0";
                lblCardCount8.Text = "0 / 0";
                lblAttendancePercent.Text = "0% today";
                lblPayrollTrend.Text = "No data";
            }
        }

        private void LoadWeeklyAttendance()
        {
            try
            {
                // Get last 7 days including today
                string query = @"
                    SELECT 
                        DATENAME(WEEKDAY, AttendDate) AS DayName,
                        COUNT(*) AS Count
                    FROM Attendance
                    WHERE AttendDate >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE))
                    AND AttendDate <= CAST(GETDATE() AS DATE)
                    AND Status IN ('Present', 'Late', 'Half Day')
                    GROUP BY DATENAME(WEEKDAY, AttendDate), DATEPART(WEEKDAY, AttendDate)
                    ORDER BY DATEPART(WEEKDAY, AttendDate)";

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
                    string day = row["DayName"].ToString().Substring(0, 3);
                    string count = row["Count"].ToString();

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
            catch (Exception)
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
            try
            {
                EmployeeForm empForm = new EmployeeForm();
                empForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Employee form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceForm attForm = new AttendanceForm();
                attForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Attendance form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickApproveLeave_Click(object sender, EventArgs e)
        {
            try
            {
                LeaveForm leaveForm = new LeaveForm();
                leaveForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Leave form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickPayroll_Click(object sender, EventArgs e)
        {
            try
            {
                PayrollForm payrollForm = new PayrollForm();
                payrollForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Payroll form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickReports_Click(object sender, EventArgs e)
        {
            try
            {
                reports reportForm = new reports();
                reportForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Reports form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            AttendanceForm attForm = new AttendanceForm();
            attForm.Show();
            this.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.Show();
            this.Hide();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm payrollForm = new PayrollForm();
            payrollForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            reports reportForm = new reports();
            reportForm.Show();
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
            try
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

                // Verify current password first
                string verifyQuery = @"
                    SELECT COUNT(*) FROM Users 
                    WHERE Username = 'admin' AND Password = @CurrentPassword";

                SqlParameter[] verifyParams = {
                    new SqlParameter("@CurrentPassword", currentPassword)
                };

                object verifyResult = DatabaseHelper.ExecuteScalar(verifyQuery, verifyParams);
                int userCount = verifyResult != null ? Convert.ToInt32(verifyResult) : 0;

                if (userCount == 0)
                {
                    MessageBox.Show("Current password is incorrect!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update password
                string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Username = 'admin'";
                SqlParameter[] updateParams = {
                    new SqlParameter("@NewPassword", newPassword)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully!",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                try
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during logout: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lblCardCount7_Click(object sender, EventArgs e)
        {

        }

        private void lblCardCount5_Click(object sender, EventArgs e)
        {

        }
    }
}