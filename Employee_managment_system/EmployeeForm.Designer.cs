namespace Employee_managment_system
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSideMenu = new Panel();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
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
            panelMainContent = new Panel();
            splitContainer1 = new SplitContainer();
            filterPanel = new Panel();
            txtSearch = new TextBox();
            cmbDeptFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();
            dgvEmployees = new DataGridView();
            colEmployeeCode = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colDesignation = new DataGridViewTextBoxColumn();
            colNIC = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlRightPanel = new Panel();
            lblPanelTitle = new Label();
            picEmployeePhoto = new PictureBox();
            btnUploadPhoto = new Button();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblNIC = new Label();
            txtNIC = new TextBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            lblJoinDate = new Label();
            dtpJoinDate = new DateTimePicker();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblDesignation = new Label();
            cmbDesignation = new ComboBox();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            topPanel = new Panel();
            btnAdd = new Button();
            btnExport = new Button();
            lblPageTitle = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelContent.SuspendLayout();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            pnlRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).BeginInit();
            topPanel.SuspendLayout();
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
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(5, 5, 5, 5);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(351, 1055);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(lblAppTitle);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(5, 5, 5, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(351, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_and_name_for_header;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(188, 48);
            lblAppTitle.Margin = new Padding(5, 0, 5, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(149, 41);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "NexusHR";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, -5);
            pictureBoxLogo.Margin = new Padding(5, 5, 5, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(151, 133);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
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
            btnDashboard.Size = new Size(344, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(52, 152, 219);
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(0, 224);
            btnEmployees.Margin = new Padding(5, 5, 5, 5);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(348, 45);
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
            btnDepartment.Font = new Font("Segoe UI", 10F);
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 304);
            btnDepartment.Margin = new Padding(5, 5, 5, 5);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(343, 45);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
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
            btnAttendance.Size = new Size(343, 45);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
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
            btnLeave.Size = new Size(343, 45);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
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
            btnPayroll.Size = new Size(343, 45);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
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
            btnReports.Size = new Size(343, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 1010);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(351, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelMainContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(351, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1573, 1055);
            panelContent.TabIndex = 1;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(248, 249, 250);
            panelMainContent.Controls.Add(splitContainer1);
            panelMainContent.Controls.Add(topPanel);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 0);
            panelMainContent.Margin = new Padding(5, 5, 5, 5);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1573, 1055);
            panelMainContent.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 85);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(filterPanel);
            splitContainer1.Panel1.Controls.Add(dgvEmployees);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlRightPanel);
            splitContainer1.Size = new Size(1573, 970);
            splitContainer1.SplitterDistance = 1099;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(248, 249, 250);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(cmbDeptFilter);
            filterPanel.Controls.Add(cmbStatusFilter);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(10, 8, 10, 8);
            filterPanel.Size = new Size(1099, 50);
            filterPanel.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(15, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by name, ID or email...";
            txtSearch.Size = new Size(250, 30);
            txtSearch.TabIndex = 0;
            // 
            // cmbDeptFilter
            // 
            cmbDeptFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptFilter.Font = new Font("Segoe UI", 10F);
            cmbDeptFilter.Location = new Point(280, 7);
            cmbDeptFilter.Name = "cmbDeptFilter";
            cmbDeptFilter.Size = new Size(150, 31);
            cmbDeptFilter.TabIndex = 1;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 10F);
            cmbStatusFilter.Location = new Point(445, 7);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(120, 31);
            cmbStatusFilter.TabIndex = 2;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.ColumnHeadersHeight = 35;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { colEmployeeCode, colFirstName, colLastName, colDepartment, colDesignation, colNIC, colContact, colStatus });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.Location = new Point(0, 50);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 35;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1099, 920);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // colEmployeeCode
            // 
            colEmployeeCode.HeaderText = "EMP ID";
            colEmployeeCode.MinimumWidth = 6;
            colEmployeeCode.Name = "colEmployeeCode";
            colEmployeeCode.ReadOnly = true;
            colEmployeeCode.Width = 80;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 125;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 125;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Width = 125;
            // 
            // colDesignation
            // 
            colDesignation.HeaderText = "Designation";
            colDesignation.MinimumWidth = 6;
            colDesignation.Name = "colDesignation";
            colDesignation.ReadOnly = true;
            colDesignation.Width = 125;
            // 
            // colNIC
            // 
            colNIC.HeaderText = "NIC";
            colNIC.MinimumWidth = 6;
            colNIC.Name = "colNIC";
            colNIC.ReadOnly = true;
            colNIC.Width = 90;
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            colContact.Width = 90;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // pnlRightPanel
            // 
            pnlRightPanel.BackColor = Color.FromArgb(248, 249, 250);
            pnlRightPanel.BorderStyle = BorderStyle.FixedSingle;
            pnlRightPanel.Controls.Add(lblPanelTitle);
            pnlRightPanel.Controls.Add(picEmployeePhoto);
            pnlRightPanel.Controls.Add(btnUploadPhoto);
            pnlRightPanel.Controls.Add(lblFirstName);
            pnlRightPanel.Controls.Add(txtFirstName);
            pnlRightPanel.Controls.Add(lblLastName);
            pnlRightPanel.Controls.Add(txtLastName);
            pnlRightPanel.Controls.Add(lblGender);
            pnlRightPanel.Controls.Add(cmbGender);
            pnlRightPanel.Controls.Add(lblNIC);
            pnlRightPanel.Controls.Add(txtNIC);
            pnlRightPanel.Controls.Add(lblDOB);
            pnlRightPanel.Controls.Add(dtpDOB);
            pnlRightPanel.Controls.Add(lblJoinDate);
            pnlRightPanel.Controls.Add(dtpJoinDate);
            pnlRightPanel.Controls.Add(lblContact);
            pnlRightPanel.Controls.Add(txtContact);
            pnlRightPanel.Controls.Add(lblEmail);
            pnlRightPanel.Controls.Add(txtEmail);
            pnlRightPanel.Controls.Add(lblCategory);
            pnlRightPanel.Controls.Add(cmbCategory);
            pnlRightPanel.Controls.Add(lblDepartment);
            pnlRightPanel.Controls.Add(cmbDepartment);
            pnlRightPanel.Controls.Add(lblDesignation);
            pnlRightPanel.Controls.Add(cmbDesignation);
            pnlRightPanel.Controls.Add(lblSalary);
            pnlRightPanel.Controls.Add(txtSalary);
            pnlRightPanel.Controls.Add(lblAddress);
            pnlRightPanel.Controls.Add(txtAddress);
            pnlRightPanel.Controls.Add(lblStatus);
            pnlRightPanel.Controls.Add(cmbStatus);
            pnlRightPanel.Controls.Add(btnSave);
            pnlRightPanel.Controls.Add(btnCancel);
            pnlRightPanel.Controls.Add(btnDelete);
            pnlRightPanel.Dock = DockStyle.Right;
            pnlRightPanel.Location = new Point(116, 0);
            pnlRightPanel.Name = "pnlRightPanel";
            pnlRightPanel.Size = new Size(352, 970);
            pnlRightPanel.TabIndex = 0;
            pnlRightPanel.Visible = false;
            // 
            // lblPanelTitle
            // 
            lblPanelTitle.AutoSize = true;
            lblPanelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPanelTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblPanelTitle.Location = new Point(16, 13);
            lblPanelTitle.Margin = new Padding(5, 0, 5, 0);
            lblPanelTitle.Name = "lblPanelTitle";
            lblPanelTitle.Size = new Size(330, 51);
            lblPanelTitle.TabIndex = 0;
            lblPanelTitle.Text = "Employee Details";
            // 
            // picEmployeePhoto
            // 
            picEmployeePhoto.BackColor = Color.FromArgb(236, 240, 241);
            picEmployeePhoto.BorderStyle = BorderStyle.FixedSingle;
            picEmployeePhoto.Location = new Point(16, 72);
            picEmployeePhoto.Margin = new Padding(5, 5, 5, 5);
            picEmployeePhoto.Name = "picEmployeePhoto";
            picEmployeePhoto.Size = new Size(161, 175);
            picEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployeePhoto.TabIndex = 1;
            picEmployeePhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(52, 152, 219);
            btnUploadPhoto.Cursor = Cursors.Hand;
            btnUploadPhoto.FlatAppearance.BorderSize = 0;
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(195, 144);
            btnUploadPhoto.Margin = new Padding(5, 5, 5, 5);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(162, 48);
            btnUploadPhoto.TabIndex = 2;
            btnUploadPhoto.Text = "📷 Upload";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(30, 58, 95);
            lblFirstName.Location = new Point(16, 264);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(131, 30);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(195, 259);
            txtFirstName.Margin = new Padding(5, 5, 5, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(324, 39);
            txtFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(30, 58, 95);
            lblLastName.Location = new Point(16, 312);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(128, 30);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.Location = new Point(195, 307);
            txtLastName.Margin = new Padding(5, 5, 5, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(324, 39);
            txtLastName.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(30, 58, 95);
            lblGender.Location = new Point(16, 360);
            lblGender.Margin = new Padding(5, 0, 5, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(96, 30);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 9F);
            cmbGender.Location = new Point(195, 355);
            cmbGender.Margin = new Padding(5, 5, 5, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(192, 40);
            cmbGender.TabIndex = 8;
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNIC.ForeColor = Color.FromArgb(30, 58, 95);
            lblNIC.Location = new Point(16, 408);
            lblNIC.Margin = new Padding(5, 0, 5, 0);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(57, 30);
            lblNIC.TabIndex = 9;
            lblNIC.Text = "NIC:";
            // 
            // txtNIC
            // 
            txtNIC.BorderStyle = BorderStyle.FixedSingle;
            txtNIC.Font = new Font("Segoe UI", 9F);
            txtNIC.Location = new Point(195, 403);
            txtNIC.Margin = new Padding(5, 5, 5, 5);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(242, 39);
            txtNIC.TabIndex = 10;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDOB.ForeColor = Color.FromArgb(30, 58, 95);
            lblDOB.Location = new Point(16, 456);
            lblDOB.Margin = new Padding(5, 0, 5, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(153, 30);
            lblDOB.TabIndex = 11;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(195, 451);
            dtpDOB.Margin = new Padding(5, 5, 5, 5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(192, 39);
            dtpDOB.TabIndex = 12;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblJoinDate.ForeColor = Color.FromArgb(30, 58, 95);
            lblJoinDate.Location = new Point(16, 504);
            lblJoinDate.Margin = new Padding(5, 0, 5, 0);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(116, 30);
            lblJoinDate.TabIndex = 13;
            lblJoinDate.Text = "Join Date:";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Font = new Font("Segoe UI", 9F);
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(195, 499);
            dtpJoinDate.Margin = new Padding(5, 5, 5, 5);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(192, 39);
            dtpJoinDate.TabIndex = 14;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(30, 58, 95);
            lblContact.Location = new Point(16, 552);
            lblContact.Margin = new Padding(5, 0, 5, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 30);
            lblContact.TabIndex = 15;
            lblContact.Text = "Contact:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 9F);
            txtContact.Location = new Point(195, 547);
            txtContact.Margin = new Padding(5, 5, 5, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(242, 39);
            txtContact.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 58, 95);
            lblEmail.Location = new Point(16, 600);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 30);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(195, 595);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 39);
            txtEmail.TabIndex = 18;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(30, 58, 95);
            lblCategory.Location = new Point(16, 648);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 30);
            lblCategory.TabIndex = 19;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9F);
            cmbCategory.Location = new Point(195, 643);
            cmbCategory.Margin = new Padding(5, 5, 5, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(192, 40);
            cmbCategory.TabIndex = 20;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDepartment.ForeColor = Color.FromArgb(30, 58, 95);
            lblDepartment.Location = new Point(16, 696);
            lblDepartment.Margin = new Padding(5, 0, 5, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(146, 30);
            lblDepartment.TabIndex = 21;
            lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Font = new Font("Segoe UI", 9F);
            cmbDepartment.Location = new Point(195, 691);
            cmbDepartment.Margin = new Padding(5, 5, 5, 5);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(241, 40);
            cmbDepartment.TabIndex = 22;
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDesignation.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesignation.Location = new Point(16, 744);
            lblDesignation.Margin = new Padding(5, 0, 5, 0);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(143, 30);
            lblDesignation.TabIndex = 23;
            lblDesignation.Text = "Designation:";
            // 
            // cmbDesignation
            // 
            cmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesignation.Font = new Font("Segoe UI", 9F);
            cmbDesignation.Location = new Point(195, 739);
            cmbDesignation.Margin = new Padding(5, 5, 5, 5);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(241, 40);
            cmbDesignation.TabIndex = 24;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSalary.ForeColor = Color.FromArgb(30, 58, 95);
            lblSalary.Location = new Point(16, 792);
            lblSalary.Margin = new Padding(5, 0, 5, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(83, 30);
            lblSalary.TabIndex = 25;
            lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 9F);
            txtSalary.Location = new Point(195, 787);
            txtSalary.Margin = new Padding(5, 5, 5, 5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(194, 39);
            txtSalary.TabIndex = 26;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(30, 58, 95);
            lblAddress.Location = new Point(16, 840);
            lblAddress.Margin = new Padding(5, 0, 5, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(103, 30);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(195, 835);
            txtAddress.Margin = new Padding(5, 5, 5, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(324, 63);
            txtAddress.TabIndex = 28;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(30, 58, 95);
            lblStatus.Location = new Point(16, 912);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 30);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.Location = new Point(195, 907);
            cmbStatus.Margin = new Padding(5, 5, 5, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(192, 40);
            cmbStatus.TabIndex = 30;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(195, 976);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 48);
            btnSave.TabIndex = 31;
            btnSave.Text = "💾 Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(358, 976);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 48);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(16, 976);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 48);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(30, 58, 95);
            topPanel.Controls.Add(btnAdd);
            topPanel.Controls.Add(btnExport);
            topPanel.Controls.Add(lblPageTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1573, 85);
            topPanel.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(881, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 56);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(52, 152, 219);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1040, 27);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 35);
            btnExport.TabIndex = 2;
            btnExport.Text = "📊 Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(18, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(306, 37);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Employee Managment";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.otherBackground;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelContent);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexusHR - Employee Managment";
            Load += EmployeeForm_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelContent.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            pnlRightPanel.ResumeLayout(false);
            pnlRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panelMainContent;
        private Panel topPanel;
        private SplitContainer splitContainer1;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn colEmployeeCode;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colDesignation;
        private DataGridViewTextBoxColumn colNIC;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colStatus;
        private Panel pnlRightPanel;
        private Label lblPanelTitle;
        private PictureBox picEmployeePhoto;
        private Button btnUploadPhoto;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblNIC;
        private TextBox txtNIC;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Label lblJoinDate;
        private DateTimePicker dtpJoinDate;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblDesignation;
        private ComboBox cmbDesignation;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
        private PictureBox pictureBox2;
        private Panel filterPanel;
        private Button btnExport;
        private Button btnAdd;
        private TextBox txtSearch;
        private ComboBox cmbDeptFilter;
        private ComboBox cmbStatusFilter;
        private Label lblPageTitle;
    }
}