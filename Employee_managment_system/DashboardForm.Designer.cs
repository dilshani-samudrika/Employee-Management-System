namespace Employee_managment_system
{
    partial class DashboardForm
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

            // ============================================
            // LEFT PANEL - SIDE MENU
            // ============================================
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

            // ============================================
            // RIGHT PANEL - CONTENT
            // ============================================
            panelContent = new Panel();
            topBar = new Panel();
            lblPageTitle = new Label();
            lblUserInfo = new Label();

            // Main Content with AutoScroll
            mainPanel = new Panel();
            mainPanel.AutoScroll = true;

            // Welcome Section
            panelWelcome = new Panel();
            lblWelcomeTitle = new Label();
            lblWelcomeMessage = new Label();

            // Stats Cards - Row 1
            cardTotalEmployees = new Panel();
            lblCardTitle1 = new Label();
            lblCardCount1 = new Label();
            iconCard1 = new Label();

            cardTotalDepartments = new Panel();
            lblCardTitle2 = new Label();
            lblCardCount2 = new Label();
            iconCard2 = new Label();

            cardTotalDesignations = new Panel();
            lblCardTitle3 = new Label();
            lblCardCount3 = new Label();
            iconCard3 = new Label();

            cardActiveEmployees = new Panel();
            lblCardTitle4 = new Label();
            lblCardCount4 = new Label();
            iconCard4 = new Label();

            // Stats Cards - Row 2
            cardTodayAttendance = new Panel();
            lblCardTitle5 = new Label();
            lblCardCount5 = new Label();
            iconCard5 = new Label();

            cardPendingLeaves = new Panel();
            lblCardTitle6 = new Label();
            lblCardCount6 = new Label();
            iconCard6 = new Label();

            cardMonthlyPayroll = new Panel();
            lblCardTitle7 = new Label();
            lblCardCount7 = new Label();
            iconCard7 = new Label();

            cardEmployeeBalance = new Panel();
            lblCardTitle8 = new Label();
            lblCardCount8 = new Label();
            iconCard8 = new Label();

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
            panelWelcome.SuspendLayout();
            cardTotalEmployees.SuspendLayout();
            cardTotalDepartments.SuspendLayout();
            cardTotalDesignations.SuspendLayout();
            cardActiveEmployees.SuspendLayout();
            cardTodayAttendance.SuspendLayout();
            cardPendingLeaves.SuspendLayout();
            cardMonthlyPayroll.SuspendLayout();
            cardEmployeeBalance.SuspendLayout();
            SuspendLayout();

            // ============================================
            // MAIN CONTAINER
            // ============================================
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1200, 650);
            mainContainer.SplitterDistance = 220;
            mainContainer.SplitterWidth = 2;
            mainContainer.TabIndex = 0;

            // ============================================
            // LEFT PANEL - SIDE MENU
            // ============================================
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
            btnDashboard.BackColor = Color.FromArgb(52, 152, 219);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
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

            btnAttendance.BackColor = Color.FromArgb(25, 48, 78);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
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

            // ============================================
            // RIGHT PANEL - CONTENT
            // ============================================
            mainContainer.Panel2.Controls.Add(panelContent);
            mainContainer.Panel2.BackColor = Color.FromArgb(248, 249, 250);

            panelContent.Controls.Add(topBar);
            panelContent.Controls.Add(mainPanel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(978, 650);

            // ============================================
            // TOP BAR
            // ============================================
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
            lblPageTitle.Size = new Size(145, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";

            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F);
            lblUserInfo.ForeColor = Color.Gray;
            lblUserInfo.Location = new Point(850, 12);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(108, 23);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "👤 Admin";

            // ============================================
            // MAIN CONTENT PANEL WITH AUTOSCROLL
            // ============================================
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(248, 249, 250);
            mainPanel.Controls.Add(panelWelcome);
            mainPanel.Controls.Add(cardTotalEmployees);
            mainPanel.Controls.Add(cardTotalDepartments);
            mainPanel.Controls.Add(cardTotalDesignations);
            mainPanel.Controls.Add(cardActiveEmployees);
            mainPanel.Controls.Add(cardTodayAttendance);
            mainPanel.Controls.Add(cardPendingLeaves);
            mainPanel.Controls.Add(cardMonthlyPayroll);
            mainPanel.Controls.Add(cardEmployeeBalance);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(978, 600);
            mainPanel.TabIndex = 1;

            // ============================================
            // WELCOME SECTION
            // ============================================
            panelWelcome.BackColor = Color.White;
            panelWelcome.BorderStyle = BorderStyle.FixedSingle;
            panelWelcome.Controls.Add(lblWelcomeTitle);
            panelWelcome.Controls.Add(lblWelcomeMessage);
            panelWelcome.Location = new Point(20, 15);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(930, 70);
            panelWelcome.TabIndex = 0;

            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblWelcomeTitle.Location = new Point(20, 12);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(307, 37);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "Welcome to EMS Dashboard";

            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 10F);
            lblWelcomeMessage.ForeColor = Color.Gray;
            lblWelcomeMessage.Location = new Point(25, 45);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(363, 23);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Here's an overview of your employee management system";

            // ============================================
            // STATS CARDS - ROW 1
            // ============================================
            // Card 1 - Total Employees
            cardTotalEmployees.BackColor = Color.White;
            cardTotalEmployees.BorderStyle = BorderStyle.FixedSingle;
            cardTotalEmployees.Controls.Add(lblCardTitle1);
            cardTotalEmployees.Controls.Add(lblCardCount1);
            cardTotalEmployees.Controls.Add(iconCard1);
            cardTotalEmployees.Location = new Point(20, 105);
            cardTotalEmployees.Name = "cardTotalEmployees";
            cardTotalEmployees.Size = new Size(220, 110);
            cardTotalEmployees.TabIndex = 1;

            lblCardTitle1.AutoSize = true;
            lblCardTitle1.Font = new Font("Segoe UI", 9F);
            lblCardTitle1.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle1.Location = new Point(55, 25);
            lblCardTitle1.Name = "lblCardTitle1";
            lblCardTitle1.Size = new Size(121, 20);
            lblCardTitle1.TabIndex = 0;
            lblCardTitle1.Text = "Total Employees";

            lblCardCount1.AutoSize = true;
            lblCardCount1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount1.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardCount1.Location = new Point(85, 50);
            lblCardCount1.Name = "lblCardCount1";
            lblCardCount1.Size = new Size(45, 54);
            lblCardCount1.TabIndex = 1;
            lblCardCount1.Text = "0";

            iconCard1.AutoSize = true;
            iconCard1.Font = new Font("Segoe UI", 28F);
            iconCard1.Location = new Point(12, 25);
            iconCard1.Name = "iconCard1";
            iconCard1.Size = new Size(48, 62);
            iconCard1.TabIndex = 2;
            iconCard1.Text = "👥";

            // Card 2 - Total Departments
            cardTotalDepartments.BackColor = Color.White;
            cardTotalDepartments.BorderStyle = BorderStyle.FixedSingle;
            cardTotalDepartments.Controls.Add(lblCardTitle2);
            cardTotalDepartments.Controls.Add(lblCardCount2);
            cardTotalDepartments.Controls.Add(iconCard2);
            cardTotalDepartments.Location = new Point(250, 105);
            cardTotalDepartments.Name = "cardTotalDepartments";
            cardTotalDepartments.Size = new Size(220, 110);
            cardTotalDepartments.TabIndex = 2;

            lblCardTitle2.AutoSize = true;
            lblCardTitle2.Font = new Font("Segoe UI", 9F);
            lblCardTitle2.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle2.Location = new Point(55, 25);
            lblCardTitle2.Name = "lblCardTitle2";
            lblCardTitle2.Size = new Size(139, 20);
            lblCardTitle2.TabIndex = 0;
            lblCardTitle2.Text = "Total Departments";

            lblCardCount2.AutoSize = true;
            lblCardCount2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount2.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardCount2.Location = new Point(85, 50);
            lblCardCount2.Name = "lblCardCount2";
            lblCardCount2.Size = new Size(45, 54);
            lblCardCount2.TabIndex = 1;
            lblCardCount2.Text = "0";

            iconCard2.AutoSize = true;
            iconCard2.Font = new Font("Segoe UI", 28F);
            iconCard2.Location = new Point(12, 25);
            iconCard2.Name = "iconCard2";
            iconCard2.Size = new Size(48, 62);
            iconCard2.TabIndex = 2;
            iconCard2.Text = "🏢";

            // Card 3 - Total Designations
            cardTotalDesignations.BackColor = Color.White;
            cardTotalDesignations.BorderStyle = BorderStyle.FixedSingle;
            cardTotalDesignations.Controls.Add(lblCardTitle3);
            cardTotalDesignations.Controls.Add(lblCardCount3);
            cardTotalDesignations.Controls.Add(iconCard3);
            cardTotalDesignations.Location = new Point(480, 105);
            cardTotalDesignations.Name = "cardTotalDesignations";
            cardTotalDesignations.Size = new Size(220, 110);
            cardTotalDesignations.TabIndex = 3;

            lblCardTitle3.AutoSize = true;
            lblCardTitle3.Font = new Font("Segoe UI", 9F);
            lblCardTitle3.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle3.Location = new Point(55, 25);
            lblCardTitle3.Name = "lblCardTitle3";
            lblCardTitle3.Size = new Size(137, 20);
            lblCardTitle3.TabIndex = 0;
            lblCardTitle3.Text = "Total Designations";

            lblCardCount3.AutoSize = true;
            lblCardCount3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount3.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardCount3.Location = new Point(85, 50);
            lblCardCount3.Name = "lblCardCount3";
            lblCardCount3.Size = new Size(45, 54);
            lblCardCount3.TabIndex = 1;
            lblCardCount3.Text = "0";

            iconCard3.AutoSize = true;
            iconCard3.Font = new Font("Segoe UI", 28F);
            iconCard3.Location = new Point(12, 25);
            iconCard3.Name = "iconCard3";
            iconCard3.Size = new Size(48, 62);
            iconCard3.TabIndex = 2;
            iconCard3.Text = "📋";

            // Card 4 - Active Employees
            cardActiveEmployees.BackColor = Color.White;
            cardActiveEmployees.BorderStyle = BorderStyle.FixedSingle;
            cardActiveEmployees.Controls.Add(lblCardTitle4);
            cardActiveEmployees.Controls.Add(lblCardCount4);
            cardActiveEmployees.Controls.Add(iconCard4);
            cardActiveEmployees.Location = new Point(710, 105);
            cardActiveEmployees.Name = "cardActiveEmployees";
            cardActiveEmployees.Size = new Size(220, 110);
            cardActiveEmployees.TabIndex = 4;

            lblCardTitle4.AutoSize = true;
            lblCardTitle4.Font = new Font("Segoe UI", 9F);
            lblCardTitle4.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle4.Location = new Point(55, 25);
            lblCardTitle4.Name = "lblCardTitle4";
            lblCardTitle4.Size = new Size(123, 20);
            lblCardTitle4.TabIndex = 0;
            lblCardTitle4.Text = "Active Employees";

            lblCardCount4.AutoSize = true;
            lblCardCount4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount4.ForeColor = Color.FromArgb(46, 204, 113);
            lblCardCount4.Location = new Point(85, 50);
            lblCardCount4.Name = "lblCardCount4";
            lblCardCount4.Size = new Size(45, 54);
            lblCardCount4.TabIndex = 1;
            lblCardCount4.Text = "0";

            iconCard4.AutoSize = true;
            iconCard4.Font = new Font("Segoe UI", 28F);
            iconCard4.Location = new Point(12, 25);
            iconCard4.Name = "iconCard4";
            iconCard4.Size = new Size(48, 62);
            iconCard4.TabIndex = 2;
            iconCard4.Text = "✅";

            // ============================================
            // STATS CARDS - ROW 2
            // ============================================
            // Card 5 - Today's Attendance
            cardTodayAttendance.BackColor = Color.White;
            cardTodayAttendance.BorderStyle = BorderStyle.FixedSingle;
            cardTodayAttendance.Controls.Add(lblCardTitle5);
            cardTodayAttendance.Controls.Add(lblCardCount5);
            cardTodayAttendance.Controls.Add(iconCard5);
            cardTodayAttendance.Location = new Point(20, 230);
            cardTodayAttendance.Name = "cardTodayAttendance";
            cardTodayAttendance.Size = new Size(220, 110);
            cardTodayAttendance.TabIndex = 5;

            lblCardTitle5.AutoSize = true;
            lblCardTitle5.Font = new Font("Segoe UI", 9F);
            lblCardTitle5.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle5.Location = new Point(55, 25);
            lblCardTitle5.Name = "lblCardTitle5";
            lblCardTitle5.Size = new Size(142, 20);
            lblCardTitle5.TabIndex = 0;
            lblCardTitle5.Text = "Today's Attendance";

            lblCardCount5.AutoSize = true;
            lblCardCount5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount5.ForeColor = Color.FromArgb(52, 152, 219);
            lblCardCount5.Location = new Point(85, 50);
            lblCardCount5.Name = "lblCardCount5";
            lblCardCount5.Size = new Size(45, 54);
            lblCardCount5.TabIndex = 1;
            lblCardCount5.Text = "0";

            iconCard5.AutoSize = true;
            iconCard5.Font = new Font("Segoe UI", 28F);
            iconCard5.Location = new Point(12, 25);
            iconCard5.Name = "iconCard5";
            iconCard5.Size = new Size(48, 62);
            iconCard5.TabIndex = 2;
            iconCard5.Text = "📅";

            // Card 6 - Pending Leave Requests
            cardPendingLeaves.BackColor = Color.White;
            cardPendingLeaves.BorderStyle = BorderStyle.FixedSingle;
            cardPendingLeaves.Controls.Add(lblCardTitle6);
            cardPendingLeaves.Controls.Add(lblCardCount6);
            cardPendingLeaves.Controls.Add(iconCard6);
            cardPendingLeaves.Location = new Point(250, 230);
            cardPendingLeaves.Name = "cardPendingLeaves";
            cardPendingLeaves.Size = new Size(220, 110);
            cardPendingLeaves.TabIndex = 6;

            lblCardTitle6.AutoSize = true;
            lblCardTitle6.Font = new Font("Segoe UI", 9F);
            lblCardTitle6.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle6.Location = new Point(55, 25);
            lblCardTitle6.Name = "lblCardTitle6";
            lblCardTitle6.Size = new Size(146, 20);
            lblCardTitle6.TabIndex = 0;
            lblCardTitle6.Text = "Pending Leave Reqs";

            lblCardCount6.AutoSize = true;
            lblCardCount6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCardCount6.ForeColor = Color.FromArgb(243, 156, 18);
            lblCardCount6.Location = new Point(85, 50);
            lblCardCount6.Name = "lblCardCount6";
            lblCardCount6.Size = new Size(45, 54);
            lblCardCount6.TabIndex = 1;
            lblCardCount6.Text = "0";

            iconCard6.AutoSize = true;
            iconCard6.Font = new Font("Segoe UI", 28F);
            iconCard6.Location = new Point(12, 25);
            iconCard6.Name = "iconCard6";
            iconCard6.Size = new Size(48, 62);
            iconCard6.TabIndex = 2;
            iconCard6.Text = "🏖";

            // Card 7 - Monthly Payroll
            cardMonthlyPayroll.BackColor = Color.White;
            cardMonthlyPayroll.BorderStyle = BorderStyle.FixedSingle;
            cardMonthlyPayroll.Controls.Add(lblCardTitle7);
            cardMonthlyPayroll.Controls.Add(lblCardCount7);
            cardMonthlyPayroll.Controls.Add(iconCard7);
            cardMonthlyPayroll.Location = new Point(480, 230);
            cardMonthlyPayroll.Name = "cardMonthlyPayroll";
            cardMonthlyPayroll.Size = new Size(220, 110);
            cardMonthlyPayroll.TabIndex = 7;

            lblCardTitle7.AutoSize = true;
            lblCardTitle7.Font = new Font("Segoe UI", 9F);
            lblCardTitle7.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle7.Location = new Point(55, 15);
            lblCardTitle7.Name = "lblCardTitle7";
            lblCardTitle7.Size = new Size(139, 20);
            lblCardTitle7.TabIndex = 0;
            lblCardTitle7.Text = "Monthly Payroll";

            lblCardCount7.AutoSize = true;
            lblCardCount7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCardCount7.ForeColor = Color.FromArgb(46, 204, 113);
            lblCardCount7.Location = new Point(60, 45);
            lblCardCount7.Name = "lblCardCount7";
            lblCardCount7.Size = new Size(123, 41);
            lblCardCount7.TabIndex = 1;
            lblCardCount7.Text = "LKR 0";

            iconCard7.AutoSize = true;
            iconCard7.Font = new Font("Segoe UI", 28F);
            iconCard7.Location = new Point(12, 25);
            iconCard7.Name = "iconCard7";
            iconCard7.Size = new Size(48, 62);
            iconCard7.TabIndex = 2;
            iconCard7.Text = "💰";

            // Card 8 - Employee Balance
            cardEmployeeBalance.BackColor = Color.White;
            cardEmployeeBalance.BorderStyle = BorderStyle.FixedSingle;
            cardEmployeeBalance.Controls.Add(lblCardTitle8);
            cardEmployeeBalance.Controls.Add(lblCardCount8);
            cardEmployeeBalance.Controls.Add(iconCard8);
            cardEmployeeBalance.Location = new Point(710, 230);
            cardEmployeeBalance.Name = "cardEmployeeBalance";
            cardEmployeeBalance.Size = new Size(220, 110);
            cardEmployeeBalance.TabIndex = 8;

            lblCardTitle8.AutoSize = true;
            lblCardTitle8.Font = new Font("Segoe UI", 9F);
            lblCardTitle8.ForeColor = Color.FromArgb(30, 58, 95);
            lblCardTitle8.Location = new Point(55, 15);
            lblCardTitle8.Name = "lblCardTitle8";
            lblCardTitle8.Size = new Size(162, 20);
            lblCardTitle8.TabIndex = 0;
            lblCardTitle8.Text = "Active / Total Emp";

            lblCardCount8.AutoSize = true;
            lblCardCount8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCardCount8.ForeColor = Color.FromArgb(155, 89, 182);
            lblCardCount8.Location = new Point(65, 45);
            lblCardCount8.Name = "lblCardCount8";
            lblCardCount8.Size = new Size(83, 41);
            lblCardCount8.TabIndex = 1;
            lblCardCount8.Text = "0 / 0";

            iconCard8.AutoSize = true;
            iconCard8.Font = new Font("Segoe UI", 28F);
            iconCard8.Location = new Point(12, 25);
            iconCard8.Name = "iconCard8";
            iconCard8.Size = new Size(48, 62);
            iconCard8.TabIndex = 2;
            iconCard8.Text = "📊";

            // ============================================
            // DASHBOARD FORM
            // ============================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(mainContainer);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Employee Management System";

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
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            cardTotalEmployees.ResumeLayout(false);
            cardTotalEmployees.PerformLayout();
            cardTotalDepartments.ResumeLayout(false);
            cardTotalDepartments.PerformLayout();
            cardTotalDesignations.ResumeLayout(false);
            cardTotalDesignations.PerformLayout();
            cardActiveEmployees.ResumeLayout(false);
            cardActiveEmployees.PerformLayout();
            cardTodayAttendance.ResumeLayout(false);
            cardTodayAttendance.PerformLayout();
            cardPendingLeaves.ResumeLayout(false);
            cardPendingLeaves.PerformLayout();
            cardMonthlyPayroll.ResumeLayout(false);
            cardMonthlyPayroll.PerformLayout();
            cardEmployeeBalance.ResumeLayout(false);
            cardEmployeeBalance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panelWelcome;
        private Label lblWelcomeTitle;
        private Label lblWelcomeMessage;
        private Panel cardTotalEmployees;
        private Label lblCardTitle1;
        private Label lblCardCount1;
        private Label iconCard1;
        private Panel cardTotalDepartments;
        private Label lblCardTitle2;
        private Label lblCardCount2;
        private Label iconCard2;
        private Panel cardTotalDesignations;
        private Label lblCardTitle3;
        private Label lblCardCount3;
        private Label iconCard3;
        private Panel cardActiveEmployees;
        private Label lblCardTitle4;
        private Label lblCardCount4;
        private Label iconCard4;
        private Panel cardTodayAttendance;
        private Label lblCardTitle5;
        private Label lblCardCount5;
        private Label iconCard5;
        private Panel cardPendingLeaves;
        private Label lblCardTitle6;
        private Label lblCardCount6;
        private Label iconCard6;
        private Panel cardMonthlyPayroll;
        private Label lblCardTitle7;
        private Label lblCardCount7;
        private Label iconCard7;
        private Panel cardEmployeeBalance;
        private Label lblCardTitle8;
        private Label lblCardCount8;
        private Label iconCard8;
    }
}