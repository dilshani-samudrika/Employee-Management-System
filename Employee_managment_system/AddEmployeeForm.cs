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
    public partial class AddEmployeeForm : Form
    {
        private List<EmployeeForm.Employee> employees;
        private List<EmployeeForm.Department> departments;
        private List<EmployeeForm.Designation> designations;
        private EmployeeForm parentForm;
        private string? newPhotoBase64 = null;
        private string? generatedEmployeeCode = null; // Store employee code here

        public AddEmployeeForm(
            List<EmployeeForm.Employee> employees,
            List<EmployeeForm.Department> departments,
            List<EmployeeForm.Designation> designations,
            EmployeeForm parentForm)
        {
            InitializeComponent();
            this.employees = employees;
            this.departments = departments;
            this.designations = designations;
            this.parentForm = parentForm;

            LoadCombos();
            GenerateEmployeeCode();
            SetDefaultDates();


        }

        private void LoadCombos()
        {
            // Department combo
            cmbDepartment.DataSource = null;
            cmbDepartment.DataSource = departments.ToList();
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptID";

            // Gender combo
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.SelectedIndex = 0;

            // Category combo
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[] { "Permanent", "Contract", "Intern", "Temporary" });
            cmbCategory.SelectedIndex = 0;

            // Status combo
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;
        }

        private void GenerateEmployeeCode()
        {
            try
            {
                string query = "SELECT 'EMP' + RIGHT('000' + CAST(ISNULL(MAX(EmployeeID), 0) + 1 AS VARCHAR(3)) FROM Employees";
                object? result = DatabaseHelper.ExecuteScalar(query);
                generatedEmployeeCode = result?.ToString() ?? "EMP001";
            }
            catch
            {
                generatedEmployeeCode = "EMP001";
            }
        }

        private void SetDefaultDates()
        {
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = DateTime.Now;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading photo: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (!ValidateInput())
                return;

            try
            {
                string fullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}";

                // First check if NIC already exists
                if (!string.IsNullOrWhiteSpace(txtNIC.Text))
                {
                    string checkNIC = "SELECT COUNT(*) FROM Employees WHERE NIC = @NIC";
                    SqlParameter[] nicParams = { new SqlParameter("@NIC", txtNIC.Text.Trim()) };
                    int nicCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkNIC, nicParams));
                    if (nicCount > 0)
                    {
                        MessageBox.Show("NIC already exists in the system. Please check the data.",
                                      "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNIC.Focus();
                        txtNIC.SelectAll();
                        return;
                    }
                }

                // Check if Email already exists
                string checkEmail = "SELECT COUNT(*) FROM Employees WHERE Email = @Email";
                SqlParameter[] emailParams = { new SqlParameter("@Email", txtEmail.Text.Trim()) };
                int emailCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkEmail, emailParams));
                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists in the system. Please check the data.",
                                  "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }

                // Regenerate code to ensure no duplicate
                GenerateEmployeeCode();

#pragma warning disable CS0618 // Type or member is obsolete
                string query = @"
            INSERT INTO Employees (
                EmpNo, FullName, Gender, DateOfBirth, NIC, ContactNo, Email,
                Address, DeptID, DesignationID, JoinedDate, BasicSalary, Category, PhotoBase64
            ) VALUES (
                @EmpNo, @FullName, @Gender, @DateOfBirth, @NIC, @ContactNo, @Email,
                @Address, @DeptID, @DesignationID, @JoinedDate, @BasicSalary, @Category, @PhotoBase64
            )";

                SqlParameter[] parameters = {
            new SqlParameter("@EmpNo", generatedEmployeeCode ?? "EMP001"),
            new SqlParameter("@FullName", fullName),
            new SqlParameter("@Gender", (object?)cmbGender.Text ?? DBNull.Value),
            new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
            new SqlParameter("@NIC", (object?)txtNIC.Text.Trim() ?? DBNull.Value),
            new SqlParameter("@ContactNo", (object?)txtContact.Text.Trim() ?? DBNull.Value),
            new SqlParameter("@Email", txtEmail.Text.Trim()),
            new SqlParameter("@Address", (object?)txtAddress.Text.Trim() ?? DBNull.Value),
            new SqlParameter("@DeptID", (int)cmbDepartment.SelectedValue),
            new SqlParameter("@DesignationID", cmbDesignation.SelectedValue != null ? (object)(int)cmbDesignation.SelectedValue : DBNull.Value),
            new SqlParameter("@JoinedDate", dtpJoinDate.Value.Date),
            new SqlParameter("@BasicSalary", decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0),
            new SqlParameter("@Category", (object?)cmbCategory.Text ?? DBNull.Value),
            new SqlParameter("@PhotoBase64", (object?)newPhotoBase64 ?? DBNull.Value)
        };
