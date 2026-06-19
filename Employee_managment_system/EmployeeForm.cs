using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class EmployeeForm : Form
    {
        public class Department
        {
            public int DeptID { get; set; }
            public string? DeptName { get; set; }
            public string? Description { get; set; }
        }

        public class Designation
        {
            public int DesignationID { get; set; }
            public int DeptID { get; set; }
            public string? Title { get; set; }
            public decimal BasicSalary { get; set; }
            public decimal? OTRate { get; set; }
            public decimal? MaxMonthlyOTHours { get; set; }
        }

        public class Employee
        {
            public string? EmpNo { get; set; }
            public string? FullName { get; set; }
            public string? Gender { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string? NIC { get; set; }
            public string? ContactNo { get; set; }
            public string? Email { get; set; }
            public string? Address { get; set; }
            public int? DeptID { get; set; }
            public int? DesignationID { get; set; }
            public DateTime? JoinedDate { get; set; }
            public decimal? BasicSalary { get; set; }
            public string? Category { get; set; }
            public string? PhotoBase64 { get; set; }
            public string? DeptName { get; set; }
            public string? DesignationTitle { get; set; }
        }

        private List<Employee> employees = new List<Employee>();
        private List<Department> departments = new List<Department>();
        private List<Designation> designations = new List<Designation>();

        private Employee? selectedEmployee = null;
        private string? newPhotoBase64 = null;

        public EmployeeForm()
        {
            InitializeComponent();

            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Cannot connect to database. Please check your connection string.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadMasterData();
            LoadEmployees();
            ConfigureGrid();
            LoadFilterDropdowns();
            LoadFormCombos();
            RefreshGrid();


        }


        // EXISTING METHODS

        private void LoadMasterData()
        {
            departments.Clear();
            string deptQuery = "SELECT DeptID, DeptName, Description FROM Departments ORDER BY DeptName";
            DataTable deptTable = DatabaseHelper.ExecuteQuery(deptQuery);
            foreach (DataRow row in deptTable.Rows)
            {
                departments.Add(new Department
                {
                    DeptID = Convert.ToInt32(row["DeptID"]),
                    DeptName = row["DeptName"]?.ToString(),
                    Description = row["Description"]?.ToString()
                });
            }

            designations.Clear();
            string desigQuery = "SELECT DesignationID, DeptID, Title, BasicSalary, OTRate, MaxMonthlyOTHours FROM Designations ORDER BY Title";
            DataTable desigTable = DatabaseHelper.ExecuteQuery(desigQuery);
            foreach (DataRow row in desigTable.Rows)
            {
                designations.Add(new Designation
                {
                    DesignationID = Convert.ToInt32(row["DesignationID"]),
                    DeptID = Convert.ToInt32(row["DeptID"]),
                    Title = row["Title"]?.ToString(),
                    BasicSalary = Convert.ToDecimal(row["BasicSalary"]),
                    OTRate = row["OTRate"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["OTRate"]) : null,
                    MaxMonthlyOTHours = row["MaxMonthlyOTHours"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["MaxMonthlyOTHours"]) : null
                });
            }
        }

        private void LoadEmployees()
        {
            employees.Clear();
            string query = @"
                SELECT 
                    e.EmpNo,
                    e.FullName,
                    e.Gender,
                    e.DateOfBirth,
                    e.NIC,
                    e.ContactNo,
                    e.Email,
                    e.Address,
                    e.DeptID,
                    e.DesignationID,
                    e.JoinedDate,
                    e.BasicSalary,
                    e.Category,
                    e.PhotoBase64,
                    d.DeptName,
                    des.Title AS DesignationTitle
                FROM Employees e
                LEFT JOIN Departments d ON e.DeptID = d.DeptID
                LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
                ORDER BY e.EmpNo";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new Employee
                {
                    EmpNo = row["EmpNo"]?.ToString(),
                    FullName = row["FullName"]?.ToString(),
                    Gender = row["Gender"]?.ToString(),
                    DateOfBirth = row["DateOfBirth"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["DateOfBirth"]) : null,
                    NIC = row["NIC"]?.ToString(),
                    ContactNo = row["ContactNo"]?.ToString(),
                    Email = row["Email"]?.ToString(),
                    Address = row["Address"]?.ToString(),
                    DeptID = row["DeptID"] != DBNull.Value ? (int?)Convert.ToInt32(row["DeptID"]) : null,
                    DesignationID = row["DesignationID"] != DBNull.Value ? (int?)Convert.ToInt32(row["DesignationID"]) : null,
                    JoinedDate = row["JoinedDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["JoinedDate"]) : null,
                    BasicSalary = row["BasicSalary"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["BasicSalary"]) : null,
                    Category = row["Category"]?.ToString(),
                    PhotoBase64 = row["PhotoBase64"]?.ToString(),
                    DeptName = row["DeptName"]?.ToString(),
                    DesignationTitle = row["DesignationTitle"]?.ToString()
                });
            }
        }

        private void ConfigureGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in dgvEmployees.Columns)
            {
                switch (col.Name)
                {
                    case "colEmployeeCode": col.DataPropertyName = "EmpNo"; break;
                    case "colFirstName": col.DataPropertyName = "FullName"; break;
                    case "colLastName": col.DataPropertyName = "FullName"; break;
                    case "colDepartment": col.DataPropertyName = "DeptName"; break;
                    case "colDesignation": col.DataPropertyName = "DesignationTitle"; break;
                    case "colNIC": col.DataPropertyName = "NIC"; break;
                    case "colContact": col.DataPropertyName = "ContactNo"; break;
                    case "colStatus": col.DataPropertyName = "Status"; break;
                }
            }
        }

        private void LoadFilterDropdowns()
        {
            cmbDeptFilter.Items.Clear();
            cmbDeptFilter.Items.Add("All");
            foreach (var d in departments)
            {
                if (d.DeptName != null)
                    cmbDeptFilter.Items.Add(d.DeptName);
            }
            cmbDeptFilter.SelectedIndex = 0;

            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Active");
            cmbStatusFilter.Items.Add("Inactive");
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadFormCombos()
        {
            cmbDepartment.DataSource = null;
            cmbDepartment.DataSource = departments.ToList();
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptID";

            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.SelectedIndex = 0;

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[] { "Permanent", "Contract", "Intern", "Temporary" });
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;
        }

        private void cmbDeptFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue is int deptId)
            {
                var filtered = designations.Where(d => d.DeptID == deptId).ToList();
                cmbDesignation.DataSource = filtered;
                cmbDesignation.DisplayMember = "Title";
                cmbDesignation.ValueMember = "DesignationID";
            }
            else
            {
                cmbDesignation.DataSource = null;
            }
        }

        private void RefreshGrid()
        {
            var filtered = employees.AsEnumerable();

            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(e =>
                    (e.FullName != null && e.FullName.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                    (e.EmpNo != null && e.EmpNo.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                    (e.Email != null && e.Email.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                    (e.NIC != null && e.NIC.Contains(search, StringComparison.OrdinalIgnoreCase)));
            }

            if (cmbDeptFilter.SelectedIndex > 0 && cmbDeptFilter.SelectedItem != null)
            {
                string dept = cmbDeptFilter.SelectedItem.ToString()!;
                filtered = filtered.Where(e => e.DeptName == dept);
            }
            dgvEmployees.DataSource = filtered.ToList();
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddEmployeeForm(employees, departments, designations, this))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                    RefreshGrid();
                    MessageBox.Show("Employee added successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"Employees_{DateTime.Now:yyyy-MM-dd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = (List<Employee>)dgvEmployees.DataSource!;
                        var lines = new List<string>
                        {
                            "Employee No,Full Name,Department,Designation,NIC,Contact,Email,Salary"
                        };

                        foreach (var emp in data)
                        {
                            lines.Add($"\"{emp.EmpNo}\",\"{emp.FullName}\",\"{emp.DeptName}\",\"{emp.DesignationTitle}\",\"{emp.NIC}\",\"{emp.ContactNo}\",\"{emp.Email}\",{emp.BasicSalary:F2}");
                        }

                        File.WriteAllLines(sfd.FileName, lines);
                        MessageBox.Show($"Successfully exported {data.Count} employees to CSV.", "Export Complete",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null) return;

            if (MessageBox.Show($"Are you sure you want to delete {selectedEmployee.FullName}?\n\nThis action cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    string query = "DELETE FROM Employees WHERE EmpNo = @EmpNo";
                    SqlParameter[] parameters = {
                        new SqlParameter("@EmpNo", selectedEmployee.EmpNo ?? "")
                    };
#pragma warning restore CS0618

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        employees.Remove(selectedEmployee);
                        RefreshGrid();
                        pnlRightPanel.Visible = false;
                        selectedEmployee = null;
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("No employee selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return;
            }

            try
            {
                string fullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}";

#pragma warning disable CS0618 // Type or member is obsolete
                string query = @"
                    UPDATE Employees 
                    SET 
                        FullName = @FullName,
                        Gender = @Gender,
                        NIC = @NIC,
                        DateOfBirth = @DateOfBirth,
                        ContactNo = @ContactNo,
                        Email = @Email,
                        Address = @Address,
                        DeptID = @DeptID,
                        DesignationID = @DesignationID,
                        BasicSalary = @BasicSalary,
                        Category = @Category,
                        PhotoBase64 = @PhotoBase64
                    WHERE EmpNo = @EmpNo";

                SqlParameter[] parameters = {
                    new SqlParameter("@EmpNo", selectedEmployee.EmpNo ?? ""),
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@Gender", (object?)cmbGender.Text ?? DBNull.Value),
                    new SqlParameter("@NIC", (object?)txtNIC.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                    new SqlParameter("@ContactNo", (object?)txtContact.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Address", (object?)txtAddress.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@DeptID", (int)cmbDepartment.SelectedValue),
                    new SqlParameter("@DesignationID", cmbDesignation.SelectedValue != null ? (object)(int)cmbDesignation.SelectedValue : DBNull.Value),
                    new SqlParameter("@BasicSalary", decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0),
                    new SqlParameter("@Category", (object?)cmbCategory.Text ?? DBNull.Value),
                    new SqlParameter("@PhotoBase64", (object?)newPhotoBase64 ?? DBNull.Value)
                };
#pragma warning restore CS0618

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    LoadEmployees();
                    RefreshGrid();
                    var updatedEmp = employees.FirstOrDefault(e => e.EmpNo == selectedEmployee.EmpNo);
                    if (updatedEmp != null)
                    {
                        selectedEmployee = updatedEmp;
                        LoadEmployeeToPanel(selectedEmployee);
                    }
                    MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Employee Photo";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(ofd.FileName);
                        newPhotoBase64 = Convert.ToBase64String(bytes);

                        using (var ms = new MemoryStream(bytes))
                        {
                            picEmployeePhoto.Image = Image.FromStream(ms);
                        }

                        MessageBox.Show("Photo uploaded successfully. Click Save to update.", "Upload Complete",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error uploading photo: {ex.Message}", "Upload Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
        private void LoadEmployeeToPanel(Employee emp)
        {
            string[] nameParts = emp.FullName?.Split(new[] { ' ' }, 2) ?? new[] { "", "" };
            txtFirstName.Text = nameParts[0];
            txtLastName.Text = nameParts.Length > 1 ? nameParts[1] : "";

            txtNIC.Text = emp.NIC ?? "";
            txtContact.Text = emp.ContactNo ?? "";
            txtEmail.Text = emp.Email ?? "";
            txtSalary.Text = emp.BasicSalary?.ToString("0.00") ?? "0.00";
            txtAddress.Text = emp.Address ?? "";
            dtpDOB.Value = emp.DateOfBirth ?? DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = emp.JoinedDate ?? DateTime.Now;
            cmbGender.Text = emp.Gender ?? "";
            cmbCategory.Text = emp.Category ?? "";

            if (emp.DeptID.HasValue)
                cmbDepartment.SelectedValue = emp.DeptID.Value;

            if (emp.DeptID.HasValue)
            {
                var filtered = designations.Where(d => d.DeptID == emp.DeptID.Value).ToList();
                cmbDesignation.DataSource = filtered;
                cmbDesignation.DisplayMember = "Title";
                cmbDesignation.ValueMember = "DesignationID";
                if (emp.DesignationID.HasValue)
                    cmbDesignation.SelectedValue = emp.DesignationID.Value;
            }

            if (!string.IsNullOrEmpty(emp.PhotoBase64))
            {
                try
                {
                    byte[] bytes = Convert.FromBase64String(emp.PhotoBase64);
                    using (var ms = new MemoryStream(bytes))
                        picEmployeePhoto.Image = Image.FromStream(ms);
                }
                catch
                {
                    picEmployeePhoto.Image = null;
                }
            }
            else
            {
                picEmployeePhoto.Image = null;
            }

            newPhotoBase64 = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRightPanel.Visible = false;
            selectedEmployee = null;
            picEmployeePhoto.Image = null;
            newPhotoBase64 = null;
            ClearEmployeeFields();
            dgvEmployees.ClearSelection();
        }

        private void ClearEmployeeFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtSalary.Clear();
            txtAddress.Clear();

            cmbGender.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbDesignation.DataSource = null;

            dtpDOB.Value = DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = DateTime.Now;

            picEmployeePhoto.Image = null;
            newPhotoBase64 = null;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now.AddYears(-16);
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = DateTime.Now;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
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
            ReportForm report = new ReportForm();
            report.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                selectedEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
                if (selectedEmployee != null)
                {
                    LoadEmployeeToPanel(selectedEmployee);
                    pnlRightPanel.Visible = true;
                    pnlRightPanel.BringToFront();
                }
            }
            else
            {
                pnlRightPanel.Visible = false;
                selectedEmployee = null;
            }

        }
    }
}