namespace Employee_managment_system
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Top Panel
            topPanel = new Panel();
            lblTitle = new Label();
            pictureBoxLogo = new PictureBox();

            // Main Panel
            mainPanel = new Panel();

            // Login Panel
            loginPanel = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnClear = new Button();
            linkForgotPassword = new LinkLabel();

            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            loginPanel.SuspendLayout();
            SuspendLayout();

            // ============================================
            // TOP PANEL
            // ============================================
            topPanel.BackColor = Color.FromArgb(30, 58, 95);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(pictureBoxLogo);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(600, 70);
            topPanel.TabIndex = 0;

            // pictureBoxLogo
            pictureBoxLogo.Location = new Point(20, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(50, 46);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(352, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Employee Management System";

            // ============================================
            // MAIN PANEL
            // ============================================
            mainPanel.BackColor = Color.FromArgb(248, 249, 250);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(600, 520);
            mainPanel.TabIndex = 1;

            // ============================================
            // LOGIN PANEL
            // ============================================
            loginPanel.BackColor = Color.White;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(lblWelcome);
            loginPanel.Controls.Add(lblSubtitle);
            loginPanel.Controls.Add(lblUsername);
            loginPanel.Controls.Add(txtUsername);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(chkShowPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(btnClear);
            loginPanel.Controls.Add(linkForgotPassword);
            loginPanel.Location = new Point(75, 30);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(450, 460);
            loginPanel.TabIndex = 0;

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 58, 95);
            lblWelcome.Location = new Point(100, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(250, 46);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome Back!";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new Point(95, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(260, 25);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Please sign in to your account";

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(30, 58, 95);
            lblUsername.Location = new Point(50, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";

            // txtUsername
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(50, 166);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 32);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "admin";

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(30, 58, 95);
            lblPassword.Location = new Point(50, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";

            // txtPassword
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(50, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(350, 32);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "admin123";

            // chkShowPassword
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(30, 58, 95);
            chkShowPassword.Location = new Point(50, 280);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(140, 24);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // btnLogin
            btnLogin.BackColor = Color.FromArgb(46, 204, 113);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "🔑 Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // btnClear
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(240, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 50);
            btnClear.TabIndex = 5;
            btnClear.Text = "🗑 Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // linkForgotPassword
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Segoe UI", 9F);
            linkForgotPassword.LinkColor = Color.FromArgb(52, 152, 219);
            linkForgotPassword.Location = new Point(50, 400);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(140, 20);
            linkForgotPassword.TabIndex = 6;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;

            // ============================================
            // LOGIN FORM
            // ============================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(600, 590);
            Controls.Add(loginPanel);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Employee Management System";
            Load += LoginForm_Load;

            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Control declarations
        private Panel topPanel;
        private Panel mainPanel;
        private Panel loginPanel;
        private PictureBox pictureBoxLogo;
        private Label lblTitle;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnClear;
        private LinkLabel linkForgotPassword;
    }
}