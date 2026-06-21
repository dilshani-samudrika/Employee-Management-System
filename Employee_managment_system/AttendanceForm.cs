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

        // LOAD DEPARTMENTS INTO COMBOBOX 
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

                // Add All Departments option at the beginning
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

        //  HELPER: GET SELECTED DEPARTMENT ID SAFELY 
        private int GetSelectedDepartmentId()
        {
            try
            {
                if (comboBox1.SelectedValue == null)
                    return -1;

                // Handle both DataRowView and int cases
                if (comboBox1.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBox1.SelectedValue;
                    return Convert.ToInt32(drv["DeptID"]);
                }
                else
                {
                    return Convert.ToInt32(comboBox1.SelectedValue);
                }
            }
            catch
            {
                return -1;
            }
        }

        private void LoadAttendanceData()
        {
            try
            {
                int deptId = GetSelectedDepartmentId();

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

        private void LoadAttendanceCounts()
        {
            try
            {
                int deptId = GetSelectedDepartmentId();

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
            LoadAttendanceCounts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                LoadAttendanceData();
                LoadAttendanceCounts();
            }
        }

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
                int deptId = GetSelectedDepartmentId();
                if (deptId != -1)
                {
                    deptName = "_" + comboBox1.Text.Replace(" ", "").Replace("-", "");
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

        // FIXED LOGOUT - RETURNS TO LOGIN 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Show login form
                    LoginForm login = new LoginForm();
                    login.Show();

                    // Close all other forms
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form != login && form != this)
                        {
                            form.Close();
                        }
                    }

                    // Close this form
                    this.Close();
                }
                catch
                {
                   
                    Application.Exit();
                }
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveForm leave = new LeaveForm();
            leave.Show();
            this.Hide();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}