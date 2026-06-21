using System;
using System.Windows.Forms;

namespace Employee_managment_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            chkShowPassword.Checked = false;
            txtUsername.Focus();

            bool adminCreated = AuthService.CreateAdminUserIfNeeded();

            if (adminCreated)
            {
                MessageBox.Show(
                    "No users found in the system.\n\n" +
                    "Default admin account has been created.\n" +
                    "Username: admin\n" +
                    "Password: 123456\n\n" +
                    "Please login and change your password immediately!",
                    "First Time Setup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                if (!DatabaseHelper.TestConnection())
                {
                    MessageBox.Show("Cannot connect to database.\n\nPlease check:\n1. SQL Server is running\n2. Database 'EMS_DB' exists",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = true;
                    btnLogin.Text = "Login";
                    return;
                }

                var result = AuthService.Login(username, password);

                if (result.Success)
                {
                    Session.CurrentUser = result;
                    MessageBox.Show($"Welcome {result.Username}!",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(result.Message,
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}