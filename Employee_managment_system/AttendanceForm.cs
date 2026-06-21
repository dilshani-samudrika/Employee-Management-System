using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_managment_system
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Test database connection
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Cannot connect to database. Please check your connection settings.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dateTimePicker1.Value = DateTime.Today;
            LoadDepartments();
            LoadAttendanceData();
            LoadAttendanceCounts();
        }

        // ============ LOAD DEPARTMENTS INTO COMBOBOX ============
        private void LoadDepartments()
        {
            try
            {
                string query = "SELECT DeptID, DeptName FROM Departments ORDER BY DeptName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No departments found in database!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add "All Departments" option at the beginning
                DataRow allRow = dt.NewRow();
                allRow["DeptID"] = -1;
                allRow["DeptName"] = "-- All Departments --";
                dt.Rows.InsertAt(allRow, 0);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "DeptName";
                comboBox1.ValueMember = "DeptID";
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ LOAD ATTENDANCE DATA INTO DATAGRIDVIEW ============
        private void LoadAttendanceData()
        {
            try
            {
                int deptId = -1;
                if (comboBox1.SelectedValue != null)
                {
                    deptId = Convert.ToInt32(comboBox1.SelectedValue);
                }

                // Database column names: EmpNo, FullName, DeptName, Status, OTHours
                // Note: There is NO Remarks column in the Attendance table
                string query = @"SELECT 
                    a.EmpNo AS 'Employee ID',
                    e.FullName AS 'Name',
                    d.DeptName AS 'Department',
                    a.Status,
                    a.OTHours AS 'Over Time'
                FROM Attendance a
                INNER JOIN Employees e ON a.EmpNo = e.EmpNo
                LEFT JOIN Departments d ON e.DeptID = d.DeptID
                WHERE a.AttendDate = @AttendDate";

                SqlParameter[] parameters;

                if (deptId != -1)
                {
                    query += " AND e.DeptID = @DeptID";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@AttendDate", dateTimePicker1.Value.Date),
                        new SqlParameter("@DeptID", deptId)
                    };
                }
                else
                {
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@AttendDate", dateTimePicker1.Value.Date)
                    };
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvPending.DataSource = dt;
                dgvPending.AutoResizeColumns();

                // Remove Remarks column if it exists (from previous runs)
                if (dgvPending.Columns["Remarks"] != null)
                {
                    dgvPending.Columns["Remarks"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ LOAD ATTENDANCE COUNTS ============
        private void LoadAttendanceCounts()
        {
            try
            {
                int deptId = -1;
                if (comboBox1.SelectedValue != null)
                {
                    deptId = Convert.ToInt32(comboBox1.SelectedValue);
                }

                string query = @"
                    SELECT 
                        SUM(CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END) AS Present,
                        SUM(CASE WHEN a.Status = 'Absent' THEN 1 ELSE 0 END) AS Absent,
                        SUM(CASE WHEN a.Status = 'Half-Day' THEN 1 ELSE 0 END) AS HalfDay,
                        SUM(CASE WHEN a.Status = 'Late' THEN 1 ELSE 0 END) AS Late
                    FROM Attendance a
                    INNER JOIN Employees e ON a.EmpNo = e.EmpNo
                    WHERE a.AttendDate = @AttendDate";

                SqlParameter[] parameters;

                if (deptId != -1)
                {
                    query += " AND e.DeptID = @DeptID";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@AttendDate", dateTimePicker1.Value.Date),
                        new SqlParameter("@DeptID", deptId)
                    };
                }
                else
                {
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@AttendDate", dateTimePicker1.Value.Date)
                    };
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    txtPresent.Text = dt.Rows[0]["Present"]?.ToString() ?? "0";
                    txtAbsent.Text = dt.Rows[0]["Absent"]?.ToString() ?? "0";
                    txtHalfDay.Text = dt.Rows[0]["HalfDay"]?.ToString() ?? "0";
                    txtLate.Text = dt.Rows[0]["Late"]?.ToString() ?? "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading counts: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ DATE TIME PICKER - VALUE CHANGED ============
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
            LoadAttendanceCounts();
        }

        // ============ COMBOBOX - DEPARTMENT FILTER ============
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                LoadAttendanceData();
                LoadAttendanceCounts();
            }
        }

        // ============ EXPORT CSV BUTTON ============
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPending.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

                string deptName = "";
                if (comboBox1.SelectedValue != null && Convert.ToInt32(comboBox1.SelectedValue) != -1)
                {
                    deptName = "_" + comboBox1.Text.Replace(" ", "");
                }
                saveFileDialog.FileName = $"Attendance_{dateTimePicker1.Value:yyyyMMdd}{deptName}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Headers
                    for (int i = 0; i < dgvPending.Columns.Count; i++)
                    {
                        csvContent.Append(dgvPending.Columns[i].HeaderText);
                        if (i < dgvPending.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();

                    // Data
                    foreach (DataGridViewRow row in dgvPending.Rows)
                    {
                        for (int i = 0; i < dgvPending.Columns.Count; i++)
                        {
                            csvContent.Append(row.Cells[i].Value?.ToString() ?? "");
                            if (i < dgvPending.Columns.Count - 1)
                                csvContent.Append(",");
                        }
                        csvContent.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                    MessageBox.Show($"Exported successfully!\n{saveFileDialog.FileName}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export error: {ex.Message}", "Error",
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

        // ============ NAVIGATION - ATTENDANCE (Current) ============
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
            LoadAttendanceCounts();
            MessageBox.Show("Attendance data refreshed!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ NAVIGATION - LEAVE ============
        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.Show();
            this.Hide();
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
                this.Close();
                Application.Exit();
            }
        }
    }
}