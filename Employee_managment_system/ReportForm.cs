using System;
using System.Data;
using System.Collections.Generic;
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
        // Tracks which preview row we're up to when printing across multiple pages
        private int printRowIndex = 0;

        public reports()
        {
            InitializeComponent();

            // Default date range: last 30 days
            fromDatePicker.Value = DateTime.Today.AddMonths(-1);
            toDatePicker.Value = DateTime.Today;

            LoadDepartmentsIntoCombo();

            // Setting these triggers their SelectedIndexChanged handlers below,
            // which configure the grid columns and reset the preview text.
            reportTypeCombo.SelectedIndex = 0;   // "Employee List"
            formatCombo.SelectedIndex = 1;       // "CSV" (only export format currently implemented)
        }

        // ============================================
        // LOAD DEPARTMENTS INTO FILTER COMBO
        // ============================================
        private void LoadDepartmentsIntoCombo()
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
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        
        private void reportTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = reportTypeCombo.SelectedItem?.ToString() ?? "Employee List";
            ConfigureGridColumnsForReportType(selected);
            ClearPreview(selected);
        }

        private void ConfigureGridColumnsForReportType(string reportType)
        {
            switch (reportType)
            {
                case "Department Summary":
                    SetGridHeaders("Dept ID", "Department", "Total Employees", "Total Designations", "Description", null);
                    break;

                case "Active/Inactive Status":
                    SetGridHeaders("ID", "Name", "Department", "Status", null, null);
                    break;

                case "Employee List":
                default:
                    SetGridHeaders("ID", "Name", "Department", "Designation", "Joining Date", "Status");
                    break;
            }
        }

     
        private void SetGridHeaders(string c1, string c2, string c3, string c4, string c5, string c6)
        {
            DataGridViewColumn[] cols = { colID, colName, colDepartment, colDesignation, colJoiningDate, colStatus };
            string[] headers = { c1, c2, c3, c4, c5, c6 };

            for (int i = 0; i < cols.Length; i++)
            {
                if (headers[i] == null)
                {
                    cols[i].Visible = false;
                }
                else
                {
                    cols[i].Visible = true;
                    cols[i].HeaderText = headers[i];
                }
            }
        }

        private void ClearPreview(string reportType)
        {
            previewGrid.Rows.Clear();
            reportSubtitleLabel.Text = $"{reportType} Report";
            reportMetaLabel.Text = "Period: — | Generated: — | By: Admin";
            totalRecordsLabel.Text = "Total Records: 0";
            pageInfoLabel.Text = "Page 1 of 1 | Zoom: 100%";
        }

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

        private void formatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void deptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
        private void previewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       
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
                int recordCount;

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
                reportMetaLabel.Text = $"Period: {fromDate:dd-MMM-yyyy} to {toDate:dd-MMM-yyyy} | Generated: {DateTime.Now:dd-MMM-yyyy HH:mm} | By: Admin";
                totalRecordsLabel.Text = $"Total Records: {recordCount}";
                pageInfoLabel.Text = "Page 1 of 1 | Zoom: 100%";
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
                SELECT e.EmpNo, e.FullName, dep.DeptName, des.Title, e.JoinedDate,
                       CASE WHEN u.IsActive = 0 THEN 'Inactive' ELSE 'Active' END AS Status
                FROM Employees e
                LEFT JOIN Departments dep ON e.DeptID = dep.DeptID
                LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
                LEFT JOIN Users u ON u.EmployeeID = e.EmpNo
                WHERE e.JoinedDate BETWEEN @From AND @To
                  AND (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY e.FullName";

            SqlParameter[] parameters = {
                new SqlParameter("@From", fromDate),
                new SqlParameter("@To", toDate),
                new SqlParameter("@Dept", deptFilter)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                previewGrid.Rows.Add(
                    row["EmpNo"].ToString(),
                    row["FullName"].ToString(),
                    row["DeptName"] == DBNull.Value ? "" : row["DeptName"].ToString(),
                    row["Title"] == DBNull.Value ? "" : row["Title"].ToString(),
                    Convert.ToDateTime(row["JoinedDate"]).ToString("dd-MMM-yyyy"),
                    row["Status"].ToString()
                );
            }

            return dt.Rows.Count;
        }

        private int LoadDepartmentSummary(DateTime fromDate, DateTime toDate, string deptFilter)
        {
            string query = @"
                SELECT dep.DeptID, dep.DeptName, dep.Description,
                       (SELECT COUNT(*) FROM Employees e WHERE e.DeptID = dep.DeptID
                            AND e.JoinedDate BETWEEN @From AND @To) AS TotalEmployees,
                       (SELECT COUNT(*) FROM Designations d WHERE d.DeptID = dep.DeptID) AS TotalDesignations
                FROM Departments dep
                WHERE (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY dep.DeptName";

            SqlParameter[] parameters = {
                new SqlParameter("@From", fromDate),
                new SqlParameter("@To", toDate),
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

        // ============================================
        // ACTIVE / INACTIVE STATUS REPORT
        // ============================================
        private int LoadActiveInactiveStatus(DateTime fromDate, DateTime toDate, string deptFilter)
        {
            string query = @"
                SELECT e.EmpNo, e.FullName, dep.DeptName,
                       CASE WHEN u.IsActive = 0 THEN 'Inactive' ELSE 'Active' END AS Status
                FROM Employees e
                LEFT JOIN Departments dep ON e.DeptID = dep.DeptID
                LEFT JOIN Users u ON u.EmployeeID = e.EmpNo
                WHERE e.JoinedDate BETWEEN @From AND @To
                  AND (@Dept = 'All' OR dep.DeptName = @Dept)
                ORDER BY e.FullName";

            SqlParameter[] parameters = {
                new SqlParameter("@From", fromDate),
                new SqlParameter("@To", toDate),
                new SqlParameter("@Dept", deptFilter)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                previewGrid.Rows.Add(
                    row["EmpNo"].ToString(),
                    row["FullName"].ToString(),
                    row["DeptName"] == DBNull.Value ? "" : row["DeptName"].ToString(),
                    row["Status"].ToString(),
                    "",
                    ""
                );
            }

            return dt.Rows.Count;
        }

        // ============================================
        // PRINT
        // ============================================
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
                        MessageBox.Show($"Error printing report: {ex.Message}", "Error",
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

            g.DrawString(reportTitleLabel.Text, titleFont, Brushes.Black, left, top);
            top += 30;
            g.DrawString(reportSubtitleLabel.Text, headerFont, Brushes.Black, left, top);
            top += 25;
            g.DrawString(reportMetaLabel.Text, cellFont, Brushes.Gray, left, top);
            top += 30;

            var visibleCols = previewGrid.Columns.Cast<DataGridViewColumn>()
                                                  .Where(c => c.Visible)
                                                  .OrderBy(c => c.DisplayIndex)
                                                  .ToList();

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

        // ============================================
        // EXPORT (CSV)
        // ============================================
        private void exportButton_Click(object sender, EventArgs e)
        {
            if (previewGrid.Rows.Count == 0 || previewGrid == null)
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
                        ExportGridToCsv(sfd.FileName);
                        MessageBox.Show("Report exported successfully.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting report: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportGridToCsv(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                var visibleCols = previewGrid.Columns.Cast<DataGridViewColumn>()
                                                      .Where(c => c.Visible)
                                                      .OrderBy(c => c.DisplayIndex)
                                                      .ToList();

                sw.WriteLine(string.Join(",", visibleCols.Select(c => EscapeCsv(c.HeaderText))));

                foreach (DataGridViewRow row in previewGrid.Rows)
                {
                    var values = visibleCols.Select(c => EscapeCsv(row.Cells[c.Index].Value?.ToString() ?? ""));
                    sw.WriteLine(string.Join(",", values));
                }
            }
        }

        private string EscapeCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }
            return value;
        }

        private void filterCardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportMetaLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}