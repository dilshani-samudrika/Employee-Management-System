using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardStats();
            WireUpMenuEvents();
            HighlightActiveButton(btnDashboard);
        }

        private void LoadDashboardStats()
        {
            try
            {
                // 1. Total Employees
                string empQuery = "SELECT COUNT(*) FROM Employees";
                object empResult = DatabaseHelper.ExecuteScalar(empQuery);
                int totalEmployees = empResult != null ? Convert.ToInt32(empResult) : 0;
                lblCardCount1.Text = totalEmployees.ToString();

                // 2. Total Departments
                string deptQuery = "SELECT COUNT(*) FROM Departments";
                object deptResult = DatabaseHelper.ExecuteScalar(deptQuery);
                lblCardCount2.Text = deptResult?.ToString() ?? "0";

                // 3. Total Designations
                string desigQuery = "SELECT COUNT(*) FROM Designations";
                object desigResult = DatabaseHelper.ExecuteScalar(desigQuery);
                lblCardCount3.Text = desigResult?.ToString() ?? "0";

                // 4. Active Employees
                string activeQuery = "SELECT COUNT(*) FROM Employees WHERE Status = 'Active'";
                object activeResult = DatabaseHelper.ExecuteScalar(activeQuery);
                int activeEmployees = activeResult != null ? Convert.ToInt32(activeResult) : 0;
                lblCardCount4.Text = activeEmployees.ToString();

                // 5. Today's Attendance
                string todayQuery = "SELECT COUNT(*) FROM Attendance WHERE AttendDate = CAST(GETDATE() AS DATE)";
                object todayResult = DatabaseHelper.ExecuteScalar(todayQuery);
                lblCardCount5.Text = todayResult?.ToString() ?? "0";

                // 6. Pending Leave Requests
                string pendingLeaveQuery = "SELECT COUNT(*) FROM LeaveRequests WHERE ApprovalStatus = 'Pending'";
                object pendingResult = DatabaseHelper.ExecuteScalar(pendingLeaveQuery);
                lblCardCount6.Text = pendingResult?.ToString() ?? "0";

                // 7. Monthly Payroll
                string payrollQuery = @"
                    SELECT ISNULL(SUM(NetSalary), 0) 
                    FROM Payroll 
                    WHERE PayMonth = MONTH(GETDATE()) AND PayYear = YEAR(GETDATE())";
                object payrollResult = DatabaseHelper.ExecuteScalar(payrollQuery);
                decimal monthlyPayroll = payrollResult != null ? Convert.ToDecimal(payrollResult) : 0;
                lblCardCount7.Text = $"LKR {monthlyPayroll:N0}";

                // 8. Active / Total Employee Balance
                lblCardCount8.Text = $"{activeEmployees} / {totalEmployees}";
            }
            catch
            {
                lblCardCount1.Text = "0";
                lblCardCount2.Text = "0";
                lblCardCount3.Text = "0";
                lblCardCount4.Text = "0";
                lblCardCount5.Text = "0";
                lblCardCount6.Text = "0";
                lblCardCount7.Text = "LKR 0";
                lblCardCount8.Text = "0 / 0";
            }
        }

        private void WireUpMenuEvents()
        {
            btnDashboard.Click += BtnDashboard_Click;
            btnEmployees.Click += BtnEmployees_Click;
            btnDepartment.Click += BtnDepartment_Click;
            btnAttendance.Click += BtnAttendance_Click;
            btnLeave.Click += BtnLeave_Click;
            btnPayroll.Click += BtnPayroll_Click;
            btnReports.Click += BtnReports_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void HighlightActiveButton(Button activeBtn)
        {
            // Reset all buttons
            Button[] buttons = { btnDashboard, btnEmployees, btnDepartment, btnAttendance, btnLeave, btnPayroll, btnReports, btnLogout };
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.FromArgb(25, 48, 78);
                btn.ForeColor = Color.FromArgb(200, 200, 200);
                btn.Font = new Font("Segoe UI", 10F);
            }

            // Highlight active
            activeBtn.BackColor = Color.FromArgb(52, 152, 219);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        // ============================================
        // MENU NAVIGATION
        // ============================================
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDashboard);
            lblPageTitle.Text = "Dashboard";
            LoadDashboardStats();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnEmployees);
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            Hide();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDepartment);
            DepartmentForm deptForm = new DepartmentForm();
            deptForm.Show();
            Hide();
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnAttendance);
            lblPageTitle.Text = "Attendance";
            AttendanceForm attForm = new AttendanceForm();
            attForm.Show();
            Hide();
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnLeave);
            lblPageTitle.Text = "Leave Management";
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.Show();
            Hide();
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnPayroll);
            lblPageTitle.Text = "Payroll";
            PayrollForm payrollForm = new PayrollForm();
            payrollForm.Show();
            Hide();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnReports);
            lblPageTitle.Text = "Reports";
            reports reportForm = new reports();
            reportForm.Show();
            Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                Close();
            }
        }
    }
}