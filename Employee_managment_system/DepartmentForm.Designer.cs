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
            mainContainer = new SplitContainer();
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
            panelContent = new Panel();
            topBar = new Panel();
            lblPageTitle = new Label();
            lblUserInfo = new Label();
            panelMainContent = new Panel();
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
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Margin = new Padding(5, 5, 5, 5);
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.BackColor = Color.FromArgb(25, 48, 78);
            mainContainer.Panel1.Controls.Add(panelSideMenu);
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.BackColor = Color.FromArgb(248, 249, 250);
            mainContainer.Panel2.Controls.Add(panelContent);
            mainContainer.Size = new Size(1950, 1040);
            mainContainer.SplitterDistance = 357;
            mainContainer.SplitterWidth = 3;
            mainContainer.TabIndex = 0;
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
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Dock = DockStyle.Fill;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(5, 5, 5, 5);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(357, 1040);
            panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(lblAppTitle);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(5, 5, 5, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(357, 128);
            panelLogo.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(122, 45);
            lblAppTitle.Margin = new Padding(5, 0, 5, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(182, 41);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "EMS Admin";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(32, 24);
            pictureBoxLogo.Margin = new Padding(5, 5, 5, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(73, 72);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Margin = new Padding(5, 5, 5, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(358, 72);
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
            btnEmployees.Font = new Font("Segoe UI", 10F);
            btnEmployees.ForeColor = Color.FromArgb(200, 200, 200);
            btnEmployees.Location = new Point(0, 224);
            btnEmployees.Margin = new Padding(5, 5, 5, 5);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(358, 72);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(52, 152, 219);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDepartment.ForeColor = Color.White;
            btnDepartment.Location = new Point(0, 304);
            btnDepartment.Margin = new Padding(5, 5, 5, 5);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(358, 72);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(25, 48, 78);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 384);
            btnAttendance.Margin = new Padding(5, 5, 5, 5);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(358, 72);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(25, 48, 78);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 10F);
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 464);
            btnLeave.Margin = new Padding(5, 5, 5, 5);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(358, 72);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(25, 48, 78);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 544);
            btnPayroll.Margin = new Padding(5, 5, 5, 5);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(358, 72);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
            btnReports.Location = new Point(0, 624);
            btnReports.Margin = new Padding(5, 5, 5, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(358, 72);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 928);
            btnLogout.Margin = new Padding(5, 5, 5, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(358, 72);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(topBar);
            panelContent.Controls.Add(panelMainContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(5, 5, 5, 5);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1590, 1040);
            panelContent.TabIndex = 0;
            // 
            // topBar
            // 
            topBar.BackColor = Color.White;
            topBar.Controls.Add(lblPageTitle);
            topBar.Controls.Add(lblUserInfo);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Margin = new Padding(5, 5, 5, 5);
            topBar.Name = "topBar";
            topBar.Size = new Size(1590, 80);
            topBar.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblPageTitle.Location = new Point(32, 13);
            lblPageTitle.Margin = new Padding(5, 0, 5, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(537, 59);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Department & Designation";
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 10F);
            lblUserInfo.ForeColor = Color.Gray;
            lblUserInfo.Location = new Point(1381, 19);
            lblUserInfo.Margin = new Padding(5, 0, 5, 0);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(133, 37);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "👤 Admin";
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(248, 249, 250);
            panelMainContent.Controls.Add(panelLeft);
            panelMainContent.Controls.Add(panelRight);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 0);
            panelMainContent.Margin = new Padding(5, 5, 5, 5);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1590, 1040);
            panelMainContent.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(panelDeptHeader);
            panelLeft.Controls.Add(panelDeptButtons);
            panelLeft.Controls.Add(dgvDepartments);
            panelLeft.Controls.Add(pnlDeptDetails);
            panelLeft.Controls.Add(lblDeptInfo);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(5, 5, 5, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(797, 1040);
            panelLeft.TabIndex = 0;
            // 
            // panelDeptHeader
            // 
            panelDeptHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDeptHeader.Controls.Add(lblDeptHeader);
            panelDeptHeader.Dock = DockStyle.Top;
            panelDeptHeader.Location = new Point(0, 639);
            panelDeptHeader.Margin = new Padding(5, 5, 5, 5);
            panelDeptHeader.Name = "panelDeptHeader";
            panelDeptHeader.Size = new Size(795, 48);
            panelDeptHeader.TabIndex = 0;
            // 
            // lblDeptHeader
            // 
            lblDeptHeader.AutoSize = true;
            lblDeptHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeptHeader.ForeColor = Color.White;
            lblDeptHeader.Location = new Point(16, 6);
            lblDeptHeader.Margin = new Padding(5, 0, 5, 0);
            lblDeptHeader.Name = "lblDeptHeader";
            lblDeptHeader.Size = new Size(186, 37);
            lblDeptHeader.TabIndex = 0;
            lblDeptHeader.Text = "Departments";
            // 
            // panelDeptButtons
            // 
            panelDeptButtons.Controls.Add(btnAddDept);
            panelDeptButtons.Controls.Add(btnDeleteDept);
            panelDeptButtons.Dock = DockStyle.Top;
            panelDeptButtons.Location = new Point(0, 575);
            panelDeptButtons.Margin = new Padding(5, 5, 5, 5);
            panelDeptButtons.Name = "panelDeptButtons";
            panelDeptButtons.Size = new Size(795, 64);
            panelDeptButtons.TabIndex = 1;
            // 
            // btnAddDept
            // 
            btnAddDept.BackColor = Color.FromArgb(46, 204, 113);
            btnAddDept.Cursor = Cursors.Hand;
            btnAddDept.FlatAppearance.BorderSize = 0;
            btnAddDept.FlatStyle = FlatStyle.Flat;
            btnAddDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDept.ForeColor = Color.White;
            btnAddDept.Location = new Point(16, 8);
            btnAddDept.Margin = new Padding(5, 5, 5, 5);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(162, 48);
            btnAddDept.TabIndex = 0;
            btnAddDept.Text = "➕ Add";
            btnAddDept.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDept
            // 
            btnDeleteDept.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteDept.Cursor = Cursors.Hand;
            btnDeleteDept.Enabled = false;
            btnDeleteDept.FlatAppearance.BorderSize = 0;
            btnDeleteDept.FlatStyle = FlatStyle.Flat;
            btnDeleteDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDept.ForeColor = Color.White;
            btnDeleteDept.Location = new Point(195, 8);
            btnDeleteDept.Margin = new Padding(5, 5, 5, 5);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(162, 48);
            btnDeleteDept.TabIndex = 1;
            btnDeleteDept.Text = "🗑️ Delete";
            btnDeleteDept.UseVisualStyleBackColor = false;
            // 
            // dgvDepartments
            // 
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
            dgvDepartments.Location = new Point(0, 287);
            dgvDepartments.Margin = new Padding(5, 5, 5, 5);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersVisible = false;
            dgvDepartments.RowHeadersWidth = 82;
            dgvDepartments.RowTemplate.Height = 28;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(795, 288);
            dgvDepartments.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 40;
            // 
            // colDepartmentName
            // 
            colDepartmentName.HeaderText = "Department";
            colDepartmentName.MinimumWidth = 6;
            colDepartmentName.Name = "colDepartmentName";
            colDepartmentName.ReadOnly = true;
            colDepartmentName.Resizable = DataGridViewTriState.False;
            colDepartmentName.Width = 150;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Resizable = DataGridViewTriState.False;
            colDescription.Width = 170;
            // 
            // colEmployeeCount
            // 
            colEmployeeCount.HeaderText = "👥";
            colEmployeeCount.MinimumWidth = 6;
            colEmployeeCount.Name = "colEmployeeCount";
            colEmployeeCount.ReadOnly = true;
            colEmployeeCount.Resizable = DataGridViewTriState.False;
            colEmployeeCount.Width = 50;
            // 
            // pnlDeptDetails
            // 
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
            pnlDeptDetails.Location = new Point(0, 0);
            pnlDeptDetails.Margin = new Padding(5, 5, 5, 5);
            pnlDeptDetails.Name = "pnlDeptDetails";
            pnlDeptDetails.Size = new Size(795, 287);
            pnlDeptDetails.TabIndex = 3;
            pnlDeptDetails.Visible = false;
            // 
            // lblDeptDetailsTitle
            // 
            lblDeptDetailsTitle.AutoSize = true;
            lblDeptDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDeptDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDetailsTitle.Location = new Point(16, 13);
            lblDeptDetailsTitle.Margin = new Padding(5, 0, 5, 0);
            lblDeptDetailsTitle.Name = "lblDeptDetailsTitle";
            lblDeptDetailsTitle.Size = new Size(312, 45);
            lblDeptDetailsTitle.TabIndex = 0;
            lblDeptDetailsTitle.Text = "Department Details";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptName.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptName.Location = new Point(16, 72);
            lblDeptName.Margin = new Padding(5, 0, 5, 0);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(233, 32);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Department Name:";
            // 
            // txtDeptName
            // 
            txtDeptName.BorderStyle = BorderStyle.FixedSingle;
            txtDeptName.Font = new Font("Segoe UI", 10F);
            txtDeptName.Location = new Point(228, 67);
            txtDeptName.Margin = new Padding(5, 5, 5, 5);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(356, 43);
            txtDeptName.TabIndex = 2;
            // 
            // lblDeptDescription
            // 
            lblDeptDescription.AutoSize = true;
            lblDeptDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptDescription.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDescription.Location = new Point(16, 128);
            lblDeptDescription.Margin = new Padding(5, 0, 5, 0);
            lblDeptDescription.Name = "lblDeptDescription";
            lblDeptDescription.Size = new Size(153, 32);
            lblDeptDescription.TabIndex = 3;
            lblDeptDescription.Text = "Description:";
            // 
            // txtDeptDescription
            // 
            txtDeptDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDeptDescription.Font = new Font("Segoe UI", 10F);
            txtDeptDescription.Location = new Point(228, 123);
            txtDeptDescription.Margin = new Padding(5, 5, 5, 5);
            txtDeptDescription.Name = "txtDeptDescription";
            txtDeptDescription.Size = new Size(356, 43);
            txtDeptDescription.TabIndex = 4;
            // 
            // lblDeptEmployeeCount
            // 
            lblDeptEmployeeCount.AutoSize = true;
            lblDeptEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptEmployeeCount.Location = new Point(16, 184);
            lblDeptEmployeeCount.Margin = new Padding(5, 0, 5, 0);
            lblDeptEmployeeCount.Name = "lblDeptEmployeeCount";
            lblDeptEmployeeCount.Size = new Size(208, 32);
            lblDeptEmployeeCount.TabIndex = 5;
            lblDeptEmployeeCount.Text = "Employee Count:";
            // 
            // txtDeptEmployeeCount
            // 
            txtDeptEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);
            txtDeptEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDeptEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDeptEmployeeCount.Location = new Point(228, 179);
            txtDeptEmployeeCount.Margin = new Padding(5, 5, 5, 5);
            txtDeptEmployeeCount.Name = "txtDeptEmployeeCount";
            txtDeptEmployeeCount.ReadOnly = true;
            txtDeptEmployeeCount.Size = new Size(161, 43);
            txtDeptEmployeeCount.TabIndex = 6;
            // 
            // btnSaveDept
            // 
            btnSaveDept.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveDept.Cursor = Cursors.Hand;
            btnSaveDept.FlatAppearance.BorderSize = 0;
            btnSaveDept.FlatStyle = FlatStyle.Flat;
            btnSaveDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDept.ForeColor = Color.White;
            btnSaveDept.Location = new Point(601, 64);
            btnSaveDept.Margin = new Padding(5, 5, 5, 5);
            btnSaveDept.Name = "btnSaveDept";
            btnSaveDept.Size = new Size(162, 48);
            btnSaveDept.TabIndex = 7;
            btnSaveDept.Text = "💾 Save";
            btnSaveDept.UseVisualStyleBackColor = false;
            // 
            // btnCancelDept
            // 
            btnCancelDept.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDept.Cursor = Cursors.Hand;
            btnCancelDept.FlatAppearance.BorderSize = 0;
            btnCancelDept.FlatStyle = FlatStyle.Flat;
            btnCancelDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDept.ForeColor = Color.White;
            btnCancelDept.Location = new Point(601, 120);
            btnCancelDept.Margin = new Padding(5, 5, 5, 5);
            btnCancelDept.Name = "btnCancelDept";
            btnCancelDept.Size = new Size(162, 48);
            btnCancelDept.TabIndex = 8;
            btnCancelDept.Text = "❌ Cancel";
            btnCancelDept.UseVisualStyleBackColor = false;
            // 
            // lblDeptInfo
            // 
            lblDeptInfo.AutoSize = true;
            lblDeptInfo.Font = new Font("Segoe UI", 8F);
            lblDeptInfo.ForeColor = Color.Gray;
            lblDeptInfo.Location = new Point(16, 696);
            lblDeptInfo.Margin = new Padding(5, 0, 5, 0);
            lblDeptInfo.Name = "lblDeptInfo";
            lblDeptInfo.Size = new Size(453, 30);
            lblDeptInfo.TabIndex = 4;
            lblDeptInfo.Text = "💡 Click a department to view and edit details";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.BorderStyle = BorderStyle.FixedSingle;
            panelRight.Controls.Add(panelDesigHeader);
            panelRight.Controls.Add(panelDesigButtons);
            panelRight.Controls.Add(dgvDesignations);
            panelRight.Controls.Add(pnlDesigDetails);
            panelRight.Controls.Add(lblDesigInfo);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(797, 0);
            panelRight.Margin = new Padding(5, 5, 5, 5);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(793, 1040);
            panelRight.TabIndex = 1;
            // 
            // panelDesigHeader
            // 
            panelDesigHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDesigHeader.Controls.Add(lblDesigHeader);
            panelDesigHeader.Dock = DockStyle.Top;
            panelDesigHeader.Location = new Point(0, 639);
            panelDesigHeader.Margin = new Padding(5, 5, 5, 5);
            panelDesigHeader.Name = "panelDesigHeader";
            panelDesigHeader.Size = new Size(791, 48);
            panelDesigHeader.TabIndex = 0;
            // 
            // lblDesigHeader
            // 
            lblDesigHeader.AutoSize = true;
            lblDesigHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesigHeader.ForeColor = Color.White;
            lblDesigHeader.Location = new Point(16, 6);
            lblDesigHeader.Margin = new Padding(5, 0, 5, 0);
            lblDesigHeader.Name = "lblDesigHeader";
            lblDesigHeader.Size = new Size(184, 37);
            lblDesigHeader.TabIndex = 0;
            lblDesigHeader.Text = "Designations";
            // 
            // panelDesigButtons
            // 
            panelDesigButtons.Controls.Add(btnAddDesig);
            panelDesigButtons.Controls.Add(btnDeleteDesig);
            panelDesigButtons.Dock = DockStyle.Top;
            panelDesigButtons.Location = new Point(0, 575);
            panelDesigButtons.Margin = new Padding(5, 5, 5, 5);
            panelDesigButtons.Name = "panelDesigButtons";
            panelDesigButtons.Size = new Size(791, 64);
            panelDesigButtons.TabIndex = 1;
            // 
            // btnAddDesig
            // 
            btnAddDesig.BackColor = Color.FromArgb(46, 204, 113);
            btnAddDesig.Cursor = Cursors.Hand;
            btnAddDesig.FlatAppearance.BorderSize = 0;
            btnAddDesig.FlatStyle = FlatStyle.Flat;
            btnAddDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDesig.ForeColor = Color.White;
            btnAddDesig.Location = new Point(16, 8);
            btnAddDesig.Margin = new Padding(5, 5, 5, 5);
            btnAddDesig.Name = "btnAddDesig";
            btnAddDesig.Size = new Size(162, 48);
            btnAddDesig.TabIndex = 0;
            btnAddDesig.Text = "➕ Add";
            btnAddDesig.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDesig
            // 
            btnDeleteDesig.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteDesig.Cursor = Cursors.Hand;
            btnDeleteDesig.Enabled = false;
            btnDeleteDesig.FlatAppearance.BorderSize = 0;
            btnDeleteDesig.FlatStyle = FlatStyle.Flat;
            btnDeleteDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDesig.ForeColor = Color.White;
            btnDeleteDesig.Location = new Point(195, 8);
            btnDeleteDesig.Margin = new Padding(5, 5, 5, 5);
            btnDeleteDesig.Name = "btnDeleteDesig";
            btnDeleteDesig.Size = new Size(162, 48);
            btnDeleteDesig.TabIndex = 1;
            btnDeleteDesig.Text = "🗑️ Delete";
            btnDeleteDesig.UseVisualStyleBackColor = false;
            // 
            // dgvDesignations
            // 
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
            dgvDesignations.Location = new Point(0, 287);
            dgvDesignations.Margin = new Padding(5, 5, 5, 5);
            dgvDesignations.MultiSelect = false;
            dgvDesignations.Name = "dgvDesignations";
            dgvDesignations.ReadOnly = true;
            dgvDesignations.RowHeadersVisible = false;
            dgvDesignations.RowHeadersWidth = 82;
            dgvDesignations.RowTemplate.Height = 28;
            dgvDesignations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesignations.Size = new Size(791, 288);
            dgvDesignations.TabIndex = 2;
            // 
            // DesignationId
            // 
            DesignationId.HeaderText = "ID";
            DesignationId.MinimumWidth = 6;
            DesignationId.Name = "DesignationId";
            DesignationId.ReadOnly = true;
            DesignationId.Resizable = DataGridViewTriState.False;
            DesignationId.Width = 40;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Resizable = DataGridViewTriState.False;
            Title.Width = 150;
            // 
            // DeptName
            // 
            DeptName.HeaderText = "Department";
            DeptName.MinimumWidth = 6;
            DeptName.Name = "DeptName";
            DeptName.ReadOnly = true;
            DeptName.Resizable = DataGridViewTriState.False;
            DeptName.Width = 170;
            // 
            // DesigEmployeeCount
            // 
            DesigEmployeeCount.HeaderText = "👥";
            DesigEmployeeCount.MinimumWidth = 6;
            DesigEmployeeCount.Name = "DesigEmployeeCount";
            DesigEmployeeCount.ReadOnly = true;
            DesigEmployeeCount.Resizable = DataGridViewTriState.False;
            DesigEmployeeCount.Width = 50;
            // 
            // pnlDesigDetails
            // 
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
            pnlDesigDetails.Location = new Point(0, 0);
            pnlDesigDetails.Margin = new Padding(5, 5, 5, 5);
            pnlDesigDetails.Name = "pnlDesigDetails";
            pnlDesigDetails.Size = new Size(791, 287);
            pnlDesigDetails.TabIndex = 3;
            pnlDesigDetails.Visible = false;
            // 
            // lblDesigDetailsTitle
            // 
            lblDesigDetailsTitle.AutoSize = true;
            lblDesigDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesigDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDetailsTitle.Location = new Point(16, 13);
            lblDesigDetailsTitle.Margin = new Padding(5, 0, 5, 0);
            lblDesigDetailsTitle.Name = "lblDesigDetailsTitle";
            lblDesigDetailsTitle.Size = new Size(311, 45);
            lblDesigDetailsTitle.TabIndex = 0;
            lblDesigDetailsTitle.Text = "Designation Details";
            // 
            // lblDesigTitle
            // 
            lblDesigTitle.AutoSize = true;
            lblDesigTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigTitle.Location = new Point(16, 72);
            lblDesigTitle.Margin = new Padding(5, 0, 5, 0);
            lblDesigTitle.Name = "lblDesigTitle";
            lblDesigTitle.Size = new Size(145, 32);
            lblDesigTitle.TabIndex = 1;
            lblDesigTitle.Text = "Title Name:";
            // 
            // txtDesigTitle
            // 
            txtDesigTitle.BorderStyle = BorderStyle.FixedSingle;
            txtDesigTitle.Font = new Font("Segoe UI", 10F);
            txtDesigTitle.Location = new Point(195, 67);
            txtDesigTitle.Margin = new Padding(5, 5, 5, 5);
            txtDesigTitle.Name = "txtDesigTitle";
            txtDesigTitle.Size = new Size(356, 43);
            txtDesigTitle.TabIndex = 2;
            // 
            // lblDesigDepartment
            // 
            lblDesigDepartment.AutoSize = true;
            lblDesigDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigDepartment.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDepartment.Location = new Point(16, 128);
            lblDesigDepartment.Margin = new Padding(5, 0, 5, 0);
            lblDesigDepartment.Name = "lblDesigDepartment";
            lblDesigDepartment.Size = new Size(159, 32);
            lblDesigDepartment.TabIndex = 3;
            lblDesigDepartment.Text = "Department:";
            // 
            // cmbDesigDepartment
            // 
            cmbDesigDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesigDepartment.Font = new Font("Segoe UI", 10F);
            cmbDesigDepartment.Location = new Point(195, 123);
            cmbDesigDepartment.Margin = new Padding(5, 5, 5, 5);
            cmbDesigDepartment.Name = "cmbDesigDepartment";
            cmbDesigDepartment.Size = new Size(355, 45);
            cmbDesigDepartment.TabIndex = 4;
            // 
            // lblDesigEmployeeCount
            // 
            lblDesigEmployeeCount.AutoSize = true;
            lblDesigEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigEmployeeCount.Location = new Point(16, 184);
            lblDesigEmployeeCount.Margin = new Padding(5, 0, 5, 0);
            lblDesigEmployeeCount.Name = "lblDesigEmployeeCount";
            lblDesigEmployeeCount.Size = new Size(208, 32);
            lblDesigEmployeeCount.TabIndex = 5;
            lblDesigEmployeeCount.Text = "Employee Count:";
            // 
            // txtDesigEmployeeCount
            // 
            txtDesigEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);
            txtDesigEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDesigEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDesigEmployeeCount.Location = new Point(195, 179);
            txtDesigEmployeeCount.Margin = new Padding(5, 5, 5, 5);
            txtDesigEmployeeCount.Name = "txtDesigEmployeeCount";
            txtDesigEmployeeCount.ReadOnly = true;
            txtDesigEmployeeCount.Size = new Size(161, 43);
            txtDesigEmployeeCount.TabIndex = 6;
            // 
            // btnSaveDesig
            // 
            btnSaveDesig.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveDesig.Cursor = Cursors.Hand;
            btnSaveDesig.FlatAppearance.BorderSize = 0;
            btnSaveDesig.FlatStyle = FlatStyle.Flat;
            btnSaveDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDesig.ForeColor = Color.White;
            btnSaveDesig.Location = new Point(601, 64);
            btnSaveDesig.Margin = new Padding(5, 5, 5, 5);
            btnSaveDesig.Name = "btnSaveDesig";
            btnSaveDesig.Size = new Size(162, 48);
            btnSaveDesig.TabIndex = 7;
            btnSaveDesig.Text = "💾 Save";
            btnSaveDesig.UseVisualStyleBackColor = false;
            // 
            // btnCancelDesig
            // 
            btnCancelDesig.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDesig.Cursor = Cursors.Hand;
            btnCancelDesig.FlatAppearance.BorderSize = 0;
            btnCancelDesig.FlatStyle = FlatStyle.Flat;
            btnCancelDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDesig.ForeColor = Color.White;
            btnCancelDesig.Location = new Point(601, 120);
            btnCancelDesig.Margin = new Padding(5, 5, 5, 5);
            btnCancelDesig.Name = "btnCancelDesig";
            btnCancelDesig.Size = new Size(162, 48);
            btnCancelDesig.TabIndex = 8;
            btnCancelDesig.Text = "❌ Cancel";
            btnCancelDesig.UseVisualStyleBackColor = false;
            // 
            // lblDesigInfo
            // 
            lblDesigInfo.AutoSize = true;
            lblDesigInfo.Font = new Font("Segoe UI", 8F);
            lblDesigInfo.ForeColor = Color.Gray;
            lblDesigInfo.Location = new Point(16, 696);
            lblDesigInfo.Margin = new Padding(5, 0, 5, 0);
            lblDesigInfo.Name = "lblDesigInfo";
            lblDesigInfo.Size = new Size(451, 30);
            lblDesigInfo.TabIndex = 4;
            lblDesigInfo.Text = "💡 Click a designation to view and edit details";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1950, 1040);
            Controls.Add(mainContainer);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department & Designation - Employee Management System";
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
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