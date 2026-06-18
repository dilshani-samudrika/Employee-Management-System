using System;
using System.Linq;
using System.Windows.Forms;

namespace Departmanet_managment
{
    public partial class DepartmentDesignationForm : Form
    {
        private List<Department> departments = new List<Department>();
        private List<Designation> designations = new List<Designation>();
        private int nextDeptId = 1;
        private int nextDesigId = 1;

        private Department selectedDepartment = null;
        private Designation selectedDesignation = null;

        private int editingDeptId = 0;
        private int editingDesigId = 0;

        private bool isSaving = false;

        public DepartmentDesignationForm()
        {
            InitializeComponent();
            LoadSampleData();
            ConfigureDepartmentsGrid();
            ConfigureDesignationsGrid();
            BindDepartmentsGrid();
            BindDesignationsGrid();

            btnEditDept.Enabled = false;
            btnDeleteDept.Enabled = false;
            btnEditDesig.Enabled = false;
            btnDeleteDesig.Enabled = false;

            dgvDepartments.CellClick += dgvDepartments_CellClick;
            dgvDesignations.CellClick += dgvDesignations_CellClick;
            btnNewDept.Click += btnNewDept_Click;
            btnEditDept.Click += btnEditDept_Click;
            btnDeleteDept.Click += btnDeleteDept_Click;
            btnSaveDept.Click += btnSaveDept_Click;
            btnCancelDept.Click += btnCancelDept_Click;
            btnNewDesig.Click += btnNewDesig_Click;
            btnEditDesig.Click += btnEditDesig_Click;
            btnDeleteDesig.Click += btnDeleteDesig_Click;
            btnSaveDesig.Click += btnSaveDesig_Click;
            btnCancelDesig.Click += btnCancelDesig_Click;
        }

        private void LoadSampleData()
        {
            departments = new List<Department>
            {
                new Department { Id = 1, Name = "IT", Section = "Technology", ManagerId = "MGR-101", EmployeeCount = 28 },
                new Department { Id = 2, Name = "HR", Section = "People & Culture", ManagerId = "MGR-202", EmployeeCount = 12 },
                new Department { Id = 3, Name = "Finance", Section = "Accounts", ManagerId = "MGR-303", EmployeeCount = 8 }
            };
            designations = new List<Designation>
            {
                new Designation { Id = 101, Title = "Developer", DepartmentId = 1, AssignedEmployeesCount = 15, DepartmentName = "IT" },
                new Designation { Id = 102, Title = "System Admin", DepartmentId = 1, AssignedEmployeesCount = 5, DepartmentName = "IT" },
                new Designation { Id = 103, Title = "QA Engineer", DepartmentId = 1, AssignedEmployeesCount = 6, DepartmentName = "IT" },
                new Designation { Id = 104, Title = "HR Generalist", DepartmentId = 2, AssignedEmployeesCount = 4, DepartmentName = "HR" },
                new Designation { Id = 105, Title = "Recruiter", DepartmentId = 2, AssignedEmployeesCount = 3, DepartmentName = "HR" },
                new Designation { Id = 106, Title = "Accountant", DepartmentId = 3, AssignedEmployeesCount = 5, DepartmentName = "Finance" }
            };
            nextDeptId = departments.Max(d => d.Id) + 1;
            nextDesigId = designations.Max(d => d.Id) + 1;
            selectedDepartment = departments.FirstOrDefault();
        }

        private void ConfigureDepartmentsGrid()
        {
            dgvDepartments.AutoGenerateColumns = false;
            id.DataPropertyName = "Id";
            colDepartmentName.DataPropertyName = "Name";
            Section.DataPropertyName = "Section";
            EmployeeCount.DataPropertyName = "EmployeeCount";
            ManagerId.DataPropertyName = "ManagerId";
        }

