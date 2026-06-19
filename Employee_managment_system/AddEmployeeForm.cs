using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class AddEmployeeForm : Form
    {
        private List<EmployeeForm.Employee> employees;
        private List<EmployeeForm.Department> departments;
        private List<EmployeeForm.Designation> designations;
        private int nextEmpId;
        private string newPhotoBase64 = null;
        private EmployeeForm parentForm;
        private string generatedPassword;
        private Random random = new Random();

        public AddEmployeeForm(
            List<EmployeeForm.Employee> empList,
            List<EmployeeForm.Department> deptList,
            List<EmployeeForm.Designation> desigList,
            int nextId,
            EmployeeForm parent)
        {
            InitializeComponent();
            employees = empList;
            departments = deptList;
            designations = desigList;
            nextEmpId = nextId;
            parentForm = parent;

            // Set default dates
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = DateTime.Now;

            // Load dropdowns
            LoadDropdowns();

            // Auto-generate password
            generatedPassword = GenerateRandomPassword();
            lblGeneratedPassword.Text = generatedPassword;

            // Attach events
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            btnUploadPhoto.Click += BtnUploadPhoto_Click;
            btnRegeneratePassword.Click += BtnRegeneratePassword_Click;
            cmbDepartment.SelectedIndexChanged += CmbDepartment_SelectedIndexChanged;

            // Trigger initial designation load
            if (cmbDepartment.Items.Count > 0)
                cmbDepartment.SelectedIndex = 0;
        }

        private string GenerateRandomPassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*";

            // Ensure at least one character from each category
            string password = "";
            password += upperChars[random.Next(upperChars.Length)];
            password += lowerChars[random.Next(lowerChars.Length)];
            password += digits[random.Next(digits.Length)];
            password += specialChars[random.Next(specialChars.Length)];

            // Fill remaining characters to make 10 chars total
            string allChars = upperChars + lowerChars + digits + specialChars;
            for (int i = password.Length; i < 10; i++)
            {
                password += allChars[random.Next(allChars.Length)];
            }

            // Shuffle the password
            return new string(password.ToCharArray().OrderBy(x => random.Next()).ToArray());
        }

        private void BtnRegeneratePassword_Click(object sender, EventArgs e)
        {
            generatedPassword = GenerateRandomPassword();
            lblGeneratedPassword.Text = generatedPassword;
        }

        private void LoadDropdowns()
        {
            // Department combo
            if (departments != null && departments.Count > 0)
            {
                cmbDepartment.DataSource = null;
                cmbDepartment.DataSource = departments.ToList();
                cmbDepartment.DisplayMember = "Name";
                cmbDepartment.ValueMember = "Id";
            }

            // Gender combo
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });
            if (cmbGender.Items.Count > 0) cmbGender.SelectedIndex = 0;

            // Category combo
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new[] { "Permanent", "Contract", "Intern", "Temporary" });
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;

            // Status combo
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new[] { "Active", "Inactive" });
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue != null && cmbDepartment.SelectedValue is int deptId)
            {
                var filtered = designations.Where(d => d.DepartmentId == deptId).ToList();
                cmbDesignation.DataSource = filtered;
                cmbDesignation.DisplayMember = "Title";
                cmbDesignation.ValueMember = "Id";
                cmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                cmbDesignation.DataSource = null;
            }
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.bmp;*.jpeg" })
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

        private string GenerateEmployeeCode()
        {
            int max = employees.Any() ? employees.Max(e => int.Parse(e.EmployeeCode.Substring(3))) : 0;
            return "EMP" + (max + 1).ToString("D3");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            { MessageBox.Show("First name and last name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbDepartment.SelectedValue == null)
            { MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Email validation
            if (!IsValidEmail(txtEmail.Text.Trim()))
            { MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Duplicate checks
            if (!string.IsNullOrEmpty(txtNIC.Text) && employees.Any(emp => emp.NIC == txtNIC.Text.Trim()))
            { MessageBox.Show("NIC already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (employees.Any(emp => emp.Email.Equals(txtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            { MessageBox.Show("Email already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string employeeCode = GenerateEmployeeCode();

            // Create employee
            var newEmp = new EmployeeForm.Employee
            {
                Id = nextEmpId,
                EmployeeCode = employeeCode,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Gender = cmbGender.Text,
                NIC = txtNIC.Text.Trim(),
                DOB = dtpDOB.Value,
                JoinDate = dtpJoinDate.Value,
                ContactNo = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Category = cmbCategory.Text,
                DepartmentId = (int)cmbDepartment.SelectedValue,
                DesignationId = cmbDesignation.SelectedValue as int?,
                BasicSalary = decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0,
                Address = txtAddress.Text,
                Status = cmbStatus.Text,
                PhotoBase64 = newPhotoBase64,
                DepartmentName = departments.First(d => d.Id == (int)cmbDepartment.SelectedValue).Name,
                DesignationTitle = designations.FirstOrDefault(d => d.Id == (int?)cmbDesignation.SelectedValue)?.Title
            };

            // Update username display with actual employee code
            lblGeneratedUsername.Text = employeeCode;

            // Add employee with auto-generated credentials
            parentForm.AddEmployeeWithCredentials(newEmp, generatedPassword);

            MessageBox.Show($"Employee added successfully!\n\nUsername: {employeeCode}\nPassword: {generatedPassword}\n\nCredentials have been sent to {newEmp.Email}",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

