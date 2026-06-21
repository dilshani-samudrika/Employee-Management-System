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
        private string? generatedEmployeeCode = null;

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

            cmbDepartment.SelectedIndexChanged += new EventHandler(cmbDepartment_SelectedIndexChanged);
            cmbDesignation.SelectedIndexChanged += new EventHandler(cmbDesignation_SelectedIndexChanged);
        }

        private void LoadCombos()
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

            cmbDesignation.DataSource = null;
        }

        private void GenerateEmployeeCode()
        {
            try
            {
                string query = "SELECT MAX(EmpNo) FROM Employees";
                object? result = DatabaseHelper.ExecuteScalar(query);

                if (result == null || result == DBNull.Value)
                {
                    generatedEmployeeCode = "EMP001";
                }
                else
                {
                    string maxEmpNo = result.ToString()!;
                    if (string.IsNullOrEmpty(maxEmpNo) || !maxEmpNo.StartsWith("EMP"))
                    {
                        generatedEmployeeCode = "EMP001";
                    }
                    else
                    {
                        string numberPart = maxEmpNo.Replace("EMP", "");
                        if (int.TryParse(numberPart, out int number))
                        {
                            number++;
                            generatedEmployeeCode = $"EMP{number:D3}";
                        }
                        else
                        {
                            generatedEmployeeCode = "EMP001";
                        }
                    }
                }
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
            if (cmbDepartment.SelectedValue != null && cmbDepartment.SelectedValue is int deptId)
            {
                var filtered = designations.Where(d => d.DeptID == deptId).ToList();
                cmbDesignation.DataSource = filtered;
                cmbDesignation.DisplayMember = "Title";
                cmbDesignation.ValueMember = "DesignationID";

                // Reset salary when department changes
                txtSalary.Text = "";
                txtSalary.BackColor = SystemColors.Window;
            }
            else
            {
                cmbDesignation.DataSource = null;
                txtSalary.Text = "";
                txtSalary.BackColor = SystemColors.Window;
            }
        }

        // AUTO-FILL SALARY WHEN DESIGNATION CHANGES 
        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesignation.SelectedItem != null)
            {
                var selectedDesignation = cmbDesignation.SelectedItem as EmployeeForm.Designation;

                if (selectedDesignation != null && selectedDesignation.BasicSalary > 0)
                {
                    txtSalary.Text = selectedDesignation.BasicSalary.ToString("N2");
                    txtSalary.BackColor = Color.FromArgb(255, 255, 224);
                }
                else
                {
                    txtSalary.Text = "";
                    txtSalary.BackColor = SystemColors.Window;
                }
            }
            else
            {
                txtSalary.Text = "";
                txtSalary.BackColor = SystemColors.Window;
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

        private bool ValidateAllInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            if (cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            if (cmbDesignation.SelectedValue == null)
            {
                MessageBox.Show("Please select a designation.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDesignation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Salary is required. Please select a designation or enter manually.",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out _))
            {
                MessageBox.Show("Please enter a valid salary amount.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                txtSalary.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                if (!IsValidNIC(txtNIC.Text))
                {
                    MessageBox.Show("Please enter a valid NIC.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNIC.Focus();
                    txtNIC.SelectAll();
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtContact.Text))
            {
                if (!IsValidContact(txtContact.Text))
                {
                    MessageBox.Show("Please enter a valid contact number.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContact.Focus();
                    txtContact.SelectAll();
                    return false;
                }
            }

            if (dtpDOB.Value > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Employee must be at least 16 years old.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDOB.Focus();
                return false;
            }

            if (dtpJoinDate.Value > DateTime.Now)
            {
                MessageBox.Show("Join date cannot be in the future.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpJoinDate.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string trimmed = email.Trim();
            return trimmed.Contains("@") &&
                   trimmed.IndexOf("@") > 0 &&
                   trimmed.LastIndexOf(".") > trimmed.IndexOf("@") &&
                   trimmed.LastIndexOf(".") < trimmed.Length - 1;
        }

        private bool IsValidNIC(string nic)
        {
            if (string.IsNullOrWhiteSpace(nic))
                return false;

            nic = nic.Trim().ToUpper();
            return (nic.Length == 10 && nic.EndsWith("V") && nic.Substring(0, 9).All(char.IsDigit)) ||
                   (nic.Length == 12 && nic.All(char.IsDigit));
        }

        private bool IsValidContact(string contact)
        {
            if (string.IsNullOrWhiteSpace(contact))
                return false;

            contact = contact.Trim();
            return contact.Length == 10 && contact.All(char.IsDigit) && contact.StartsWith("0");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateAllInputs())
                return;

            try
            {
                string fullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}";

                // Check NIC duplicate
                if (!string.IsNullOrWhiteSpace(txtNIC.Text))
                {
                    string checkNIC = "SELECT COUNT(*) FROM Employees WHERE NIC = @NIC";
                    SqlParameter[] nicParams = { new SqlParameter("@NIC", txtNIC.Text.Trim()) };
                    int nicCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkNIC, nicParams));
                    if (nicCount > 0)
                    {
                        MessageBox.Show("NIC already exists in the system.", "Duplicate Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNIC.Focus();
                        txtNIC.SelectAll();
                        return;
                    }
                }

                // Check Email duplicate
                string checkEmail = "SELECT COUNT(*) FROM Employees WHERE Email = @Email";
                SqlParameter[] emailParams = { new SqlParameter("@Email", txtEmail.Text.Trim()) };
                int emailCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkEmail, emailParams));
                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists in the system.", "Duplicate Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }

                GenerateEmployeeCode();

                string checkCode = "SELECT COUNT(*) FROM Employees WHERE EmpNo = @EmpNo";
                SqlParameter[] codeParams = { new SqlParameter("@EmpNo", generatedEmployeeCode) };
                int codeCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkCode, codeParams));
                if (codeCount > 0)
                {
                    generatedEmployeeCode = $"EMP{DateTime.Now:HHmmss}";
                }

                decimal salary = 0;
                decimal.TryParse(txtSalary.Text, out salary);

                string query = @"
                    INSERT INTO Employees (
                        EmpNo, FullName, Gender, DateOfBirth, NIC, ContactNo, Email,
                        Address, DeptID, DesignationID, JoinedDate, BasicSalary, Category, PhotoBase64, Status
                    ) VALUES (
                        @EmpNo, @FullName, @Gender, @DateOfBirth, @NIC, @ContactNo, @Email,
                        @Address, @DeptID, @DesignationID, @JoinedDate, @BasicSalary, @Category, @PhotoBase64, @Status
                    )";

                SqlParameter[] parameters = {
                    new SqlParameter("@EmpNo", generatedEmployeeCode),
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@Gender", (object?)cmbGender.Text ?? DBNull.Value),
                    new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                    new SqlParameter("@NIC", (object?)txtNIC.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@ContactNo", (object?)txtContact.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Address", (object?)txtAddress.Text.Trim() ?? DBNull.Value),
                    new SqlParameter("@DeptID", (int)cmbDepartment.SelectedValue),
                    new SqlParameter("@DesignationID", (int)cmbDesignation.SelectedValue),
                    new SqlParameter("@JoinedDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@BasicSalary", salary),
                    new SqlParameter("@Category", (object?)cmbCategory.Text ?? DBNull.Value),
                    new SqlParameter("@PhotoBase64", (object?)newPhotoBase64 ?? DBNull.Value),
                    new SqlParameter("@Status", cmbStatus.Text)
                };

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
                if (ex.Number == 2627)
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
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtSalary.Text = "";
            txtSalary.BackColor = SystemColors.Window;
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