        private void ConfigureDesignationsGrid()
        {
            dgvDesignations.AutoGenerateColumns = false;
            DesignationId.DataPropertyName = "Id";
            Title.DataPropertyName = "Title";
            DepartmentName.DataPropertyName = "DepartmentName";
            SssignedCount.DataPropertyName = "AssignedEmployeesCount";
        }

        private void BindDepartmentsGrid()
        {
            dgvDepartments.DataSource = null;
            dgvDepartments.DataSource = departments.ToList();
        }

        private void BindDesignationsGrid()
        {
            if (selectedDepartment == null)
            {
                dgvDesignations.DataSource = null;
                return;
            }
            var filtered = designations.Where(d => d.DepartmentId == selectedDepartment.Id).ToList();
            dgvDesignations.DataSource = filtered;
        }

        // ---------- Department Events ----------
        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDepartment = (Department)dgvDepartments.Rows[e.RowIndex].DataBoundItem;
                BindDesignationsGrid();
                btnEditDept.Enabled = true;
                btnDeleteDept.Enabled = true;
            }
        }

        private void btnNewDept_Click(object sender, EventArgs e)
        {
            // Reset all state for new department
            editingDeptId = 0;
            selectedDepartment = null;
            txtDeptName.Clear();
            txtDeptSection.Clear();
            txtManagerId.Clear();
            gbDeptForm.Visible = true;
            gbDeptForm.BringToFront();
        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Please select a department first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            editingDeptId = selectedDepartment.Id;
            txtDeptName.Text = selectedDepartment.Name;
            txtDeptSection.Text = selectedDepartment.Section;
            txtManagerId.Text = selectedDepartment.ManagerId;
            gbDeptForm.Visible = true;
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null) return;
            if (selectedDepartment.EmployeeCount > 0)
            {
                MessageBox.Show($"Cannot delete department '{selectedDepartment.Name}' because it has {selectedDepartment.EmployeeCount} employee(s).", "Business Rule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var linkedDesignations = designations.Where(d => d.DepartmentId == selectedDepartment.Id).ToList();
            string msg = linkedDesignations.Count > 0
                ? $"Department has {linkedDesignations.Count} designation(s). Deleting will also remove them. Proceed?"
                : $"Delete department '{selectedDepartment.Name}'?";
            if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                designations.RemoveAll(d => d.DepartmentId == selectedDepartment.Id);
                departments.Remove(selectedDepartment);
                selectedDepartment = departments.FirstOrDefault();
                BindDepartmentsGrid();
                BindDesignationsGrid();
                btnEditDept.Enabled = (selectedDepartment != null);
                btnDeleteDept.Enabled = (selectedDepartment != null);
                MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveDept_Click(object sender, EventArgs e)
        {
            if (isSaving) return;
            isSaving = true;
            try
            {
                string newName = txtDeptName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Department name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ----- Duplicate check (case-insensitive) -----
                bool duplicateExists;
                if (editingDeptId == 0) // New department
                {
                    duplicateExists = departments.Any(d => d.Name.Equals(newName, StringComparison.OrdinalIgnoreCase));
                }
                else // Edit department
                {
                    duplicateExists = departments.Any(d => d.Id != editingDeptId && d.Name.Equals(newName, StringComparison.OrdinalIgnoreCase));
                }

                if (duplicateExists)
                {
                    MessageBox.Show($"A department named '{newName}' already exists. Please choose a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ----- Save or Update -----
                if (editingDeptId == 0) // Add new
                {
                    var newDept = new Department
                    {
                        Id = nextDeptId++,
                        Name = newName,
                        Section = txtDeptSection.Text.Trim(),
                        ManagerId = txtManagerId.Text.Trim(),
                        EmployeeCount = 0
                    };
                    departments.Add(newDept);
                    selectedDepartment = newDept;
                    MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Update existing
                {
                    var dept = departments.FirstOrDefault(d => d.Id == editingDeptId);
                    if (dept != null)
                    {
                        dept.Name = newName;
                        dept.Section = txtDeptSection.Text.Trim();
                        dept.ManagerId = txtManagerId.Text.Trim();
                        selectedDepartment = dept;
                        MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                BindDepartmentsGrid();
                BindDesignationsGrid();
                gbDeptForm.Visible = false;

                // Reset editing mode
                editingDeptId = 0;
                btnEditDept.Enabled = true;
                btnDeleteDept.Enabled = true;
            }
            finally
            {
                isSaving = false;
            }
        }

        private void btnCancelDept_Click(object sender, EventArgs e)
        {
            gbDeptForm.Visible = false;
            editingDeptId = 0;  // Important: reset edit mode on cancel
        }

        // ---------- Designation Helpers ----------
        private void PopulateDepartmentCombo()
        {
            cmbDesigDepartment.DataSource = null;
            cmbDesigDepartment.DataSource = departments.ToList();
            cmbDesigDepartment.DisplayMember = "Name";
            cmbDesigDepartment.ValueMember = "Id";
        }

        private void dgvDesignations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDesignation = (Designation)dgvDesignations.Rows[e.RowIndex].DataBoundItem;
                btnEditDesig.Enabled = true;
                btnDeleteDesig.Enabled = true;
            }
        }

        private void btnNewDesig_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Please select a department first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            editingDesigId = 0;
            txtDesigTitle.Clear();
            PopulateDepartmentCombo();
            cmbDesigDepartment.SelectedValue = selectedDepartment.Id;
            gbDesigForm.Visible = true;
        }

        private void btnEditDesig_Click(object sender, EventArgs e)
        {
            if (selectedDesignation == null) return;
            editingDesigId = selectedDesignation.Id;
            txtDesigTitle.Text = selectedDesignation.Title;
            PopulateDepartmentCombo();
            cmbDesigDepartment.SelectedValue = selectedDesignation.DepartmentId;
            gbDesigForm.Visible = true;
        }

        private void btnDeleteDesig_Click(object sender, EventArgs e)
        {
            if (selectedDesignation == null) return;
            if (selectedDesignation.AssignedEmployeesCount > 0)
            {
                MessageBox.Show($"Cannot delete designation '{selectedDesignation.Title}' because {selectedDesignation.AssignedEmployeesCount} employee(s) are assigned.", "Business Rule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Delete designation '{selectedDesignation.Title}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                designations.Remove(selectedDesignation);
                selectedDesignation = null;
                BindDesignationsGrid();
                btnEditDesig.Enabled = false;
                btnDeleteDesig.Enabled = false;
                MessageBox.Show("Designation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveDesig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesigTitle.Text))
            {
                MessageBox.Show("Designation title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbDesigDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int deptId = (int)cmbDesigDepartment.SelectedValue;

            if (editingDesigId == 0) // Add new
            {
                if (designations.Any(d => d.DepartmentId == deptId && d.Title.Equals(txtDesigTitle.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This designation already exists in the selected department.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newDesig = new Designation
                {
                    Id = nextDesigId++,
                    Title = txtDesigTitle.Text.Trim(),
                    DepartmentId = deptId,
                    AssignedEmployeesCount = 0,
                    DepartmentName = departments.First(d => d.Id == deptId).Name
                };
                designations.Add(newDesig);
                MessageBox.Show("Designation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Edit
            {
                var desig = designations.FirstOrDefault(d => d.Id == editingDesigId);
                if (desig != null)
                {
                    desig.Title = txtDesigTitle.Text.Trim();
                    desig.DepartmentId = deptId;
                    desig.DepartmentName = departments.First(d => d.Id == deptId).Name;
                    MessageBox.Show("Designation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            BindDesignationsGrid();
            gbDesigForm.Visible = false;
        }

        private void btnCancelDesig_Click(object sender, EventArgs e)
        {
            gbDesigForm.Visible = false;
            editingDesigId = 0;
        }
    }

    // Model classes
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public string ManagerId { get; set; }
        public int EmployeeCount { get; set; }
    }

    public class Designation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public int AssignedEmployeesCount { get; set; }
        public string DepartmentName { get; set; }
    }
}