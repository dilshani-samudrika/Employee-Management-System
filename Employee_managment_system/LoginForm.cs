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
            txtUsername.Focus();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword.PasswordChar = '●';
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

            // Disable login button during processing
            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                // Test database connection first
                if (!DatabaseHelper.TestConnection())
                {
                    MessageBox.Show("Cannot connect to database. Please check your connection string.",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = true;
                    btnLogin.Text = "Login";
                    return;
                }

                // Use secure authentication service
                var result = AuthService.Login(username, password);

                if (result.Success)
                {
                    MessageBox.Show($"Welcome {result.Username}!",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open Dashboard
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
                MessageBox.Show($"Error: {ex.Message}\n\nPlease try again or contact administrator.",
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}