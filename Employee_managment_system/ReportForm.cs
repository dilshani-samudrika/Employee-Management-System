using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class reports : Form
    {
        private int printRowIndex = 0;

        public reports()
        {
            InitializeComponent();

            // Set default dates
            fromDatePicker.Value = DateTime.Today.AddMonths(-1);
            toDatePicker.Value = DateTime.Today;

            LoadDepartments();
            SetupDefaultReport();
        }

        private void LoadDepartments()
        {
            try
            {
                deptCombo.Items.Clear();
                deptCombo.Items.Add("All");

                string query = "SELECT DeptName FROM Departments ORDER BY DeptName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    deptCombo.Items.Add(row["DeptName"].ToString());
                }

                deptCombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        // SETUP DEFAULT REPORT
       
        private void SetupDefaultReport()
        {
            if (reportTypeCombo.Items.Count > 0)
            {
                reportTypeCombo.SelectedIndex = 0;
            }
            if (formatCombo.Items.Count > 0)
            {
                formatCombo.SelectedIndex = 1;
            }

            previewGrid.Rows.Clear();
            totalRecordsLabel.Text = "Total Records: 0";
            reportSubtitleLabel.Text = "Select a report type and click Generate";
            reportMetaLabel.Text = "Period: — | Generated: —";
            pageInfoLabel.Text = "Page 1 of 1";
        }

        
        // SIDEBAR NAVIGATION
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.Show();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                    "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        
        // REPORT TYPE CHANGE
        
        private void reportTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = reportTypeCombo.SelectedItem?.ToString() ?? "Employee List";
            ConfigureColumns(selected);
            previewGrid.Rows.Clear();
            reportSubtitleLabel.Text = $"{selected} Report";
            totalRecordsLabel.Text = "Total Records: 0";
            reportMetaLabel.Text = "Period: — | Generated: —";
        }

        private void ConfigureColumns(string reportType)
        {
            // Hide all columns first
            colID.Visible = false;
            colName.Visible = false;
            colDepartment.Visible = false;
            colDesignation.Visible = false;
            colJoiningDate.Visible = false;
            colStatus.Visible = false;

            switch (reportType)
            {
                case "Department Summary":
                    colID.Visible = true;
                    colID.HeaderText = "Dept ID";
                    colName.Visible = true;
                    colName.HeaderText = "Department";
                    colDepartment.Visible = true;
                    colDepartment.HeaderText = "Total Employees";
                    colDesignation.Visible = true;
                    colDesignation.HeaderText = "Total Designations";
                    colJoiningDate.Visible = true;
                    colJoiningDate.HeaderText = "Description";
                    break;

                case "Active/Inactive Status":
                    colID.Visible = true;
                    colID.HeaderText = "Emp ID";
                    colName.Visible = true;
                    colName.HeaderText = "Employee Name";
                    colDepartment.Visible = true;
                    colDepartment.HeaderText = "Department";
                    colStatus.Visible = true;
                    colStatus.HeaderText = "Status";
                    break;

                case "Employee List":
                default:
                    colID.Visible = true;
                    colID.HeaderText = "Emp ID";
                    colName.Visible = true;
                    colName.HeaderText = "Employee Name";
                    colDepartment.Visible = true;
                    colDepartment.HeaderText = "Department";
                    colDesignation.Visible = true;
                    colDesignation.HeaderText = "Designation";
                    colJoiningDate.Visible = true;
                    colJoiningDate.HeaderText = "Joining Date";
                    colStatus.Visible = true;
                    colStatus.HeaderText = "Status";
                    break;
            }
        }

        
        // DATE VALIDATION
        
        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDatePicker.Value > toDatePicker.Value)
                toDatePicker.Value = fromDatePicker.Value;
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (toDatePicker.Value < fromDatePicker.Value)
                fromDatePicker.Value = toDatePicker.Value;
        }

        
        // GENERATE REPORT
        
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (reportTypeCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Validation",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerateReport(reportTypeCombo.SelectedItem.ToString());
        }

        private void GenerateReport(string reportType)
        {
            try
            {
                DateTime fromDate = fromDatePicker.Value.Date;
                DateTime toDate = toDatePicker.Value.Date;
                string deptFilter = deptCombo.SelectedItem?.ToString() ?? "All";

                previewGrid.Rows.Clear();
                int recordCount = 0;

                switch (reportType)
                {
                    case "Department Summary":
                        recordCount = LoadDepartmentSummary(fromDate, toDate, deptFilter);
                        break;

                    case "Active/Inactive Status":
                        recordCount = LoadActiveInactiveStatus(fromDate, toDate, deptFilter);
                        break;

                    case "Employee List":
                    default:
                        recordCount = LoadEmployeeList(fromDate, toDate, deptFilter);
                        break;
                }

                reportSubtitleLabel.Text = $"{reportType} Report";
                reportMetaLabel.Text = $"Period: {fromDate:dd-MMM-yyyy} to {toDate:dd-MMM-yyyy} | Generated: {DateTime.Now:dd-MMM-yyyy HH:mm}";
                totalRecordsLabel.Text = $"Total Records: {recordCount}";
                pageInfoLabel.Text = "Page 1 of 1";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       
        private int LoadEmployeeList(DateTime fromDate, DateTime toDate, string deptFilter)
        {
            string query = @"
                SELECT 
                    e.EmpNo, 
                    e.FullName, 
                    ISNULL(dep.DeptName, 'N/A') AS DeptName, 
                    ISNULL(des.Title, 'N/A') AS Designation, 
                    e.JoinedDate, 
                    ISNULL(e.Status, 'Active') AS Status
                FROM Employees e
                LEFT JOIN Departments dep ON e.DeptID = dep.DeptID
                LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
                WHERE (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY e.FullName";

            SqlParameter[] parameters = {
                new SqlParameter("@Dept", deptFilter)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
            {
                previewGrid.Rows.Add("No records found", "", "", "", "", "");
                return 0;
            }

            foreach (DataRow row in dt.Rows)
            {
                string empNo = row["EmpNo"]?.ToString() ?? "";
                string fullName = row["FullName"]?.ToString() ?? "";
                string deptName = row["DeptName"]?.ToString() ?? "N/A";
                string designation = row["Designation"]?.ToString() ?? "N/A";
                string joinedDate = row["JoinedDate"] != DBNull.Value ? Convert.ToDateTime(row["JoinedDate"]).ToString("dd-MMM-yyyy") : "N/A";
                string status = row["Status"]?.ToString() ?? "Active";

                previewGrid.Rows.Add(empNo, fullName, deptName, designation, joinedDate, status);
            }

            return dt.Rows.Count;
        }

        
        // DEPARTMENT SUMMARY REPORT
        
        private int LoadDepartmentSummary(DateTime fromDate, DateTime toDate, string deptFilter)
        {
            string query = @"
                SELECT 
                    dep.DeptID, 
                    dep.DeptName, 
                    dep.Description,
                    (SELECT COUNT(*) FROM Employees e WHERE e.DeptID = dep.DeptID) AS TotalEmployees,
                    (SELECT COUNT(*) FROM Designations d WHERE d.DeptID = dep.DeptID) AS TotalDesignations
                FROM Departments dep
                WHERE (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY dep.DeptName";

            SqlParameter[] parameters = {
                new SqlParameter("@Dept", deptFilter)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                previewGrid.Rows.Add(
                    row["DeptID"].ToString(),
                    row["DeptName"].ToString(),
                    row["TotalEmployees"].ToString(),
                    row["TotalDesignations"].ToString(),
                    row["Description"] == DBNull.Value ? "" : row["Description"].ToString(),
                    ""
                );
            }

            return dt.Rows.Count;
        }

        
        // ACTIVE / INACTIVE STATUS REPORT
        
        private int LoadActiveInactiveStatus(DateTime fromDate, DateTime toDate, string deptFilter)
        {
            string query = @"
                SELECT e.EmpNo, e.FullName, ISNULL(dep.DeptName, 'N/A') AS DeptName, e.Status
                FROM Employees e
                LEFT JOIN Departments dep ON e.DeptID = dep.DeptID
                WHERE (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY e.FullName";

            SqlParameter[] parameters = {
                new SqlParameter("@Dept", deptFilter)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                previewGrid.Rows.Add(
                    row["EmpNo"].ToString(),
                    row["FullName"].ToString(),
                    row["DeptName"].ToString(),
                    row["Status"].ToString(),
                    "",
                    ""
                );
            }

            return dt.Rows.Count;
        }

        
        // EXPORT TO CSV
      
        private void exportButton_Click(object sender, EventArgs e)
        {
            if (previewGrid.Rows.Count == 0)
            {
                MessageBox.Show("Please generate a report first.", "No Data",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File|*.csv";
                sfd.FileName = $"{reportTypeCombo.SelectedItem}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToCsv(sfd.FileName);
                        MessageBox.Show("Report exported successfully.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportToCsv(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                var visibleCols = previewGrid.Columns.Cast<DataGridViewColumn>()
                                                      .Where(c => c.Visible)
                                                      .ToList();

                sw.WriteLine(string.Join(",", visibleCols.Select(c => $"\"{c.HeaderText}\"")));

                foreach (DataGridViewRow row in previewGrid.Rows)
                {
                    var values = visibleCols.Select(c =>
                    {
                        string val = row.Cells[c.Index].Value?.ToString() ?? "";
                        return $"\"{val.Replace("\"", "\"\"")}\"";
                    });
                    sw.WriteLine(string.Join(",", values));
                }
            }
        }

        
        // PRINT
        
        private void printButton_Click(object sender, EventArgs e)
        {
            if (previewGrid.Rows.Count == 0)
            {
                MessageBox.Show("Please generate a report first.", "No Data",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printRowIndex = 0;

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDoc;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDoc.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font cellFont = new Font("Arial", 9);

            int top = e.MarginBounds.Top;
            int left = e.MarginBounds.Left;
            int pageWidth = e.MarginBounds.Width;

            g.DrawString("NexusHR - Report", titleFont, Brushes.Black, left, top);
            top += 30;
            g.DrawString(reportSubtitleLabel.Text, headerFont, Brushes.Black, left, top);
            top += 25;
            g.DrawString(reportMetaLabel.Text, cellFont, Brushes.Gray, left, top);
            top += 30;

            var visibleCols = previewGrid.Columns.Cast<DataGridViewColumn>()
                                                  .Where(c => c.Visible)
                                                  .ToList();

            if (visibleCols.Count == 0)
            {
                e.HasMorePages = false;
                return;
            }

            int colWidth = pageWidth / visibleCols.Count;

            int x = left;
            foreach (var col in visibleCols)
            {
                g.DrawString(col.HeaderText, headerFont, Brushes.Black, x, top);
                x += colWidth;
            }
            top += 25;
            g.DrawLine(Pens.Black, left, top, left + pageWidth, top);
            top += 5;

            while (printRowIndex < previewGrid.Rows.Count)
            {
                DataGridViewRow row = previewGrid.Rows[printRowIndex];
                x = left;

                foreach (var col in visibleCols)
                {
                    string text = row.Cells[col.Index].Value?.ToString() ?? "";
                    g.DrawString(text, cellFont, Brushes.Black, x, top);
                    x += colWidth;
                }

                top += 22;
                printRowIndex++;

                if (top > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        
        
        
        private void formatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void deptCombo_SelectedIndexChanged(object sender, EventArgs e) 
        {
        
        }
        private void previewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void filterCardPanel_Paint(object sender, PaintEventArgs e) 
        {
        
        }
        private void reportMetaLabel_Click(object sender, EventArgs e) 
        {
        
        }
    }
}