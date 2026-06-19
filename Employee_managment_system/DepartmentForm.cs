using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class DepartmentForm : Form
    {
        // Use the existing Department and Designation classes from EmployeeForm
        private List<EmployeeForm.Department> departments = new List<EmployeeForm.Department>();
        private List<EmployeeForm.Designation> designations = new List<EmployeeForm.Designation>();

        private EmployeeForm.Department? selectedDepartment = null;
        private EmployeeForm.Designation? selectedDesignation = null;

        private bool isDeptSaving = false;
        private bool isDesigSaving = false;

        // Custom class for displaying designations with department name
        private class DesignationDisplay
        {
            public int DesignationID { get; set; }
            public string Title { get; set; } = "";
            public string DeptName { get; set; } = "";
            public int EmployeeCount { get; set; }
            public int DeptID { get; set; }
        }

        private List<DesignationDisplay> designationDisplayList = new List<DesignationDisplay>();

        public DepartmentForm()
        {
            InitializeComponent();

            // Load data
            LoadDepartments();
            LoadDesignations();
            ConfigureDepartmentsGrid();
            ConfigureDesignationsGrid();
            BindDepartmentsGrid();
            BindDesignationsGrid();

            // Set initial button states
            btnDeleteDept.Enabled = false;
            btnDeleteDesig.Enabled = false;

            // Wire up events
            dgvDepartments.SelectionChanged += DgvDepartments_SelectionChanged!;
            dgvDesignations.SelectionChanged += DgvDesignations_SelectionChanged!;
            btnAddDept.Click += BtnAddDept_Click!;
            btnDeleteDept.Click += BtnDeleteDept_Click!;
            btnSaveDept.Click += BtnSaveDept_Click!;
            btnCancelDept.Click += BtnCancelDept_Click!;
            btnAddDesig.Click += BtnAddDesig_Click!;
            btnDeleteDesig.Click += BtnDeleteDesig_Click!;
            btnSaveDesig.Click += BtnSaveDesig_Click!;
            btnCancelDesig.Click += BtnCancelDesig_Click!;
            cmbDesigDepartment.SelectedIndexChanged += CmbDesigDepartment_SelectedIndexChanged!;

            // Wire up navigation menu
            WireUpMenuEvents();

            // Handle DataGridView errors
            dgvDepartments.DataError += DgvDepartments_DataError!;
            dgvDesignations.DataError += DgvDesignations_DataError!;
        }

        private void WireUpMenuEvents()
        {
            btnDashboard.Click += (s, e) => { DashboardForm dash = new DashboardForm(); dash.Show(); Hide(); };
            btnEmployees.Click += (s, e) => { EmployeeForm emp = new EmployeeForm(); emp.Show(); Hide(); };
            btnDepartment.Click += (s, e) => { /* Already here */ };
            btnAttendance.Click += (s, e) => { AttendanceForm att = new AttendanceForm(); att.Show(); Hide(); };
            btnLeave.Click += (s, e) => { LeaveForm leave = new LeaveForm(); leave.Show(); Hide(); };
            btnPayroll.Click += (s, e) => { PayrollForm payroll = new PayrollForm(); payroll.Show(); Hide(); };
            btnReports.Click += (s, e) => { ReportForm report = new ReportForm(); report.Show(); Hide(); };
            btnLogout.Click += (s, e) => { LoginForm login = new LoginForm(); login.Show(); Close(); };
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // Any additional load logic
        }

        // ============================================
        // HANDLE DATA GRID VIEW ERRORS
        // ============================================
        private void DgvDepartments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void DgvDesignations_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ============================================
        // LOAD DATA FROM DATABASE
        // ============================================
        private void LoadDepartments()
        {
            try
            {
                departments.Clear();
                string query = "SELECT DeptID, DeptName, Description FROM Departments ORDER BY DeptName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    departments.Add(new EmployeeForm.Department
                    {
                        DeptID = Convert.ToInt32(row["DeptID"]),
                        DeptName = row["DeptName"]?.ToString() ?? "",
                        Description = row["Description"]?.ToString() ?? ""
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDesignations()
        {
            try
            {
                designations.Clear();
                string query = @"
                    SELECT d.DesignationID, d.DeptID, d.Title, d.BasicSalary, d.OTRate, d.MaxMonthlyOTHours,
                           dep.DeptName
                    FROM Designations d
                    LEFT JOIN Departments dep ON d.DeptID = dep.DeptID
                    ORDER BY d.Title";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    designations.Add(new EmployeeForm.Designation
                    {
                        DesignationID = Convert.ToInt32(row["DesignationID"]),
                        DeptID = Convert.ToInt32(row["DeptID"]),
                        Title = row["Title"]?.ToString() ?? "",
                        BasicSalary = Convert.ToDecimal(row["BasicSalary"]),
                        OTRate = row["OTRate"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["OTRate"]) : null,
                        MaxMonthlyOTHours = row["MaxMonthlyOTHours"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["MaxMonthlyOTHours"]) : null
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading designations: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // GET EMPLOYEE COUNTS
        // ============================================
        private int GetEmployeeCountForDepartment(int deptId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Employees WHERE DeptID = @DeptID";
                SqlParameter[] parameters = { new SqlParameter("@DeptID", deptId) };
                return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            }
            catch
            {
                return 0;
            }
        }

        private int GetEmployeeCountForDesignation(int desigId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Employees WHERE DesignationID = @DesignationID";
                SqlParameter[] parameters = { new SqlParameter("@DesignationID", desigId) };
                return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            }
            catch
            {
                return 0;
            }
        }

        // ============================================
        // GRID CONFIGURATION
        // ============================================
        private void ConfigureDepartmentsGrid()
        {
            dgvDepartments.AutoGenerateColumns = false;
            id.DataPropertyName = "DeptID";
            colDepartmentName.DataPropertyName = "DeptName";
            colDescription.DataPropertyName = "Description";
        }

        private void ConfigureDesignationsGrid()
        {
            dgvDesignations.AutoGenerateColumns = false;
            DesignationId.DataPropertyName = "DesignationID";
            Title.DataPropertyName = "Title";
            DeptName.DataPropertyName = "DeptName";
            DesigEmployeeCount.DataPropertyName = "EmployeeCount";
        }

        // ============================================
        // BIND DATA TO GRIDS
        // ============================================
        private void BindDepartmentsGrid()
        {
            dgvDepartments.DataSource = null;

            var deptList = departments.Select(d => new
            {
                d.DeptID,
                d.DeptName,
                d.Description,
                EmployeeCount = GetEmployeeCountForDepartment(d.DeptID)
            }).ToList();

            dgvDepartments.DataSource = deptList;
        }

        private void BindDesignationsGrid()
        {
            if (selectedDepartment == null)
            {
                dgvDesignations.DataSource = null;
                return;
            }

            var filtered = designations.Where(d => d.DeptID == selectedDepartment.DeptID).ToList();

            designationDisplayList = filtered.Select(d => new DesignationDisplay
            {
                DesignationID = d.DesignationID,
                Title = d.Title,
                DeptID = d.DeptID,
                DeptName = departments.FirstOrDefault(dept => dept.DeptID == d.DeptID)?.DeptName ?? "",
                EmployeeCount = GetEmployeeCountForDesignation(d.DesignationID)
            }).ToList();

            dgvDesignations.DataSource = designationDisplayList;
        }

        // ============================================
        // DEPARTMENT SELECTION CHANGED
        // ============================================
        private void DgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                var selectedItem = dgvDepartments.SelectedRows[0].DataBoundItem;
                var deptId = (int)selectedItem.GetType().GetProperty("DeptID").GetValue(selectedItem);

                selectedDepartment = departments.FirstOrDefault(d => d.DeptID == deptId);

                if (selectedDepartment != null)
                {
                    LoadDepartmentToPanel(selectedDepartment);
                    pnlDeptDetails.Visible = true;
                    btnDeleteDept.Enabled = true;
                    lblDeptInfo.Text = $"📌 Selected: {selectedDepartment.DeptName}";
                    BindDesignationsGrid();
                }
            }
            else
            {
                pnlDeptDetails.Visible = false;
                selectedDepartment = null;
                btnDeleteDept.Enabled = false;
                lblDeptInfo.Text = "💡 Click a department to view and edit details";
            }
        }

        private void LoadDepartmentToPanel(EmployeeForm.Department dept)
        {
            txtDeptName.Text = dept.DeptName ?? "";
            txtDeptDescription.Text = dept.Description ?? "";
            txtDeptEmployeeCount.Text = GetEmployeeCountForDepartment(dept.DeptID).ToString();
        }

        // ============================================
        // DESIGNATION SELECTION CHANGED
        // ============================================
        private void DgvDesignations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDesignations.SelectedRows.Count > 0)
            {
                var selectedItem = dgvDesignations.SelectedRows[0].DataBoundItem as DesignationDisplay;

                if (selectedItem != null)
                {
                    selectedDesignation = designations.FirstOrDefault(d => d.DesignationID == selectedItem.DesignationID);

                    if (selectedDesignation != null)
                    {
                        LoadDesignationToPanel(selectedDesignation);
                        pnlDesigDetails.Visible = true;
                        btnDeleteDesig.Enabled = true;
                        lblDesigInfo.Text = $"📌 Selected: {selectedDesignation.Title}";
                    }
                }
            }
            else
            {
                pnlDesigDetails.Visible = false;
                selectedDesignation = null;
                btnDeleteDesig.Enabled = false;
                lblDesigInfo.Text = "💡 Click a designation to view and edit details";
            }
        }

        private void LoadDesignationToPanel(EmployeeForm.Designation desig)
        {
            txtDesigTitle.Text = desig.Title ?? "";
            txtDesigEmployeeCount.Text = GetEmployeeCountForDesignation(desig.DesignationID).ToString();

            PopulateDepartmentCombo();
            cmbDesigDepartment.SelectedValue = desig.DeptID;
        }

        private void PopulateDepartmentCombo()
        {
            cmbDesigDepartment.DataSource = null;
            cmbDesigDepartment.DataSource = departments.ToList();
            cmbDesigDepartment.DisplayMember = "DeptName";
            cmbDesigDepartment.ValueMember = "DeptID";
        }

        private void CmbDesigDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle department change for designation
        }

        // ============================================
        // DEPARTMENT BUTTON EVENTS
        // ============================================
        private void BtnAddDept_Click(object sender, EventArgs e)
        {
            selectedDepartment = null;
            txtDeptName.Clear();
            txtDeptDescription.Clear();
            txtDeptEmployeeCount.Text = "0";
            pnlDeptDetails.Visible = true;
            txtDeptName.Focus();
            dgvDepartments.ClearSelection();
            btnDeleteDept.Enabled = false;
            lblDeptInfo.Text = "📝 Adding new department...";
        }

        private void BtnDeleteDept_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null) return;

            int employeeCount = GetEmployeeCountForDepartment(selectedDepartment.DeptID);
            if (employeeCount > 0)
            {
                MessageBox.Show($"Cannot delete department '{selectedDepartment.DeptName}' because it has {employeeCount} employee(s).",
                              "Business Rule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete department '{selectedDepartment.DeptName}'?",
                              "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Check if department has designations - use new parameter array
                    string checkDesigQuery = "SELECT COUNT(*) FROM Designations WHERE DeptID = @DeptID";
                    SqlParameter[] checkParams = { new SqlParameter("@DeptID", selectedDepartment.DeptID) };
                    int desigCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkDesigQuery, checkParams));

                    // Delete designations first if any exist - use new parameter array
                    if (desigCount > 0)
                    {
                        string deleteDesigQuery = "DELETE FROM Designations WHERE DeptID = @DeptID";
                        SqlParameter[] deleteDesigParams = { new SqlParameter("@DeptID", selectedDepartment.DeptID) };
                        DatabaseHelper.ExecuteNonQuery(deleteDesigQuery, deleteDesigParams);
                    }

                    // Delete the department - use new parameter array
                    string deleteQuery = "DELETE FROM Departments WHERE DeptID = @DeptID";
                    SqlParameter[] deleteParams = { new SqlParameter("@DeptID", selectedDepartment.DeptID) };
                    DatabaseHelper.ExecuteNonQuery(deleteQuery, deleteParams);

                    LoadDepartments();
                    LoadDesignations();
                    BindDepartmentsGrid();
                    selectedDepartment = null;
                    pnlDeptDetails.Visible = false;
                    btnDeleteDept.Enabled = false;
                    BindDesignationsGrid();

                    MessageBox.Show("Department deleted successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting department: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSaveDept_Click(object sender, EventArgs e)
        {
            if (isDeptSaving) return;
            isDeptSaving = true;

            try
            {
                string deptName = txtDeptName.Text.Trim();
                if (string.IsNullOrWhiteSpace(deptName))
                {
                    MessageBox.Show("Department name is required.", "Validation",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeptName.Focus();
                    return;
                }

                bool isNew = selectedDepartment == null;
                bool duplicateExists;

                if (isNew)
                {
                    duplicateExists = departments.Any(d => d.DeptName.Equals(deptName, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    duplicateExists = departments.Any(d => d.DeptID != selectedDepartment.DeptID &&
                                                          d.DeptName.Equals(deptName, StringComparison.OrdinalIgnoreCase));
                }

                if (duplicateExists)
                {
                    MessageBox.Show($"A department named '{deptName}' already exists.",
                                  "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeptName.Focus();
                    txtDeptName.SelectAll();
                    return;
                }

                if (isNew)
                {
                    string query = @"INSERT INTO Departments (DeptName, Description) VALUES (@DeptName, @Description)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@DeptName", deptName),
                        new SqlParameter("@Description", (object?)txtDeptDescription.Text.Trim() ?? DBNull.Value)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Department added successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = @"UPDATE Departments SET DeptName = @DeptName, Description = @Description WHERE DeptID = @DeptID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@DeptID", selectedDepartment.DeptID),
                        new SqlParameter("@DeptName", deptName),
                        new SqlParameter("@Description", (object?)txtDeptDescription.Text.Trim() ?? DBNull.Value)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Department updated successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadDepartments();
                BindDepartmentsGrid();
                pnlDeptDetails.Visible = false;
                selectedDepartment = null;
                btnDeleteDept.Enabled = false;
                dgvDepartments.ClearSelection();
                lblDeptInfo.Text = "💡 Click a department to view and edit details";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving department: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isDeptSaving = false;
            }
        }

        private void BtnCancelDept_Click(object sender, EventArgs e)
        {
            pnlDeptDetails.Visible = false;
            selectedDepartment = null;
            btnDeleteDept.Enabled = false;
            dgvDepartments.ClearSelection();
            lblDeptInfo.Text = "💡 Click a department to view and edit details";
        }

        // ============================================
        // DESIGNATION BUTTON EVENTS
        // ============================================
        private void BtnAddDesig_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Please select a department first.", "Info",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedDesignation = null;
            txtDesigTitle.Clear();
            txtDesigEmployeeCount.Text = "0";
            PopulateDepartmentCombo();
            cmbDesigDepartment.SelectedValue = selectedDepartment.DeptID;
            pnlDesigDetails.Visible = true;
            txtDesigTitle.Focus();
            dgvDesignations.ClearSelection();
            btnDeleteDesig.Enabled = false;
            lblDesigInfo.Text = "📝 Adding new designation...";
        }

        private void BtnDeleteDesig_Click(object sender, EventArgs e)
        {
            if (selectedDesignation == null) return;

            int employeeCount = GetEmployeeCountForDesignation(selectedDesignation.DesignationID);
            if (employeeCount > 0)
            {
                MessageBox.Show($"Cannot delete designation '{selectedDesignation.Title}' because {employeeCount} employee(s) are assigned.",
                              "Business Rule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete designation '{selectedDesignation.Title}'?",
                              "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM Designations WHERE DesignationID = @DesignationID";
                    SqlParameter[] parameters = { new SqlParameter("@DesignationID", selectedDesignation.DesignationID) };
                    DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);

                    LoadDesignations();
                    BindDesignationsGrid();
                    selectedDesignation = null;
                    pnlDesigDetails.Visible = false;
                    btnDeleteDesig.Enabled = false;

                    MessageBox.Show("Designation deleted successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting designation: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSaveDesig_Click(object sender, EventArgs e)
        {
            if (isDesigSaving) return;
            isDesigSaving = true;

            try
            {
                string title = txtDesigTitle.Text.Trim();
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Designation title is required.", "Validation",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesigTitle.Focus();
                    return;
                }

                if (cmbDesigDepartment.SelectedValue == null)
                {
                    MessageBox.Show("Please select a department.", "Validation",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int deptId = (int)cmbDesigDepartment.SelectedValue;

                bool isNew = selectedDesignation == null;
                bool duplicateExists;

                if (isNew)
                {
                    duplicateExists = designations.Any(d => d.DeptID == deptId &&
                                                           d.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    duplicateExists = designations.Any(d => d.DesignationID != selectedDesignation.DesignationID &&
                                                           d.DeptID == deptId &&
                                                           d.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                }

                if (duplicateExists)
                {
                    MessageBox.Show("This designation already exists in the selected department.",
                                  "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesigTitle.Focus();
                    txtDesigTitle.SelectAll();
                    return;
                }

                if (isNew)
                {
                    string query = @"INSERT INTO Designations (DeptID, Title, BasicSalary, OTRate, MaxMonthlyOTHours) 
                                    VALUES (@DeptID, @Title, 0, 0, 0)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@DeptID", deptId),
                        new SqlParameter("@Title", title)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Designation added successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = @"UPDATE Designations SET DeptID = @DeptID, Title = @Title WHERE DesignationID = @DesignationID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@DesignationID", selectedDesignation.DesignationID),
                        new SqlParameter("@DeptID", deptId),
                        new SqlParameter("@Title", title)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Designation updated successfully.", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadDesignations();
                BindDesignationsGrid();
                pnlDesigDetails.Visible = false;
                selectedDesignation = null;
                btnDeleteDesig.Enabled = false;
                dgvDesignations.ClearSelection();
                lblDesigInfo.Text = "💡 Click a designation to view and edit details";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving designation: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isDesigSaving = false;
            }
        }

        private void BtnCancelDesig_Click(object sender, EventArgs e)
        {
            pnlDesigDetails.Visible = false;
            selectedDesignation = null;
            btnDeleteDesig.Enabled = false;
            dgvDesignations.ClearSelection();
            lblDesigInfo.Text = "💡 Click a designation to view and edit details";
        }
    }
}