#pragma warning restore CS0618

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Employee {generatedEmployeeCode} added successfully!",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("Duplicate entry detected. Employee Code, NIC, or Email already exists.",
                                  "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving employee: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // First Name validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // Last Name validation
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Email format validation
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            // Department validation
            if (cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            // NIC validation (optional but if entered, check format)
            if (!string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                if (!IsValidNIC(txtNIC.Text))
                {
                    MessageBox.Show("Please enter a valid NIC (e.g., 990123456V or 199901234567).",
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNIC.Focus();
                    txtNIC.SelectAll();
                    return false;
                }
            }

            // Contact validation (optional but if entered, check format)
            if (!string.IsNullOrWhiteSpace(txtContact.Text))
            {
                if (!IsValidContact(txtContact.Text))
                {
                    MessageBox.Show("Please enter a valid contact number (e.g., 0712345678).",
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContact.Focus();
                    txtContact.SelectAll();
                    return false;
                }
            }

            // Salary validation (optional but if entered, check it's a number)
            if (!string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                if (!decimal.TryParse(txtSalary.Text, out _))
                {
                    MessageBox.Show("Please enter a valid salary amount.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalary.Focus();
                    txtSalary.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Trim and check for basic email pattern
            string trimmed = email.Trim();

            // Must have @ and at least one . after @
            return trimmed.Contains("@") &&
                   trimmed.IndexOf("@") > 0 &&
                   trimmed.LastIndexOf(".") > trimmed.IndexOf("@") &&
                   trimmed.LastIndexOf(".") < trimmed.Length - 1;
        }

        private bool IsValidNIC(string nic)
        {
            // Sri Lankan NIC format: 9 digits + V (old) OR 12 digits (new)
            if (string.IsNullOrWhiteSpace(nic))
                return false;

            nic = nic.Trim().ToUpper();
            return (nic.Length == 10 && nic.EndsWith("V") && nic.Substring(0, 9).All(char.IsDigit)) ||
                   (nic.Length == 12 && nic.All(char.IsDigit));
        }

        private bool IsValidContact(string contact)
        {
            // Sri Lankan contact: 10 digits starting with 0
            if (string.IsNullOrWhiteSpace(contact))
                return false;

            contact = contact.Trim();
            return contact.Length == 10 && contact.All(char.IsDigit) && contact.StartsWith("0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                var result = MessageBox.Show("You have unsaved changes. Are you sure you want to cancel?",
                             "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool HasUnsavedChanges()
        {
            return !string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                   !string.IsNullOrWhiteSpace(txtLastName.Text) ||
                   !string.IsNullOrWhiteSpace(txtNIC.Text) ||
                   !string.IsNullOrWhiteSpace(txtContact.Text) ||
                   !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   !string.IsNullOrWhiteSpace(txtSalary.Text) ||
                   !string.IsNullOrWhiteSpace(txtAddress.Text) ||
                   newPhotoBase64 != null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset all fields without closing the form
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtSalary.Clear();
            txtAddress.Clear();

            cmbGender.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = -1;
            cmbDesignation.DataSource = null;

            dtpDOB.Value = DateTime.Now.AddYears(-25);
            dtpJoinDate.Value = DateTime.Now;

            picEmployeePhoto.Image = null;
            newPhotoBase64 = null;
            GenerateEmployeeCode();
        }
    }
}