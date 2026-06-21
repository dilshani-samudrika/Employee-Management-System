namespace Employee_managment_system
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelSideMenu = new Panel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            btnDashboard = new Button();
            btnEmployees = new Button();
            btnDepartment = new Button();
            btnAttendance = new Button();
            btnLeave = new Button();
            btnPayroll = new Button();
            btnReports = new Button();
            btnChangePassword = new Button();
            btnLogout = new Button();
            panelContent = new Panel();
            mainPanel = new Panel();
            btnRefresh = new Button();
            panelQuickActions = new Panel();
            lblQuickTitle = new Label();
            btnQuickAddEmployee = new Button();
            btnQuickAttendance = new Button();
            btnQuickApproveLeave = new Button();
            btnQuickPayroll = new Button();
            btnQuickReports = new Button();
            cardTotalDepartments = new Panel();
            lblCardTitle2 = new Label();
            lblCardCount2 = new Label();
            iconCard2 = new Label();
            cardTotalDesignations = new Panel();
            lblCardTitle3 = new Label();
            lblCardCount3 = new Label();
            iconCard3 = new Label();
            cardTodayAttendance = new Panel();
            lblCardTitle5 = new Label();
            lblCardCount5 = new Label();
            iconCard5 = new Label();
            lblAttendancePercent = new Label();
            cardMonthlyPayroll = new Panel();
            lblCardTitle7 = new Label();
            lblCardCount7 = new Label();
            iconCard7 = new Label();
            lblPayrollTrend = new Label();
            cardEmployeeBalance = new Panel();
            lblCardTitle8 = new Label();
            lblCardCount8 = new Label();
            iconCard8 = new Label();
            panelWeeklyAttendance = new Panel();
            lblWeeklyTitle = new Label();
            panelMon = new Panel();
            lblMonCount = new Label();
            lblMon = new Label();
            panelTue = new Panel();
            lblTueCount = new Label();
            lblTue = new Label();
            panelWed = new Panel();
            lblWed = new Label();
            lblWedCount = new Label();
            panelThu = new Panel();
            lblThu = new Label();
            lblThuCount = new Label();
            panelFri = new Panel();
            lblFri = new Label();
            lblFriCount = new Label();
            panelSat = new Panel();
            lblSat = new Label();
            lblSatCount = new Label();
            panelSun = new Panel();
            lblSun = new Label();
            lblSunCount = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelContent.SuspendLayout();
            mainPanel.SuspendLayout();
            panelQuickActions.SuspendLayout();
            cardTotalDepartments.SuspendLayout();
            cardTotalDesignations.SuspendLayout();
            cardTodayAttendance.SuspendLayout();
            cardMonthlyPayroll.SuspendLayout();
            cardEmployeeBalance.SuspendLayout();
            panelWeeklyAttendance.SuspendLayout();
            panelMon.SuspendLayout();
            panelTue.SuspendLayout();
            panelWed.SuspendLayout();
            panelThu.SuspendLayout();
            panelFri.SuspendLayout();
            panelSat.SuspendLayout();
            panelSun.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(25, 48, 78);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(btnEmployees);
            panelSideMenu.Controls.Add(btnDepartment);
            panelSideMenu.Controls.Add(btnAttendance);
            panelSideMenu.Controls.Add(btnLeave);
            panelSideMenu.Controls.Add(btnPayroll);
            panelSideMenu.Controls.Add(btnReports);
            panelSideMenu.Controls.Add(btnChangePassword);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(351, 966);
            panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(351, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo_and_name_for_header;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(348, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(52, 152, 219);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(351, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(25, 48, 78);
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 11F);
            btnEmployees.ForeColor = Color.FromArgb(200, 200, 200);
            btnEmployees.Location = new Point(0, 145);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(351, 50);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(25, 48, 78);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 11F);
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 200);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(351, 50);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = " 🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(25, 48, 78);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 11F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 255);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(351, 50);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = " 📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(25, 48, 78);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 11F);
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 310);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(351, 50);
            btnLeave.TabIndex = 5;
            btnLeave.Text = " 🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(25, 48, 78);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 11F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 365);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(351, 50);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
            btnReports.Location = new Point(0, 420);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(351, 50);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(25, 48, 78);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 11F);
            btnChangePassword.ForeColor = Color.FromArgb(200, 200, 200);
            btnChangePassword.Location = new Point(0, 475);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(351, 50);
            btnChangePassword.TabIndex = 9;
            btnChangePassword.Text = "🔐Change Password";
            btnChangePassword.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 916);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(351, 50);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 249, 250);
            panelContent.Controls.Add(mainPanel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(351, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1164, 966);
            panelContent.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(248, 249, 250);
            mainPanel.BackgroundImage = Properties.Resources.otherBackground;
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Controls.Add(btnRefresh);
            mainPanel.Controls.Add(panelQuickActions);
            mainPanel.Controls.Add(cardTotalDepartments);
            mainPanel.Controls.Add(cardTotalDesignations);
            mainPanel.Controls.Add(cardTodayAttendance);
            mainPanel.Controls.Add(cardMonthlyPayroll);
            mainPanel.Controls.Add(cardEmployeeBalance);
            mainPanel.Controls.Add(panelWeeklyAttendance);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1164, 966);
            mainPanel.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(963, 23);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelQuickActions
            // 
            panelQuickActions.BackColor = Color.White;
            panelQuickActions.BorderStyle = BorderStyle.FixedSingle;
            panelQuickActions.Controls.Add(lblQuickTitle);
            panelQuickActions.Controls.Add(btnQuickAddEmployee);
            panelQuickActions.Controls.Add(btnQuickAttendance);
            panelQuickActions.Controls.Add(btnQuickApproveLeave);
            panelQuickActions.Controls.Add(btnQuickPayroll);
            panelQuickActions.Controls.Add(btnQuickReports);
            panelQuickActions.Location = new Point(18, 737);
            panelQuickActions.Name = "panelQuickActions";
            panelQuickActions.Size = new Size(1135, 152);
            panelQuickActions.TabIndex = 1;
            // 
            // lblQuickTitle
            // 
            lblQuickTitle.AutoSize = true;
            lblQuickTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblQuickTitle.Location = new Point(3, 63);
            lblQuickTitle.Name = "lblQuickTitle";
            lblQuickTitle.Size = new Size(163, 31);
            lblQuickTitle.TabIndex = 0;
            lblQuickTitle.Text = "Quick Actions";
            // 
            // btnQuickAddEmployee
            // 
            btnQuickAddEmployee.BackColor = Color.FromArgb(46, 204, 113);
            btnQuickAddEmployee.Cursor = Cursors.Hand;
            btnQuickAddEmployee.FlatAppearance.BorderSize = 0;
            btnQuickAddEmployee.FlatStyle = FlatStyle.Flat;
            btnQuickAddEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAddEmployee.ForeColor = Color.White;
            btnQuickAddEmployee.Location = new Point(172, 47);
            btnQuickAddEmployee.Name = "btnQuickAddEmployee";
            btnQuickAddEmployee.Size = new Size(170, 70);
            btnQuickAddEmployee.TabIndex = 1;
            btnQuickAddEmployee.Text = "Add Employee";
            btnQuickAddEmployee.UseVisualStyleBackColor = false;
            btnQuickAddEmployee.Click += btnQuickAddEmployee_Click;
            // 
            // btnQuickAttendance
            // 
            btnQuickAttendance.BackColor = Color.FromArgb(52, 152, 219);
            btnQuickAttendance.Cursor = Cursors.Hand;
            btnQuickAttendance.FlatAppearance.BorderSize = 0;
            btnQuickAttendance.FlatStyle = FlatStyle.Flat;
            btnQuickAttendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAttendance.ForeColor = Color.White;
            btnQuickAttendance.Location = new Point(348, 47);
            btnQuickAttendance.Name = "btnQuickAttendance";
            btnQuickAttendance.Size = new Size(170, 70);
            btnQuickAttendance.TabIndex = 2;
            btnQuickAttendance.Text = "Check Attendance";
            btnQuickAttendance.UseVisualStyleBackColor = false;
            btnQuickAttendance.Click += btnQuickAttendance_Click;
            // 
            // btnQuickApproveLeave
            // 
            btnQuickApproveLeave.BackColor = Color.FromArgb(243, 156, 18);
            btnQuickApproveLeave.Cursor = Cursors.Hand;
            btnQuickApproveLeave.FlatAppearance.BorderSize = 0;
            btnQuickApproveLeave.FlatStyle = FlatStyle.Flat;
            btnQuickApproveLeave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickApproveLeave.ForeColor = Color.White;
            btnQuickApproveLeave.Location = new Point(524, 47);
            btnQuickApproveLeave.Name = "btnQuickApproveLeave";
            btnQuickApproveLeave.Size = new Size(170, 70);
            btnQuickApproveLeave.TabIndex = 3;
            btnQuickApproveLeave.Text = "Approve Leave";
            btnQuickApproveLeave.UseVisualStyleBackColor = false;
            btnQuickApproveLeave.Click += btnQuickApproveLeave_Click;
            // 
            // btnQuickPayroll
            // 
            btnQuickPayroll.BackColor = Color.FromArgb(155, 89, 182);
            btnQuickPayroll.Cursor = Cursors.Hand;
            btnQuickPayroll.FlatAppearance.BorderSize = 0;
            btnQuickPayroll.FlatStyle = FlatStyle.Flat;
            btnQuickPayroll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickPayroll.ForeColor = Color.White;
            btnQuickPayroll.Location = new Point(703, 47);
            btnQuickPayroll.Name = "btnQuickPayroll";
            btnQuickPayroll.Size = new Size(170, 70);
            btnQuickPayroll.TabIndex = 4;
            btnQuickPayroll.Text = "Process Payroll";
            btnQuickPayroll.UseVisualStyleBackColor = false;
            btnQuickPayroll.Click += btnQuickPayroll_Click;
            // 
            // btnQuickReports
            // 
            btnQuickReports.BackColor = Color.FromArgb(52, 73, 94);
            btnQuickReports.Cursor = Cursors.Hand;
            btnQuickReports.FlatAppearance.BorderSize = 0;
            btnQuickReports.FlatStyle = FlatStyle.Flat;
            btnQuickReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickReports.ForeColor = Color.White;
            btnQuickReports.Location = new Point(879, 47);
            btnQuickReports.Name = "btnQuickReports";
            btnQuickReports.Size = new Size(170, 70);
            btnQuickReports.TabIndex = 5;
            btnQuickReports.Text = "View Reports";
            btnQuickReports.UseVisualStyleBackColor = false;
            btnQuickReports.Click += btnQuickReports_Click;
            // 
            // cardTotalDepartments
            // 
            cardTotalDepartments.BackColor = Color.White;
            cardTotalDepartments.BorderStyle = BorderStyle.FixedSingle;
            cardTotalDepartments.Controls.Add(lblCardTitle2);
            cardTotalDepartments.Controls.Add(lblCardCount2);
            cardTotalDepartments.Controls.Add(iconCard2);
            cardTotalDepartments.Location = new Point(947, 310);
            cardTotalDepartments.Name = "cardTotalDepartments";
            cardTotalDepartments.Size = new Size(208, 145);
            cardTotalDepartments.TabIndex = 3;
            // 
            // lblCardTitle2
            // 
            lblCardTitle2.AutoSize = true;
            lblCardTitle2.Font = new Font("Segoe UI", 10F);
            lblCardTitle2.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardTitle2.Location = new Point(25, 11);
            lblCardTitle2.Name = "lblCardTitle2";
            lblCardTitle2.Size = new Size(150, 23);
            lblCardTitle2.TabIndex = 0;
            lblCardTitle2.Text = "Total Departments";
            // 
            // lblCardCount2
            // 
            lblCardCount2.AutoSize = true;
            lblCardCount2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCardCount2.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardCount2.Location = new Point(95, 98);
            lblCardCount2.Name = "lblCardCount2";
            lblCardCount2.Size = new Size(40, 46);
            lblCardCount2.TabIndex = 1;
            lblCardCount2.Text = "0";
            // 
            // iconCard2
            // 
            iconCard2.AutoSize = true;
            iconCard2.Font = new Font("Segoe UI", 28F);
            iconCard2.Location = new Point(68, 34);
            iconCard2.Name = "iconCard2";
            iconCard2.Size = new Size(86, 62);
            iconCard2.TabIndex = 2;
            iconCard2.Text = "🏢";
            // 
            // cardTotalDesignations
            // 
            cardTotalDesignations.BackColor = Color.White;
            cardTotalDesignations.BorderStyle = BorderStyle.FixedSingle;
            cardTotalDesignations.Controls.Add(lblCardTitle3);
            cardTotalDesignations.Controls.Add(lblCardCount3);
            cardTotalDesignations.Controls.Add(iconCard3);
            cardTotalDesignations.Location = new Point(711, 310);
            cardTotalDesignations.Name = "cardTotalDesignations";
            cardTotalDesignations.Size = new Size(208, 145);
            cardTotalDesignations.TabIndex = 4;
            // 
            // lblCardTitle3
            // 
            lblCardTitle3.AutoSize = true;
            lblCardTitle3.Font = new Font("Segoe UI", 10F);
            lblCardTitle3.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardTitle3.Location = new Point(30, 11);
            lblCardTitle3.Name = "lblCardTitle3";
            lblCardTitle3.Size = new Size(149, 23);
            lblCardTitle3.TabIndex = 0;
            lblCardTitle3.Text = "Total Designations";
            // 
            // lblCardCount3
            // 
            lblCardCount3.AutoSize = true;
            lblCardCount3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCardCount3.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardCount3.Location = new Point(83, 97);
            lblCardCount3.Name = "lblCardCount3";
            lblCardCount3.Size = new Size(40, 46);
            lblCardCount3.TabIndex = 1;
            lblCardCount3.Text = "0";
            // 
            // iconCard3
            // 
            iconCard3.AutoSize = true;
            iconCard3.Font = new Font("Segoe UI", 28F);
            iconCard3.Location = new Point(57, 33);
            iconCard3.Name = "iconCard3";
            iconCard3.Size = new Size(86, 62);
            iconCard3.TabIndex = 2;
            iconCard3.Text = "📋";
            // 
            // cardTodayAttendance
            // 
            cardTodayAttendance.BackColor = Color.White;
            cardTodayAttendance.BorderStyle = BorderStyle.FixedSingle;
            cardTodayAttendance.Controls.Add(lblCardTitle5);
            cardTodayAttendance.Controls.Add(lblCardCount5);
            cardTodayAttendance.Controls.Add(iconCard5);
            cardTodayAttendance.Controls.Add(lblAttendancePercent);
            cardTodayAttendance.Location = new Point(17, 310);
            cardTodayAttendance.Name = "cardTodayAttendance";
            cardTodayAttendance.Size = new Size(208, 145);
            cardTodayAttendance.TabIndex = 6;
            // 
            // lblCardTitle5
            // 
            lblCardTitle5.AutoSize = true;
            lblCardTitle5.Font = new Font("Segoe UI", 10F);
            lblCardTitle5.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardTitle5.Location = new Point(40, 8);
            lblCardTitle5.Name = "lblCardTitle5";
            lblCardTitle5.Size = new Size(158, 23);
            lblCardTitle5.TabIndex = 0;
            lblCardTitle5.Text = "Today's Attendance";
            // 
            // lblCardCount5
            // 
            lblCardCount5.AutoSize = true;
            lblCardCount5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCardCount5.ForeColor = Color.FromArgb(52, 152, 219);
            lblCardCount5.Location = new Point(83, 92);
            lblCardCount5.Name = "lblCardCount5";
            lblCardCount5.Size = new Size(40, 46);
            lblCardCount5.TabIndex = 1;
            lblCardCount5.Text = "0";
            lblCardCount5.Click += lblCardCount5_Click;
            // 
            // iconCard5
            // 
            iconCard5.AutoSize = true;
            iconCard5.Font = new Font("Segoe UI", 28F);
            iconCard5.Location = new Point(8, 34);
            iconCard5.Name = "iconCard5";
            iconCard5.Size = new Size(86, 62);
            iconCard5.TabIndex = 2;
            iconCard5.Text = "📅";
            // 
            // lblAttendancePercent
            // 
            lblAttendancePercent.AutoSize = true;
            lblAttendancePercent.Font = new Font("Segoe UI", 9F);
            lblAttendancePercent.ForeColor = Color.FromArgb(52, 152, 219);
            lblAttendancePercent.Location = new Point(109, 76);
            lblAttendancePercent.Name = "lblAttendancePercent";
            lblAttendancePercent.Size = new Size(0, 20);
            lblAttendancePercent.TabIndex = 3;
            // 
            // cardMonthlyPayroll
            // 
            cardMonthlyPayroll.BackColor = Color.White;
            cardMonthlyPayroll.BorderStyle = BorderStyle.FixedSingle;
            cardMonthlyPayroll.Controls.Add(lblCardTitle7);
            cardMonthlyPayroll.Controls.Add(lblCardCount7);
            cardMonthlyPayroll.Controls.Add(iconCard7);
            cardMonthlyPayroll.Controls.Add(lblPayrollTrend);
            cardMonthlyPayroll.Location = new Point(476, 310);
            cardMonthlyPayroll.Name = "cardMonthlyPayroll";
            cardMonthlyPayroll.Size = new Size(208, 145);
            cardMonthlyPayroll.TabIndex = 8;
            // 
            // lblCardTitle7
            // 
            lblCardTitle7.AutoSize = true;
            lblCardTitle7.Font = new Font("Segoe UI", 10F);
            lblCardTitle7.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardTitle7.Location = new Point(31, 7);
            lblCardTitle7.Name = "lblCardTitle7";
            lblCardTitle7.Size = new Size(128, 23);
            lblCardTitle7.TabIndex = 0;
            lblCardTitle7.Text = "Monthly Payroll";
            // 
            // lblCardCount7
            // 
            lblCardCount7.AutoSize = true;
            lblCardCount7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardCount7.ForeColor = Color.FromArgb(46, 204, 113);
            lblCardCount7.Location = new Point(66, 95);
            lblCardCount7.Name = "lblCardCount7";
            lblCardCount7.Size = new Size(66, 28);
            lblCardCount7.TabIndex = 1;
            lblCardCount7.Text = "LKR 0";
            lblCardCount7.Click += lblCardCount7_Click;
            // 
            // iconCard7
            // 
            iconCard7.AutoSize = true;
            iconCard7.Font = new Font("Segoe UI", 28F);
            iconCard7.Location = new Point(16, 29);
            iconCard7.Name = "iconCard7";
            iconCard7.Size = new Size(86, 62);
            iconCard7.TabIndex = 2;
            iconCard7.Text = "💰";
            // 
            // lblPayrollTrend
            // 
            lblPayrollTrend.AutoSize = true;
            lblPayrollTrend.Font = new Font("Segoe UI", 9F);
            lblPayrollTrend.ForeColor = Color.Green;
            lblPayrollTrend.Location = new Point(80, 75);
            lblPayrollTrend.Name = "lblPayrollTrend";
            lblPayrollTrend.Size = new Size(0, 20);
            lblPayrollTrend.TabIndex = 3;
            // 
            // cardEmployeeBalance
            // 
            cardEmployeeBalance.BackColor = Color.White;
            cardEmployeeBalance.BorderStyle = BorderStyle.FixedSingle;
            cardEmployeeBalance.Controls.Add(lblCardTitle8);
            cardEmployeeBalance.Controls.Add(lblCardCount8);
            cardEmployeeBalance.Controls.Add(iconCard8);
            cardEmployeeBalance.Location = new Point(247, 310);
            cardEmployeeBalance.Name = "cardEmployeeBalance";
            cardEmployeeBalance.Size = new Size(208, 145);
            cardEmployeeBalance.TabIndex = 9;
            // 
            // lblCardTitle8
            // 
            lblCardTitle8.AutoSize = true;
            lblCardTitle8.Font = new Font("Segoe UI", 10F);
            lblCardTitle8.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardTitle8.Location = new Point(33, 7);
            lblCardTitle8.Name = "lblCardTitle8";
            lblCardTitle8.Size = new Size(148, 23);
            lblCardTitle8.TabIndex = 0;
            lblCardTitle8.Text = "Active / Total Emp";
            // 
            // lblCardCount8
            // 
            lblCardCount8.AutoSize = true;
            lblCardCount8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCardCount8.ForeColor = Color.FromArgb(155, 89, 182);
            lblCardCount8.Location = new Point(64, 94);
            lblCardCount8.Name = "lblCardCount8";
            lblCardCount8.Size = new Size(81, 41);
            lblCardCount8.TabIndex = 1;
            lblCardCount8.Text = "0 / 0";
            // 
            // iconCard8
            // 
            iconCard8.AutoSize = true;
            iconCard8.Font = new Font("Segoe UI", 28F);
            iconCard8.Location = new Point(59, 29);
            iconCard8.Name = "iconCard8";
            iconCard8.Size = new Size(86, 62);
            iconCard8.TabIndex = 2;
            iconCard8.Text = "📊";
            // 
            // panelWeeklyAttendance
            // 
            panelWeeklyAttendance.BackColor = Color.White;
            panelWeeklyAttendance.BorderStyle = BorderStyle.FixedSingle;
            panelWeeklyAttendance.Controls.Add(lblWeeklyTitle);
            panelWeeklyAttendance.Controls.Add(panelMon);
            panelWeeklyAttendance.Controls.Add(panelTue);
            panelWeeklyAttendance.Controls.Add(panelWed);
            panelWeeklyAttendance.Controls.Add(panelThu);
            panelWeeklyAttendance.Controls.Add(panelFri);
            panelWeeklyAttendance.Controls.Add(panelSat);
            panelWeeklyAttendance.Controls.Add(panelSun);
            panelWeeklyAttendance.Location = new Point(17, 496);
            panelWeeklyAttendance.Name = "panelWeeklyAttendance";
            panelWeeklyAttendance.Size = new Size(1138, 170);
            panelWeeklyAttendance.TabIndex = 10;
            // 
            // lblWeeklyTitle
            // 
            lblWeeklyTitle.AutoSize = true;
            lblWeeklyTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWeeklyTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblWeeklyTitle.Location = new Point(15, 12);
            lblWeeklyTitle.Name = "lblWeeklyTitle";
            lblWeeklyTitle.Size = new Size(255, 28);
            lblWeeklyTitle.TabIndex = 0;
            lblWeeklyTitle.Text = "Weekly Attendance Trend";
            // 
            // panelMon
            // 
            panelMon.BackColor = Color.FromArgb(248, 249, 250);
            panelMon.BorderStyle = BorderStyle.FixedSingle;
            panelMon.Controls.Add(lblMonCount);
            panelMon.Controls.Add(lblMon);
            panelMon.Location = new Point(15, 50);
            panelMon.Name = "panelMon";
            panelMon.Size = new Size(150, 80);
            panelMon.TabIndex = 1;
            // 
            // lblMonCount
            // 
            lblMonCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMonCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblMonCount.Location = new Point(-1, 27);
            lblMonCount.Name = "lblMonCount";
            lblMonCount.Size = new Size(150, 40);
            lblMonCount.TabIndex = 2;
            lblMonCount.Text = "0";
            lblMonCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMon
            // 
            lblMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMon.ForeColor = Color.FromArgb(30, 58, 95);
            lblMon.Location = new Point(-1, 0);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(150, 25);
            lblMon.TabIndex = 0;
            lblMon.Text = "Mon";
            lblMon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTue
            // 
            panelTue.BackColor = Color.FromArgb(248, 249, 250);
            panelTue.BorderStyle = BorderStyle.FixedSingle;
            panelTue.Controls.Add(lblTueCount);
            panelTue.Controls.Add(lblTue);
            panelTue.Location = new Point(175, 50);
            panelTue.Name = "panelTue";
            panelTue.Size = new Size(150, 80);
            panelTue.TabIndex = 2;
            // 
            // lblTueCount
            // 
            lblTueCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTueCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblTueCount.Location = new Point(-1, 27);
            lblTueCount.Name = "lblTueCount";
            lblTueCount.Size = new Size(150, 40);
            lblTueCount.TabIndex = 2;
            lblTueCount.Text = "0";
            lblTueCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTue
            // 
            lblTue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTue.ForeColor = Color.FromArgb(30, 58, 95);
            lblTue.Location = new Point(0, 2);
            lblTue.Name = "lblTue";
            lblTue.Size = new Size(150, 25);
            lblTue.TabIndex = 0;
            lblTue.Text = "Tue";
            lblTue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWed
            // 
            panelWed.BackColor = Color.FromArgb(248, 249, 250);
            panelWed.BorderStyle = BorderStyle.FixedSingle;
            panelWed.Controls.Add(lblWed);
            panelWed.Controls.Add(lblWedCount);
            panelWed.Location = new Point(332, 50);
            panelWed.Name = "panelWed";
            panelWed.Size = new Size(150, 80);
            panelWed.TabIndex = 3;
            // 
            // lblWed
            // 
            lblWed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWed.ForeColor = Color.FromArgb(30, 58, 95);
            lblWed.Location = new Point(0, 2);
            lblWed.Name = "lblWed";
            lblWed.Size = new Size(150, 25);
            lblWed.TabIndex = 0;
            lblWed.Text = "Wed";
            lblWed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWedCount
            // 
            lblWedCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWedCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblWedCount.Location = new Point(0, 25);
            lblWedCount.Name = "lblWedCount";
            lblWedCount.Size = new Size(150, 40);
            lblWedCount.TabIndex = 1;
            lblWedCount.Text = "0";
            lblWedCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelThu
            // 
            panelThu.BackColor = Color.FromArgb(248, 249, 250);
            panelThu.BorderStyle = BorderStyle.FixedSingle;
            panelThu.Controls.Add(lblThu);
            panelThu.Controls.Add(lblThuCount);
            panelThu.Location = new Point(489, 51);
            panelThu.Name = "panelThu";
            panelThu.Size = new Size(150, 80);
            panelThu.TabIndex = 4;
            // 
            // lblThu
            // 
            lblThu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThu.ForeColor = Color.FromArgb(30, 58, 95);
            lblThu.Location = new Point(0, 2);
            lblThu.Name = "lblThu";
            lblThu.Size = new Size(150, 25);
            lblThu.TabIndex = 0;
            lblThu.Text = "Thu";
            lblThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThuCount
            // 
            lblThuCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThuCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblThuCount.Location = new Point(0, 25);
            lblThuCount.Name = "lblThuCount";
            lblThuCount.Size = new Size(150, 40);
            lblThuCount.TabIndex = 1;
            lblThuCount.Text = "0";
            lblThuCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFri
            // 
            panelFri.BackColor = Color.FromArgb(248, 249, 250);
            panelFri.BorderStyle = BorderStyle.FixedSingle;
            panelFri.Controls.Add(lblFri);
            panelFri.Controls.Add(lblFriCount);
            panelFri.Location = new Point(646, 51);
            panelFri.Name = "panelFri";
            panelFri.Size = new Size(150, 80);
            panelFri.TabIndex = 5;
            // 
            // lblFri
            // 
            lblFri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFri.ForeColor = Color.FromArgb(30, 58, 95);
            lblFri.Location = new Point(0, 2);
            lblFri.Name = "lblFri";
            lblFri.Size = new Size(150, 25);
            lblFri.TabIndex = 0;
            lblFri.Text = "Fri";
            lblFri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFriCount
            // 
            lblFriCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFriCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblFriCount.Location = new Point(0, 25);
            lblFriCount.Name = "lblFriCount";
            lblFriCount.Size = new Size(150, 40);
            lblFriCount.TabIndex = 1;
            lblFriCount.Text = "0";
            lblFriCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSat
            // 
            panelSat.BackColor = Color.FromArgb(248, 249, 250);
            panelSat.BorderStyle = BorderStyle.FixedSingle;
            panelSat.Controls.Add(lblSat);
            panelSat.Controls.Add(lblSatCount);
            panelSat.Location = new Point(803, 51);
            panelSat.Name = "panelSat";
            panelSat.Size = new Size(150, 80);
            panelSat.TabIndex = 6;
            // 
            // lblSat
            // 
            lblSat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSat.ForeColor = Color.FromArgb(30, 58, 95);
            lblSat.Location = new Point(0, 2);
            lblSat.Name = "lblSat";
            lblSat.Size = new Size(150, 25);
            lblSat.TabIndex = 0;
            lblSat.Text = "Sat";
            lblSat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSatCount
            // 
            lblSatCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSatCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblSatCount.Location = new Point(0, 25);
            lblSatCount.Name = "lblSatCount";
            lblSatCount.Size = new Size(150, 40);
            lblSatCount.TabIndex = 1;
            lblSatCount.Text = "0";
            lblSatCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSun
            // 
            panelSun.BackColor = Color.FromArgb(248, 249, 250);
            panelSun.BorderStyle = BorderStyle.FixedSingle;
            panelSun.Controls.Add(lblSun);
            panelSun.Controls.Add(lblSunCount);
            panelSun.Location = new Point(960, 50);
            panelSun.Name = "panelSun";
            panelSun.Size = new Size(150, 80);
            panelSun.TabIndex = 7;
            // 
            // lblSun
            // 
            lblSun.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSun.ForeColor = Color.FromArgb(30, 58, 95);
            lblSun.Location = new Point(0, 2);
            lblSun.Name = "lblSun";
            lblSun.Size = new Size(150, 25);
            lblSun.TabIndex = 0;
            lblSun.Text = "Sun";
            lblSun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSunCount
            // 
            lblSunCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSunCount.ForeColor = Color.FromArgb(52, 152, 219);
            lblSunCount.Location = new Point(0, 25);
            lblSunCount.Name = "lblSunCount";
            lblSunCount.Size = new Size(150, 40);
            lblSunCount.TabIndex = 1;
            lblSunCount.Text = "0";
            lblSunCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.otherBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1515, 966);
            Controls.Add(panelContent);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexusHR - Dashboard ";
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelContent.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            panelQuickActions.ResumeLayout(false);
            panelQuickActions.PerformLayout();
            cardTotalDepartments.ResumeLayout(false);
            cardTotalDepartments.PerformLayout();
            cardTotalDesignations.ResumeLayout(false);
            cardTotalDesignations.PerformLayout();
            cardTodayAttendance.ResumeLayout(false);
            cardTodayAttendance.PerformLayout();
            cardMonthlyPayroll.ResumeLayout(false);
            cardMonthlyPayroll.PerformLayout();
            cardEmployeeBalance.ResumeLayout(false);
            cardEmployeeBalance.PerformLayout();
            panelWeeklyAttendance.ResumeLayout(false);
            panelWeeklyAttendance.PerformLayout();
            panelMon.ResumeLayout(false);
            panelTue.ResumeLayout(false);
            panelWed.ResumeLayout(false);
            panelThu.ResumeLayout(false);
            panelFri.ResumeLayout(false);
            panelSat.ResumeLayout(false);
            panelSun.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnChangePassword;
        private Button btnLogout;
        private Panel panelContent;
        private Panel mainPanel;
        private Label lblQuickTitle;
        private Button btnQuickAddEmployee;
        private Button btnQuickAttendance;
        private Button btnQuickApproveLeave;
        private Button btnQuickPayroll;
        private Button btnQuickReports;
        private Panel cardTotalDepartments;
        private Label lblCardTitle2;
        private Label lblCardCount2;
        private Label iconCard2;
        private Panel cardTotalDesignations;
        private Label lblCardTitle3;
        private Label lblCardCount3;
        private Label iconCard3;
        private Panel cardTodayAttendance;
        private Label lblCardTitle5;
        private Label lblCardCount5;
        private Label iconCard5;
        private Label lblAttendancePercent;
        private Panel cardMonthlyPayroll;
        private Label lblCardTitle7;
        private Label lblCardCount7;
        private Label iconCard7;
        private Label lblPayrollTrend;
        private Panel cardEmployeeBalance;
        private Label lblCardTitle8;
        private Label lblCardCount8;
        private Label iconCard8;
        private Panel panelWeeklyAttendance;
        private Label lblWeeklyTitle;
        private Panel panelMon;
        private Panel panelTue;
        private Label lblTue;
        private Panel panelWed;
        private Label lblWed;
        private Label lblWedCount;
        private Panel panelThu;
        private Label lblThu;
        private Label lblThuCount;
        private Panel panelFri;
        private Label lblFri;
        private Label lblFriCount;
        private Panel panelSat;
        private Label lblSat;
        private Label lblSatCount;
        private Panel panelSun;
        private Label lblSun;
        private Label lblSunCount;
        private Panel panelQuickActions;
        private Label lblMonCount;
        private Label lblMon;
        private Label lblTueCount;
        private Button btnRefresh;
    }
}