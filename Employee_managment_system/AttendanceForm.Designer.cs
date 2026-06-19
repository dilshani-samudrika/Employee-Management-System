namespace Employee_managment_system
{
    partial class AttendanceForm
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
            // Main Container
            mainContainer = new SplitContainer();

            // Left Panel - Side Menu (Same as Dashboard)
            panelSideMenu = new Panel();
            panelLogo = new Panel();
            lblAppTitle = new Label();
            pictureBoxLogo = new PictureBox();

            btnDashboard = new Button();
            btnEmployees = new Button();
            btnDepartment = new Button();
            btnAttendance = new Button();
            btnLeave = new Button();
            btnPayroll = new Button();
            btnReports = new Button();
            btnLogout = new Button();

            // Right Panel - Content
            panelContent = new Panel();
            topBar = new Panel();
            lblPageTitle = new Label();
            lblUserInfo = new Label();

            // Main Content
            mainPanel = new Panel();
            lblComingSoon = new Label();

            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelContent.SuspendLayout();
            topBar.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();

            // mainContainer
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1200, 650);
            mainContainer.SplitterDistance = 220;
            mainContainer.SplitterWidth = 2;
            mainContainer.TabIndex = 0;

            // Left Panel - Same as Dashboard
            mainContainer.Panel1.Controls.Add(panelSideMenu);
            mainContainer.Panel1.BackColor = Color.FromArgb(25, 48, 78);

            panelSideMenu.BackColor = Color.FromArgb(25, 48, 78);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(btnEmployees);
            panelSideMenu.Controls.Add(btnDepartment);
            panelSideMenu.Controls.Add(btnAttendance);
            panelSideMenu.Controls.Add(btnLeave);
            panelSideMenu.Controls.Add(btnPayroll);
            panelSideMenu.Controls.Add(btnReports);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Dock = DockStyle.Fill;
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(220, 650);

            // Logo
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(lblAppTitle);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);

            pictureBoxLogo.Location = new Point(20, 15);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(45, 45);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;

            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(75, 28);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(130, 25);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "EMS Admin";

            // Menu Buttons
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;

            btnEmployees.BackColor = Color.FromArgb(25, 48, 78);
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10F);
            btnEmployees.ForeColor = Color.FromArgb(200, 200, 200);
            btnEmployees.Location = new Point(0, 140);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(220, 45);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;

            btnDepartment.BackColor = Color.FromArgb(25, 48, 78);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F);
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 190);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(220, 45);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;

            btnAttendance.BackColor = Color.FromArgb(52, 152, 219);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 240);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(220, 45);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;

            btnLeave.BackColor = Color.FromArgb(25, 48, 78);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 10F);
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 290);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(220, 45);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;

            btnPayroll.BackColor = Color.FromArgb(25, 48, 78);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 340);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(220, 45);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;

            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
            btnReports.Location = new Point(0, 390);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;

            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 580);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;

            // Right Panel
            mainContainer.Panel2.Controls.Add(panelContent);
            mainContainer.Panel2.BackColor = Color.FromArgb(248, 249, 250);

            panelContent.Controls.Add(topBar);
            panelContent.Controls.Add(mainPanel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(978, 650);

            // Top Bar
            topBar.BackColor = Color.White;
            topBar.Controls.Add(lblPageTitle);
            topBar.Controls.Add(lblUserInfo);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(978, 50);
            topBar.TabIndex = 0;

            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblPageTitle.Location = new Point(20, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(157, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Attendance";

            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F);
            lblUserInfo.ForeColor = Color.Gray;
            lblUserInfo.Location = new Point(850, 12);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(108, 23);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "👤 Admin";

            // Main Content
            mainPanel.BackColor = Color.FromArgb(248, 249, 250);
            mainPanel.Controls.Add(lblComingSoon);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(978, 600);
            mainPanel.TabIndex = 1;

            lblComingSoon.AutoSize = true;
            lblComingSoon.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblComingSoon.ForeColor = Color.FromArgb(30, 58, 95);
            lblComingSoon.Location = new Point(300, 250);
            lblComingSoon.Name = "lblComingSoon";
            lblComingSoon.Size = new Size(378, 54);
            lblComingSoon.TabIndex = 0;
            lblComingSoon.Text = "📅 Attendance Module";
            lblComingSoon.TextAlign = ContentAlignment.MiddleCenter;

            // AttendanceForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(mainContainer);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance - Employee Management System";

            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel2.ResumeLayout(false);
            mainContainer.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelContent.ResumeLayout(false);
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        // Control declarations
        private SplitContainer mainContainer;
        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label lblAppTitle;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnLogout;
        private Panel panelContent;
        private Panel topBar;
        private Label lblPageTitle;
        private Label lblUserInfo;
        private Panel mainPanel;
        private Label lblComingSoon;
    }
}