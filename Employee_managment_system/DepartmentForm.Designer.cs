namespace Employee_managment_system
{
    partial class DepartmentForm
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

            // Main Content
            panelMainContent = new Panel();

            // Left Panel - Departments
            panelLeft = new Panel();
            panelDeptHeader = new Panel();
            lblDeptHeader = new Label();
            panelDeptButtons = new Panel();
            btnAddDept = new Button();
            btnDeleteDept = new Button();
            dgvDepartments = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            colDepartmentName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colEmployeeCount = new DataGridViewTextBoxColumn();

            // Department Details Panel
            pnlDeptDetails = new Panel();
            lblDeptDetailsTitle = new Label();
            lblDeptName = new Label();
            txtDeptName = new TextBox();
            lblDeptDescription = new Label();
            txtDeptDescription = new TextBox();
            lblDeptEmployeeCount = new Label();
            txtDeptEmployeeCount = new TextBox();
            btnSaveDept = new Button();
            btnCancelDept = new Button();
            lblDeptInfo = new Label();

            // Right Panel - Designations
            panelRight = new Panel();
            panelDesigHeader = new Panel();
            lblDesigHeader = new Label();
            panelDesigButtons = new Panel();
            btnAddDesig = new Button();
            btnDeleteDesig = new Button();
            dgvDesignations = new DataGridView();
            DesignationId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            DeptName = new DataGridViewTextBoxColumn();
            DesigEmployeeCount = new DataGridViewTextBoxColumn();

            // Designation Details Panel
            pnlDesigDetails = new Panel();
            lblDesigDetailsTitle = new Label();
            lblDesigTitle = new Label();
            txtDesigTitle = new TextBox();
            lblDesigDepartment = new Label();
            cmbDesigDepartment = new ComboBox();
            lblDesigEmployeeCount = new Label();
            txtDesigEmployeeCount = new TextBox();
            btnSaveDesig = new Button();
            btnCancelDesig = new Button();
            lblDesigInfo = new Label();

            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelContent.SuspendLayout();
            topBar.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelLeft.SuspendLayout();
            panelDeptHeader.SuspendLayout();
            panelDeptButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            pnlDeptDetails.SuspendLayout();
            panelRight.SuspendLayout();
            panelDesigHeader.SuspendLayout();
            panelDesigButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).BeginInit();
            pnlDesigDetails.SuspendLayout();
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

            btnDepartment.BackColor = Color.FromArgb(52, 152, 219);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDepartment.ForeColor = Color.White;
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
            panelContent.Controls.Add(panelMainContent);
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
            lblPageTitle.Size = new Size(222, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Department & Designation";

            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F);
            lblUserInfo.ForeColor = Color.Gray;
            lblUserInfo.Location = new Point(850, 12);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(108, 23);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "👤 Admin";

            // ============================================
            // MAIN CONTENT - TWO PANEL LAYOUT
            // ============================================
            panelMainContent.BackColor = Color.FromArgb(248, 249, 250);
            panelMainContent.Controls.Add(panelLeft);
            panelMainContent.Controls.Add(panelRight);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 50);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(978, 600);
            panelMainContent.TabIndex = 1;

            // ============================================
            // LEFT PANEL - DEPARTMENTS
            // ============================================
            panelLeft.BackColor = Color.White;
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(panelDeptHeader);
            panelLeft.Controls.Add(panelDeptButtons);
            panelLeft.Controls.Add(dgvDepartments);
            panelLeft.Controls.Add(pnlDeptDetails);
            panelLeft.Controls.Add(lblDeptInfo);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(489, 600);
            panelLeft.TabIndex = 0;

            // Department Header
            panelDeptHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDeptHeader.Controls.Add(lblDeptHeader);
            panelDeptHeader.Dock = DockStyle.Top;
            panelDeptHeader.Location = new Point(0, 0);
            panelDeptHeader.Name = "panelDeptHeader";
            panelDeptHeader.Size = new Size(487, 30);
            panelDeptHeader.TabIndex = 0;

            lblDeptHeader.AutoSize = true;
            lblDeptHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeptHeader.ForeColor = Color.White;
            lblDeptHeader.Location = new Point(10, 4);
            lblDeptHeader.Name = "lblDeptHeader";
            lblDeptHeader.Size = new Size(111, 23);
            lblDeptHeader.TabIndex = 0;
            lblDeptHeader.Text = "Departments";

            // Department Buttons
            panelDeptButtons.Controls.Add(btnAddDept);
            panelDeptButtons.Controls.Add(btnDeleteDept);
            panelDeptButtons.Dock = DockStyle.Top;
            panelDeptButtons.Location = new Point(0, 30);
            panelDeptButtons.Name = "panelDeptButtons";
            panelDeptButtons.Size = new Size(487, 40);
            panelDeptButtons.TabIndex = 1;

            btnAddDept.BackColor = Color.FromArgb(46, 204, 113);
            btnAddDept.Cursor = Cursors.Hand;
            btnAddDept.FlatAppearance.BorderSize = 0;
            btnAddDept.FlatStyle = FlatStyle.Flat;
            btnAddDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDept.ForeColor = Color.White;
            btnAddDept.Location = new Point(10, 5);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(100, 30);
            btnAddDept.TabIndex = 0;
            btnAddDept.Text = "➕ Add";
            btnAddDept.UseVisualStyleBackColor = false;

            btnDeleteDept.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteDept.Cursor = Cursors.Hand;
            btnDeleteDept.FlatAppearance.BorderSize = 0;
            btnDeleteDept.FlatStyle = FlatStyle.Flat;
            btnDeleteDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDept.ForeColor = Color.White;
            btnDeleteDept.Location = new Point(120, 5);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(100, 30);
            btnDeleteDept.TabIndex = 1;
            btnDeleteDept.Text = "🗑️ Delete";
            btnDeleteDept.UseVisualStyleBackColor = false;
            btnDeleteDept.Enabled = false;

            // Departments DataGridView
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AllowUserToResizeColumns = false;
            dgvDepartments.AllowUserToResizeRows = false;
            dgvDepartments.BackgroundColor = Color.White;
            dgvDepartments.BorderStyle = BorderStyle.None;
            dgvDepartments.ColumnHeadersHeight = 30;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDepartments.Columns.AddRange(new DataGridViewColumn[] { id, colDepartmentName, colDescription, colEmployeeCount });
            dgvDepartments.Dock = DockStyle.Top;
            dgvDepartments.EnableHeadersVisualStyles = false;
            dgvDepartments.Location = new Point(0, 70);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersVisible = false;
            dgvDepartments.RowTemplate.Height = 28;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(487, 180);
            dgvDepartments.TabIndex = 2;

            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 40;

            colDepartmentName.HeaderText = "Department";
            colDepartmentName.MinimumWidth = 6;
            colDepartmentName.Name = "colDepartmentName";
            colDepartmentName.ReadOnly = true;
            colDepartmentName.Resizable = DataGridViewTriState.False;
            colDepartmentName.Width = 150;

            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Resizable = DataGridViewTriState.False;
            colDescription.Width = 170;

            colEmployeeCount.HeaderText = "👥";
            colEmployeeCount.MinimumWidth = 6;
            colEmployeeCount.Name = "colEmployeeCount";
            colEmployeeCount.ReadOnly = true;
            colEmployeeCount.Resizable = DataGridViewTriState.False;
            colEmployeeCount.Width = 50;

            // Department Details Panel
            pnlDeptDetails.BackColor = Color.FromArgb(248, 249, 250);
            pnlDeptDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDeptDetails.Controls.Add(lblDeptDetailsTitle);
            pnlDeptDetails.Controls.Add(lblDeptName);
            pnlDeptDetails.Controls.Add(txtDeptName);
            pnlDeptDetails.Controls.Add(lblDeptDescription);
            pnlDeptDetails.Controls.Add(txtDeptDescription);
            pnlDeptDetails.Controls.Add(lblDeptEmployeeCount);
            pnlDeptDetails.Controls.Add(txtDeptEmployeeCount);
            pnlDeptDetails.Controls.Add(btnSaveDept);
            pnlDeptDetails.Controls.Add(btnCancelDept);
            pnlDeptDetails.Dock = DockStyle.Top;
            pnlDeptDetails.Location = new Point(0, 250);
            pnlDeptDetails.Name = "pnlDeptDetails";
            pnlDeptDetails.Size = new Size(487, 180);
            pnlDeptDetails.TabIndex = 3;
            pnlDeptDetails.Visible = false;

            lblDeptDetailsTitle.AutoSize = true;
            lblDeptDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDeptDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDetailsTitle.Location = new Point(10, 8);
            lblDeptDetailsTitle.Name = "lblDeptDetailsTitle";
            lblDeptDetailsTitle.Size = new Size(184, 28);
            lblDeptDetailsTitle.TabIndex = 0;
            lblDeptDetailsTitle.Text = "Department Details";

            lblDeptName.AutoSize = true;
            lblDeptName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptName.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptName.Location = new Point(10, 45);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(117, 20);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Department Name:";

            txtDeptName.BorderStyle = BorderStyle.FixedSingle;
            txtDeptName.Font = new Font("Segoe UI", 10F);
            txtDeptName.Location = new Point(140, 42);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(220, 30);
            txtDeptName.TabIndex = 2;

            lblDeptDescription.AutoSize = true;
            lblDeptDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptDescription.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDescription.Location = new Point(10, 80);
            lblDeptDescription.Name = "lblDeptDescription";
            lblDeptDescription.Size = new Size(88, 20);
            lblDeptDescription.TabIndex = 3;
            lblDeptDescription.Text = "Description:";

            txtDeptDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDeptDescription.Font = new Font("Segoe UI", 10F);
            txtDeptDescription.Location = new Point(140, 77);
            txtDeptDescription.Name = "txtDeptDescription";
            txtDeptDescription.Size = new Size(220, 30);
            txtDeptDescription.TabIndex = 4;

            lblDeptEmployeeCount.AutoSize = true;
            lblDeptEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptEmployeeCount.Location = new Point(10, 115);
            lblDeptEmployeeCount.Name = "lblDeptEmployeeCount";
            lblDeptEmployeeCount.Size = new Size(123, 20);
            lblDeptEmployeeCount.TabIndex = 5;
            lblDeptEmployeeCount.Text = "Employee Count:";

            txtDeptEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDeptEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDeptEmployeeCount.Location = new Point(140, 112);
            txtDeptEmployeeCount.Name = "txtDeptEmployeeCount";
            txtDeptEmployeeCount.ReadOnly = true;
            txtDeptEmployeeCount.Size = new Size(100, 30);
            txtDeptEmployeeCount.TabIndex = 6;
            txtDeptEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);

            btnSaveDept.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveDept.Cursor = Cursors.Hand;
            btnSaveDept.FlatAppearance.BorderSize = 0;
            btnSaveDept.FlatStyle = FlatStyle.Flat;
            btnSaveDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDept.ForeColor = Color.White;
            btnSaveDept.Location = new Point(370, 40);
            btnSaveDept.Name = "btnSaveDept";
            btnSaveDept.Size = new Size(100, 30);
            btnSaveDept.TabIndex = 7;
            btnSaveDept.Text = "💾 Save";
            btnSaveDept.UseVisualStyleBackColor = false;

            btnCancelDept.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDept.Cursor = Cursors.Hand;
            btnCancelDept.FlatAppearance.BorderSize = 0;
            btnCancelDept.FlatStyle = FlatStyle.Flat;
            btnCancelDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDept.ForeColor = Color.White;
            btnCancelDept.Location = new Point(370, 75);
            btnCancelDept.Name = "btnCancelDept";
            btnCancelDept.Size = new Size(100, 30);
            btnCancelDept.TabIndex = 8;
            btnCancelDept.Text = "❌ Cancel";
            btnCancelDept.UseVisualStyleBackColor = false;

            // Department Info
            lblDeptInfo.AutoSize = true;
            lblDeptInfo.Font = new Font("Segoe UI", 8F);
            lblDeptInfo.ForeColor = Color.Gray;
            lblDeptInfo.Location = new Point(10, 435);
            lblDeptInfo.Name = "lblDeptInfo";
            lblDeptInfo.Size = new Size(286, 19);
            lblDeptInfo.TabIndex = 4;
            lblDeptInfo.Text = "💡 Click a department to view and edit details";

            // ============================================
            // RIGHT PANEL - DESIGNATIONS
            // ============================================
            panelRight.BackColor = Color.White;
            panelRight.BorderStyle = BorderStyle.FixedSingle;
            panelRight.Controls.Add(panelDesigHeader);
            panelRight.Controls.Add(panelDesigButtons);
            panelRight.Controls.Add(dgvDesignations);
            panelRight.Controls.Add(pnlDesigDetails);
            panelRight.Controls.Add(lblDesigInfo);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(489, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(489, 600);
            panelRight.TabIndex = 1;

            // Designation Header
            panelDesigHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDesigHeader.Controls.Add(lblDesigHeader);
            panelDesigHeader.Dock = DockStyle.Top;
            panelDesigHeader.Location = new Point(0, 0);
            panelDesigHeader.Name = "panelDesigHeader";
            panelDesigHeader.Size = new Size(487, 30);
            panelDesigHeader.TabIndex = 0;

            lblDesigHeader.AutoSize = true;
            lblDesigHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesigHeader.ForeColor = Color.White;
            lblDesigHeader.Location = new Point(10, 4);
            lblDesigHeader.Name = "lblDesigHeader";
            lblDesigHeader.Size = new Size(124, 23);
            lblDesigHeader.TabIndex = 0;
            lblDesigHeader.Text = "Designations";

            // Designation Buttons
            panelDesigButtons.Controls.Add(btnAddDesig);
            panelDesigButtons.Controls.Add(btnDeleteDesig);
            panelDesigButtons.Dock = DockStyle.Top;
            panelDesigButtons.Location = new Point(0, 30);
            panelDesigButtons.Name = "panelDesigButtons";
            panelDesigButtons.Size = new Size(487, 40);
            panelDesigButtons.TabIndex = 1;

            btnAddDesig.BackColor = Color.FromArgb(46, 204, 113);
            btnAddDesig.Cursor = Cursors.Hand;
            btnAddDesig.FlatAppearance.BorderSize = 0;
            btnAddDesig.FlatStyle = FlatStyle.Flat;
            btnAddDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDesig.ForeColor = Color.White;
            btnAddDesig.Location = new Point(10, 5);
            btnAddDesig.Name = "btnAddDesig";
            btnAddDesig.Size = new Size(100, 30);
            btnAddDesig.TabIndex = 0;
            btnAddDesig.Text = "➕ Add";
            btnAddDesig.UseVisualStyleBackColor = false;

            btnDeleteDesig.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteDesig.Cursor = Cursors.Hand;
            btnDeleteDesig.FlatAppearance.BorderSize = 0;
            btnDeleteDesig.FlatStyle = FlatStyle.Flat;
            btnDeleteDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDesig.ForeColor = Color.White;
            btnDeleteDesig.Location = new Point(120, 5);
            btnDeleteDesig.Name = "btnDeleteDesig";
            btnDeleteDesig.Size = new Size(100, 30);
            btnDeleteDesig.TabIndex = 1;
            btnDeleteDesig.Text = "🗑️ Delete";
            btnDeleteDesig.UseVisualStyleBackColor = false;
            btnDeleteDesig.Enabled = false;

            // Designations DataGridView
            dgvDesignations.AllowUserToAddRows = false;
            dgvDesignations.AllowUserToDeleteRows = false;
            dgvDesignations.AllowUserToResizeColumns = false;
            dgvDesignations.AllowUserToResizeRows = false;
            dgvDesignations.BackgroundColor = Color.White;
            dgvDesignations.BorderStyle = BorderStyle.None;
            dgvDesignations.ColumnHeadersHeight = 30;
            dgvDesignations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDesignations.Columns.AddRange(new DataGridViewColumn[] { DesignationId, Title, DeptName, DesigEmployeeCount });
            dgvDesignations.Dock = DockStyle.Top;
            dgvDesignations.EnableHeadersVisualStyles = false;
            dgvDesignations.Location = new Point(0, 70);
            dgvDesignations.MultiSelect = false;
            dgvDesignations.Name = "dgvDesignations";
            dgvDesignations.ReadOnly = true;
            dgvDesignations.RowHeadersVisible = false;
            dgvDesignations.RowTemplate.Height = 28;
            dgvDesignations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesignations.Size = new Size(487, 180);
            dgvDesignations.TabIndex = 2;

            DesignationId.HeaderText = "ID";
            DesignationId.MinimumWidth = 6;
            DesignationId.Name = "DesignationId";
            DesignationId.ReadOnly = true;
            DesignationId.Resizable = DataGridViewTriState.False;
            DesignationId.Width = 40;

            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Resizable = DataGridViewTriState.False;
            Title.Width = 150;

            DeptName.HeaderText = "Department";
            DeptName.MinimumWidth = 6;
            DeptName.Name = "DeptName";
            DeptName.ReadOnly = true;
            DeptName.Resizable = DataGridViewTriState.False;
            DeptName.Width = 170;

            DesigEmployeeCount.HeaderText = "👥";
            DesigEmployeeCount.MinimumWidth = 6;
            DesigEmployeeCount.Name = "DesigEmployeeCount";
            DesigEmployeeCount.ReadOnly = true;
            DesigEmployeeCount.Resizable = DataGridViewTriState.False;
            DesigEmployeeCount.Width = 50;

            // Designation Details Panel
            pnlDesigDetails.BackColor = Color.FromArgb(248, 249, 250);
            pnlDesigDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDesigDetails.Controls.Add(lblDesigDetailsTitle);
            pnlDesigDetails.Controls.Add(lblDesigTitle);
            pnlDesigDetails.Controls.Add(txtDesigTitle);
            pnlDesigDetails.Controls.Add(lblDesigDepartment);
            pnlDesigDetails.Controls.Add(cmbDesigDepartment);
            pnlDesigDetails.Controls.Add(lblDesigEmployeeCount);
            pnlDesigDetails.Controls.Add(txtDesigEmployeeCount);
            pnlDesigDetails.Controls.Add(btnSaveDesig);
            pnlDesigDetails.Controls.Add(btnCancelDesig);
            pnlDesigDetails.Dock = DockStyle.Top;
            pnlDesigDetails.Location = new Point(0, 250);
            pnlDesigDetails.Name = "pnlDesigDetails";
            pnlDesigDetails.Size = new Size(487, 180);
            pnlDesigDetails.TabIndex = 3;
            pnlDesigDetails.Visible = false;

            lblDesigDetailsTitle.AutoSize = true;
            lblDesigDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesigDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDetailsTitle.Location = new Point(10, 8);
            lblDesigDetailsTitle.Name = "lblDesigDetailsTitle";
            lblDesigDetailsTitle.Size = new Size(202, 28);
            lblDesigDetailsTitle.TabIndex = 0;
            lblDesigDetailsTitle.Text = "Designation Details";

            lblDesigTitle.AutoSize = true;
            lblDesigTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigTitle.Location = new Point(10, 45);
            lblDesigTitle.Name = "lblDesigTitle";
            lblDesigTitle.Size = new Size(87, 20);
            lblDesigTitle.TabIndex = 1;
            lblDesigTitle.Text = "Title Name:";

            txtDesigTitle.BorderStyle = BorderStyle.FixedSingle;
            txtDesigTitle.Font = new Font("Segoe UI", 10F);
            txtDesigTitle.Location = new Point(120, 42);
            txtDesigTitle.Name = "txtDesigTitle";
            txtDesigTitle.Size = new Size(220, 30);
            txtDesigTitle.TabIndex = 2;

            lblDesigDepartment.AutoSize = true;
            lblDesigDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigDepartment.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDepartment.Location = new Point(10, 80);
            lblDesigDepartment.Name = "lblDesigDepartment";
            lblDesigDepartment.Size = new Size(98, 20);
            lblDesigDepartment.TabIndex = 3;
            lblDesigDepartment.Text = "Department:";

            cmbDesigDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesigDepartment.Font = new Font("Segoe UI", 10F);
            cmbDesigDepartment.Location = new Point(120, 77);
            cmbDesigDepartment.Name = "cmbDesigDepartment";
            cmbDesigDepartment.Size = new Size(220, 31);
            cmbDesigDepartment.TabIndex = 4;

            lblDesigEmployeeCount.AutoSize = true;
            lblDesigEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigEmployeeCount.Location = new Point(10, 115);
            lblDesigEmployeeCount.Name = "lblDesigEmployeeCount";
            lblDesigEmployeeCount.Size = new Size(123, 20);
            lblDesigEmployeeCount.TabIndex = 5;
            lblDesigEmployeeCount.Text = "Employee Count:";

            txtDesigEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDesigEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDesigEmployeeCount.Location = new Point(120, 112);
            txtDesigEmployeeCount.Name = "txtDesigEmployeeCount";
            txtDesigEmployeeCount.ReadOnly = true;
            txtDesigEmployeeCount.Size = new Size(100, 30);
            txtDesigEmployeeCount.TabIndex = 6;
            txtDesigEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);

            btnSaveDesig.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveDesig.Cursor = Cursors.Hand;
            btnSaveDesig.FlatAppearance.BorderSize = 0;
            btnSaveDesig.FlatStyle = FlatStyle.Flat;
            btnSaveDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDesig.ForeColor = Color.White;
            btnSaveDesig.Location = new Point(370, 40);
            btnSaveDesig.Name = "btnSaveDesig";
            btnSaveDesig.Size = new Size(100, 30);
            btnSaveDesig.TabIndex = 7;
            btnSaveDesig.Text = "💾 Save";
            btnSaveDesig.UseVisualStyleBackColor = false;

            btnCancelDesig.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDesig.Cursor = Cursors.Hand;
            btnCancelDesig.FlatAppearance.BorderSize = 0;
            btnCancelDesig.FlatStyle = FlatStyle.Flat;
            btnCancelDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDesig.ForeColor = Color.White;
            btnCancelDesig.Location = new Point(370, 75);
            btnCancelDesig.Name = "btnCancelDesig";
            btnCancelDesig.Size = new Size(100, 30);
            btnCancelDesig.TabIndex = 8;
            btnCancelDesig.Text = "❌ Cancel";
            btnCancelDesig.UseVisualStyleBackColor = false;

            // Designation Info
            lblDesigInfo.AutoSize = true;
            lblDesigInfo.Font = new Font("Segoe UI", 8F);
            lblDesigInfo.ForeColor = Color.Gray;
            lblDesigInfo.Location = new Point(10, 435);
            lblDesigInfo.Name = "lblDesigInfo";
            lblDesigInfo.Size = new Size(294, 19);
            lblDesigInfo.TabIndex = 4;
            lblDesigInfo.Text = "💡 Click a designation to view and edit details";

            // ============================================
            // DEPARTMENT FORM
            // ============================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 650);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department & Designation - Employee Management System";

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
            panelMainContent.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelDeptHeader.ResumeLayout(false);
            panelDeptHeader.PerformLayout();
            panelDeptButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            pnlDeptDetails.ResumeLayout(false);
            pnlDeptDetails.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelDesigHeader.ResumeLayout(false);
            panelDesigHeader.PerformLayout();
            panelDesigButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).EndInit();
            pnlDesigDetails.ResumeLayout(false);
            pnlDesigDetails.PerformLayout();
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
        private Panel panelMainContent;

        // Left Panel - Departments
        private Panel panelLeft;
        private Panel panelDeptHeader;
        private Label lblDeptHeader;
        private Panel panelDeptButtons;
        private Button btnAddDept;
        private Button btnDeleteDept;
        private DataGridView dgvDepartments;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colDepartmentName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colEmployeeCount;
        private Panel pnlDeptDetails;
        private Label lblDeptDetailsTitle;
        private Label lblDeptName;
        private TextBox txtDeptName;
        private Label lblDeptDescription;
        private TextBox txtDeptDescription;
        private Label lblDeptEmployeeCount;
        private TextBox txtDeptEmployeeCount;
        private Button btnSaveDept;
        private Button btnCancelDept;
        private Label lblDeptInfo;

        // Right Panel - Designations
        private Panel panelRight;
        private Panel panelDesigHeader;
        private Label lblDesigHeader;
        private Panel panelDesigButtons;
        private Button btnAddDesig;
        private Button btnDeleteDesig;
        private DataGridView dgvDesignations;
        private DataGridViewTextBoxColumn DesignationId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn DeptName;
        private DataGridViewTextBoxColumn DesigEmployeeCount;
        private Panel pnlDesigDetails;
        private Label lblDesigDetailsTitle;
        private Label lblDesigTitle;
        private TextBox txtDesigTitle;
        private Label lblDesigDepartment;
        private ComboBox cmbDesigDepartment;
        private Label lblDesigEmployeeCount;
        private TextBox txtDesigEmployeeCount;
        private Button btnSaveDesig;
        private Button btnCancelDesig;
        private Label lblDesigInfo;
    }
}