using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class EmployeeForm : Form
    {
        // Models
        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Designation
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int DepartmentId { get; set; }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string EmployeeCode { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public string NIC { get; set; }
            public DateTime? DOB { get; set; }
            public DateTime? JoinDate { get; set; }
            public string ContactNo { get; set; }
            public string Email { get; set; }
            public string Category { get; set; }
            public int DepartmentId { get; set; }
            public int? DesignationId { get; set; }
            public decimal BasicSalary { get; set; }
            public string Address { get; set; }
            public string Status { get; set; }
            public string PhotoBase64 { get; set; }
            public string DepartmentName { get; set; }
            public string DesignationTitle { get; set; }
        }

        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public string Role { get; set; }
            public bool IsActive { get; set; }
            public int? EmployeeId { get; set; }
            public bool MustChangePassword { get; set; }
            public string TemporaryPassword { get; set; } // For display only
        }

        // Data storage
        private List<Employee> employees = new List<Employee>();
        private List<Department> departments = new List<Department>();
        private List<Designation> designations = new List<Designation>();
        private List<User> users = new List<User>();
        private int nextEmpId = 1001;
        private int nextUserId = 1;

        private Employee selectedEmployee = null;
        private string newPhotoBase64 = null;
        private string currentUserRole = "Admin"; // This would come from login

        public EmployeeForm(string userRole = "Admin")
        {
            InitializeComponent();
            currentUserRole = userRole;

            LoadMasterData();
            LoadSampleEmployees();
            LoadSampleUsers();
            ConfigureGrid();
            LoadFilterDropdowns();
            LoadFormCombos();
            RefreshGrid();

            // Apply RBAC restrictions
            ApplyRoleBasedAccess();

            // Events
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnExport.Click += BtnExport_Click;
            txtSearch.TextChanged += (s, e) => RefreshGrid();
            cmbDeptFilter.SelectedIndexChanged += (s, e) => RefreshGrid();
            cmbStatusFilter.SelectedIndexChanged += (s, e) => RefreshGrid();
            dgvEmployees.SelectionChanged += DgvEmployees_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { pnlRightPanel.Visible = false; selectedEmployee = null; };
            btnUploadPhoto.Click += BtnUploadPhoto_Click;
            cmbDepartment.SelectedIndexChanged += CmbDepartment_SelectedIndexChanged;
        }

        private void ApplyRoleBasedAccess()
        {
            switch (currentUserRole)
            {
                case "Admin":
                    // Full access - enable everything
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                    btnExport.Visible = true;
                    btnSave.Visible = true;
                    break;

                case "HR Officer":
                    // HR Officer - can manage employees but not delete users
                    btnAdd.Visible = true;
                    btnDelete.Visible = false; // Cannot delete employees
                    btnExport.Visible = true;
                    btnSave.Visible = true;
                    // Cannot modify admin accounts
                    break;

                case "Employee":
                    // Employee - view only their own profile
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnExport.Visible = false;
                    btnSave.Visible = false;
                    txtSearch.Enabled = false;
                    cmbDeptFilter.Enabled = false;
                    cmbStatusFilter.Enabled = false;
                    // Show only current employee
                    break;
            }
        }

        private void LoadMasterData()
        {
            departments = new List<Department>
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Finance" },
                new Department { Id = 4, Name = "Marketing" },
                new Department { Id = 5, Name = "Operations" }
            };

            designations = new List<Designation>
            {
                new Designation { Id = 1, Title = "Developer", DepartmentId = 1 },
                new Designation { Id = 2, Title = "Manager", DepartmentId = 1 },
                new Designation { Id = 3, Title = "HR Generalist", DepartmentId = 2 },
                new Designation { Id = 4, Title = "HR Manager", DepartmentId = 2 },
                new Designation { Id = 5, Title = "Accountant", DepartmentId = 3 },
                new Designation { Id = 6, Title = "Finance Manager", DepartmentId = 3 }
            };
        }

        private void LoadSampleEmployees()
        {
            employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1001, EmployeeCode = "EMP001", FirstName = "John", LastName = "Doe",
                    Gender = "Male", NIC = "990123456V", DOB = new DateTime(1999,1,1),
                    JoinDate = new DateTime(2022,1,1),
                    ContactNo = "0712345678", Email = "john.doe@example.com", Category = "Permanent",
                    DepartmentId = 1, DesignationId = 1, BasicSalary = 50000,
                    Address = "Colombo", Status = "Active",
                    DepartmentName = "IT", DesignationTitle = "Developer", PhotoBase64 = null
                },
                new Employee
                {
                    Id = 1002, EmployeeCode = "EMP002", FirstName = "Jane", LastName = "Smith",
                    Gender = "Female", NIC = "880234567V", DOB = new DateTime(1988,5,15),
                    JoinDate = new DateTime(2021,6,15),
                    ContactNo = "0723456789", Email = "jane.smith@example.com", Category = "Permanent",
                    DepartmentId = 2, DesignationId = 3, BasicSalary = 48000,
                    Address = "Kandy", Status = "Active",
                    DepartmentName = "HR", DesignationTitle = "HR Generalist", PhotoBase64 = null
                }
            };
            nextEmpId = employees.Max(e => e.Id) + 1;
        }

        private void LoadSampleUsers()
        {
            users = new List<User>
            {
                new User { UserId = 1, Username = "admin", PasswordHash = HashPassword("admin123"),
                           Role = "Admin", IsActive = true, EmployeeId = null, MustChangePassword = false },
                new User { UserId = 2, Username = "EMP001", PasswordHash = HashPassword("emp123"),
                           Role = "Employee", IsActive = true, EmployeeId = 1001, MustChangePassword = false },
                new User { UserId = 3, Username = "hr01", PasswordHash = HashPassword("hr123"),
                           Role = "HR Officer", IsActive = true, EmployeeId = null, MustChangePassword = false }
            };
            nextUserId = users.Max(u => u.UserId) + 1;
        }

        // Password hashing for security
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Generate random secure password
        private string GenerateRandomPassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*";

            Random random = new Random();

            // Ensure at least one character from each category
            string password = "";
            password += upperChars[random.Next(upperChars.Length)];
            password += lowerChars[random.Next(lowerChars.Length)];
            password += digits[random.Next(digits.Length)];
            password += specialChars[random.Next(specialChars.Length)];

            // Fill remaining characters
            string allChars = upperChars + lowerChars + digits + specialChars;
            for (int i = password.Length; i < 10; i++)
            {
                password += allChars[random.Next(allChars.Length)];
            }

            // Shuffle the password
            return new string(password.ToCharArray().OrderBy(x => random.Next()).ToArray());
        }

        // Send email with credentials
        private void SendCredentialsEmail(string toEmail, string username, string password, string employeeName)
        {
            try
            {
                // Configure SMTP (Update with your email settings)
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your_email@gmail.com", "your_app_password"),
                    EnableSsl = true,
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("hr@ems.com"),
                    Subject = "Your Employee Management System Login Credentials",
                    Body = $@"
Dear {employeeName},

Your EMS account has been created successfully.

Login Credentials:
------------------------
Username: {username}
Temporary Password: {password}

Please login and change your password immediately for security purposes.

If you have any issues, please contact HR.

Best regards,
HR Department
Employee Management System
",
                    IsBodyHtml = false,
                };

                mail.To.Add(toEmail);

                // Uncomment to actually send email
                // smtpClient.Send(mail);

                MessageBox.Show($"Credentials would be sent to {toEmail}\n\nUsername: {username}\nPassword: {password}",
                              "Email Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email sending failed: {ex.Message}\n\nUsername: {username}\nPassword: {password}",
                              "Manual Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Create user account for employee
        private void CreateUserAccount(Employee employee, string plainPassword)
        {
            var newUser = new User
            {
                UserId = nextUserId++,
                Username = employee.EmployeeCode,  // Username = EmployeeCode
                PasswordHash = HashPassword(plainPassword),
                Role = "Employee",
                IsActive = true,
                EmployeeId = employee.Id,
                MustChangePassword = true
            };

            users.Add(newUser);
        }

        private void ConfigureGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in dgvEmployees.Columns)
            {
                switch (col.Name)
                {
                    case "colEmployeeCode": col.DataPropertyName = "EmployeeCode"; break;
                    case "colFirstName": col.DataPropertyName = "FirstName"; break;
                    case "colLastName": col.DataPropertyName = "LastName"; break;
                    case "colDepartment": col.DataPropertyName = "DepartmentName"; break;
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
                cmbDeptFilter.Items.Add(d.Name);
            if (cmbDeptFilter.Items.Count > 0)
                cmbDeptFilter.SelectedIndex = 0;

            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.AddRange(new[] { "All", "Active", "Inactive" });
            if (cmbStatusFilter.Items.Count > 0)
                cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadFormCombos()
        {
            cmbDepartment.DataSource = null;
            cmbDepartment.DataSource = departments.ToList();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });
            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0;

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new[] { "Permanent", "Contract", "Intern", "Temporary" });
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new[] { "Active", "Inactive" });
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue is int deptId)
            {
                var filtered = designations.Where(d => d.DepartmentId == deptId).ToList();
                cmbDesignation.DataSource = filtered;
                cmbDesignation.DisplayMember = "Title";
                cmbDesignation.ValueMember = "Id";
            }
            else
                cmbDesignation.DataSource = null;
        }

        private void RefreshGrid()
        {
            var filtered = employees.AsEnumerable();

            // For Employee role, only show their own record
            if (currentUserRole == "Employee")
            {
                var currentEmployee = employees.FirstOrDefault(e => e.Email == "current_employee_email");
                if (currentEmployee != null)
                    filtered = new List<Employee> { currentEmployee };
            }

            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(e =>
                    e.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.LastName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.EmployeeCode.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    e.Email.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (cmbDeptFilter.SelectedIndex > 0 && cmbDeptFilter.SelectedItem != null)
            {
                string dept = cmbDeptFilter.SelectedItem.ToString();
                filtered = filtered.Where(e => e.DepartmentName == dept);
            }

            if (cmbStatusFilter.SelectedIndex > 0 && cmbStatusFilter.SelectedItem != null)
            {
                string status = cmbStatusFilter.SelectedItem.ToString();
                filtered = filtered.Where(e => e.Status == status);
            }

            dgvEmployees.DataSource = filtered.ToList();
        }

        private void DgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                selectedEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
                LoadEmployeeToPanel(selectedEmployee);
                pnlRightPanel.Visible = true;

                // Show delete button only for Admin
                btnDelete.Visible = (currentUserRole == "Admin");
            }
            else
            {
                pnlRightPanel.Visible = false;
                selectedEmployee = null;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Only Admin and HR Officer can add employees
            if (currentUserRole != "Admin" && currentUserRole != "HR Officer")
            {
                MessageBox.Show("You don't have permission to add employees.", "Access Denied",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var addForm = new AddEmployeeForm(employees, departments, designations, nextEmpId, this))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                    nextEmpId = employees.Max(emp => emp.Id) + 1;
                }
            }
        }

        // Method to add employee with auto-credentials (called from AddEmployeeForm)
        public void AddEmployeeWithCredentials(Employee newEmployee, string generatedPassword)
        {
            employees.Add(newEmployee);
            CreateUserAccount(newEmployee, generatedPassword);
            SendCredentialsEmail(newEmployee.Email, newEmployee.EmployeeCode, generatedPassword,
                               $"{newEmployee.FirstName} {newEmployee.LastName}");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Only Admin can delete employees
            if (currentUserRole != "Admin")
            {
                MessageBox.Show("You don't have permission to delete employees.", "Access Denied",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedEmployee == null) return;
            if (MessageBox.Show($"Delete {selectedEmployee.FirstName} {selectedEmployee.LastName}?\n\nThis will also delete the user account.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete associated user account
                var userToDelete = users.FirstOrDefault(u => u.EmployeeId == selectedEmployee.Id);
                if (userToDelete != null)
                    users.Remove(userToDelete);

                employees.Remove(selectedEmployee);
                RefreshGrid();
                pnlRightPanel.Visible = false;
                selectedEmployee = null;
                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Only Admin and HR Officer can edit employees
            if (currentUserRole != "Admin" && currentUserRole != "HR Officer")
            {
                MessageBox.Show("You don't have permission to edit employees.", "Access Denied",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedEmployee == null)
            {
                MessageBox.Show("No employee selected.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            { MessageBox.Show("First name and last name are required."); return; }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Email is required."); return; }
            if (cmbDepartment.SelectedValue == null)
            { MessageBox.Show("Please select a department."); return; }

            // Duplicate check for NIC/Email excluding current employee
            if (!string.IsNullOrEmpty(txtNIC.Text) && employees.Any(e => e.NIC == txtNIC.Text.Trim() && e.Id != selectedEmployee.Id))
            { MessageBox.Show("NIC already exists for another employee."); return; }
            if (employees.Any(e => e.Email.Equals(txtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase) && e.Id != selectedEmployee.Id))
            { MessageBox.Show("Email already exists for another employee."); return; }

            // Update selected employee
            selectedEmployee.FirstName = txtFirstName.Text.Trim();
            selectedEmployee.LastName = txtLastName.Text.Trim();
            selectedEmployee.Gender = cmbGender.Text;
            selectedEmployee.NIC = txtNIC.Text.Trim();
            selectedEmployee.DOB = dtpDOB.Value;
            selectedEmployee.JoinDate = dtpJoinDate.Value;
            selectedEmployee.ContactNo = txtContact.Text.Trim();
            selectedEmployee.Email = txtEmail.Text.Trim();
            selectedEmployee.Category = cmbCategory.Text;
            selectedEmployee.DepartmentId = (int)cmbDepartment.SelectedValue;
            selectedEmployee.DesignationId = cmbDesignation.SelectedValue as int?;
            selectedEmployee.BasicSalary = decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0;
            selectedEmployee.Address = txtAddress.Text;
            selectedEmployee.Status = cmbStatus.Text;
            if (newPhotoBase64 != null)
                selectedEmployee.PhotoBase64 = newPhotoBase64;
            selectedEmployee.DepartmentName = departments.First(d => d.Id == selectedEmployee.DepartmentId).Name;
            selectedEmployee.DesignationTitle = designations.FirstOrDefault(d => d.Id == selectedEmployee.DesignationId)?.Title;

            RefreshGrid();
            LoadEmployeeToPanel(selectedEmployee);
            MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            // Only Admin and HR Officer can export reports
            if (currentUserRole != "Admin" && currentUserRole != "HR Officer")
            {
                MessageBox.Show("You don't have permission to export employee data.", "Access Denied",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Employees.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var data = (List<Employee>)dgvEmployees.DataSource;
                    var lines = new List<string> { "EmpCode,FullName,Department,Designation,NIC,Contact,Status,Email,Salary" };
                    foreach (var emp in data)
                    {
                        lines.Add($"\"{emp.EmployeeCode}\",\"{emp.FirstName} {emp.LastName}\",\"{emp.DepartmentName}\",\"{emp.DesignationTitle}\",\"{emp.NIC}\",\"{emp.ContactNo}\",\"{emp.Status}\",\"{emp.Email}\",{emp.BasicSalary}");
                    }
                    File.WriteAllLines(sfd.FileName, lines);
                    MessageBox.Show("Exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] bytes = File.ReadAllBytes(ofd.FileName);
                    newPhotoBase64 = Convert.ToBase64String(bytes);
                    using (var ms = new MemoryStream(bytes))
                        picEmployeePhoto.Image = Image.FromStream(ms);
                }
            }
        }

        private void LoadEmployeeToPanel(Employee emp)
        {
            txtFirstName.Text = emp.FirstName;
            txtLastName.Text = emp.LastName;
            txtNIC.Text = emp.NIC;
            txtContact.Text = emp.ContactNo;
            txtEmail.Text = emp.Email;
            txtSalary.Text = emp.BasicSalary.ToString("0.00");
            txtAddress.Text = emp.Address;
            dtpDOB.Value = emp.DOB ?? DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = emp.JoinDate ?? DateTime.Now;
            cmbGender.Text = emp.Gender;
            cmbCategory.Text = emp.Category;
            cmbStatus.Text = emp.Status;
            cmbDepartment.SelectedValue = emp.DepartmentId;

            var filtered = designations.Where(d => d.DepartmentId == emp.DepartmentId).ToList();
            cmbDesignation.DataSource = filtered;
            cmbDesignation.DisplayMember = "Title";
            cmbDesignation.ValueMember = "Id";
            if (emp.DesignationId.HasValue)
                cmbDesignation.SelectedValue = emp.DesignationId.Value;

            if (!string.IsNullOrEmpty(emp.PhotoBase64))
            {
                byte[] bytes = Convert.FromBase64String(emp.PhotoBase64);
                using (var ms = new MemoryStream(bytes))
                    picEmployeePhoto.Image = Image.FromStream(ms);
            }
            else
                picEmployeePhoto.Image = null;
            newPhotoBase64 = null;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void filterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}