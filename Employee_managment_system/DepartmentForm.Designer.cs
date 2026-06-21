namespace Employee_managment_system
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            panelContent = new Panel();
            topBar = new Panel();
            lblPageTitle = new Label();
            panelMainContent = new Panel();
            panelLeft = new Panel();
            panelDeptHeader = new Panel();
            lblDeptHeader = new Label();
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
            panelDeptButtons = new Panel();
            btnAddDept = new Button();
            btnDeleteDept = new Button();
            dgvDepartments = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            colDepartmentName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colEmployeeCount = new DataGridViewTextBoxColumn();
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
            btnLogout = new Button();
            btnReports = new Button();
            btnPayroll = new Button();
            btnLeave = new Button();
            btnAttendance = new Button();
            btnDepartment = new Button();
            btnEmployees = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            panelSideMenu = new Panel();
            panelContent.SuspendLayout();
            topBar.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelLeft.SuspendLayout();
            panelDeptHeader.SuspendLayout();
            pnlDeptDetails.SuspendLayout();
            panelDeptButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            panelRight.SuspendLayout();
            panelDesigHeader.SuspendLayout();
            panelDesigButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).BeginInit();
            pnlDesigDetails.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(topBar);
            panelContent.Controls.Add(panelMainContent);
            panelContent.Location = new Point(351, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1576, 1055);
            panelContent.TabIndex = 1;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(25, 48, 78);
            topBar.Controls.Add(lblPageTitle);
            topBar.Dock = DockStyle.Top;
            topBar.ForeColor = SystemColors.ControlLightLight;
            topBar.Location = new Point(0, 0);
            topBar.Margin = new Padding(5);
            topBar.Name = "topBar";
            topBar.Size = new Size(1576, 80);
            topBar.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(20, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(506, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Department & Designation Managment";
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(248, 249, 250);
            panelMainContent.BackgroundImage = Properties.Resources.otherBackground;
            panelMainContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelMainContent.Controls.Add(panelLeft);
            panelMainContent.Controls.Add(panelRight);
            panelMainContent.Location = new Point(0, 80);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1573, 975);
            panelMainContent.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(panelDeptHeader);
            panelLeft.Controls.Add(pnlDeptDetails);
            panelLeft.Controls.Add(panelDeptButtons);
            panelLeft.Controls.Add(dgvDepartments);
            panelLeft.Controls.Add(lblDeptInfo);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(707, 975);
            panelLeft.TabIndex = 0;
            // 
            // panelDeptHeader
            // 
            panelDeptHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDeptHeader.Controls.Add(lblDeptHeader);
            panelDeptHeader.Location = new Point(0, 977);
            panelDeptHeader.Name = "panelDeptHeader";
            panelDeptHeader.Size = new Size(800, 30);
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
            lblDeptHeader.Size = new Size(115, 23);
            lblDeptHeader.TabIndex = 0;
            lblDeptHeader.Text = "Departments";
            // 
            // pnlDeptDetails
            // 
            pnlDeptDetails.BackColor = Color.FromArgb(248, 249, 250);
            pnlDeptDetails.BackgroundImage = Properties.Resources.background_for_all_without_logo;
            pnlDeptDetails.BackgroundImageLayout = ImageLayout.Stretch;
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
            pnlDeptDetails.Location = new Point(0, -1);
            pnlDeptDetails.Name = "pnlDeptDetails";
            pnlDeptDetails.Size = new Size(706, 247);
            pnlDeptDetails.TabIndex = 3;
            pnlDeptDetails.Visible = false;
            pnlDeptDetails.Paint += pnlDeptDetails_Paint;
            // 
            // lblDeptDetailsTitle
            // 
            lblDeptDetailsTitle.AutoSize = true;
            lblDeptDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDeptDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDetailsTitle.Location = new Point(16, 13);
            lblDeptDetailsTitle.Margin = new Padding(5, 0, 5, 0);
            lblDeptDetailsTitle.Name = "lblDeptDetailsTitle";
            lblDeptDetailsTitle.Size = new Size(199, 28);
            lblDeptDetailsTitle.TabIndex = 0;
            lblDeptDetailsTitle.Text = "Department Details";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptName.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptName.Location = new Point(9, 55);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(144, 20);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Department Name:";
            // 
            // txtDeptName
            // 
            txtDeptName.BorderStyle = BorderStyle.FixedSingle;
            txtDeptName.Font = new Font("Segoe UI", 10F);
            txtDeptName.Location = new Point(201, 55);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(311, 30);
            txtDeptName.TabIndex = 2;
            // 
            // lblDeptDescription
            // 
            lblDeptDescription.AutoSize = true;
            lblDeptDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptDescription.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptDescription.Location = new Point(10, 111);
            lblDeptDescription.Name = "lblDeptDescription";
            lblDeptDescription.Size = new Size(93, 20);
            lblDeptDescription.TabIndex = 3;
            lblDeptDescription.Text = "Description:";
            // 
            // txtDeptDescription
            // 
            txtDeptDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDeptDescription.Font = new Font("Segoe UI", 10F);
            txtDeptDescription.Location = new Point(201, 111);
            txtDeptDescription.Name = "txtDeptDescription";
            txtDeptDescription.Size = new Size(311, 30);
            txtDeptDescription.TabIndex = 4;
            // 
            // lblDeptEmployeeCount
            // 
            lblDeptEmployeeCount.AutoSize = true;
            lblDeptEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeptEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDeptEmployeeCount.Location = new Point(10, 165);
            lblDeptEmployeeCount.Name = "lblDeptEmployeeCount";
            lblDeptEmployeeCount.Size = new Size(127, 20);
            lblDeptEmployeeCount.TabIndex = 5;
            lblDeptEmployeeCount.Text = "Employee Count:";
            // 
            // txtDeptEmployeeCount
            // 
            txtDeptEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);
            txtDeptEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDeptEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDeptEmployeeCount.Location = new Point(201, 165);
            txtDeptEmployeeCount.Name = "txtDeptEmployeeCount";
            txtDeptEmployeeCount.ReadOnly = true;
            txtDeptEmployeeCount.Size = new Size(161, 30);
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
            btnSaveDept.Location = new Point(518, 55);
            btnSaveDept.Name = "btnSaveDept";
            btnSaveDept.Size = new Size(162, 48);
            btnSaveDept.TabIndex = 7;
            btnSaveDept.Text = "💾 Save";
            btnSaveDept.UseVisualStyleBackColor = false;
            btnSaveDept.Click += btnSaveDept_Click;
            // 
            // btnCancelDept
            // 
            btnCancelDept.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDept.Cursor = Cursors.Hand;
            btnCancelDept.FlatAppearance.BorderSize = 0;
            btnCancelDept.FlatStyle = FlatStyle.Flat;
            btnCancelDept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDept.ForeColor = Color.White;
            btnCancelDept.Location = new Point(518, 111);
            btnCancelDept.Name = "btnCancelDept";
            btnCancelDept.Size = new Size(162, 48);
            btnCancelDept.TabIndex = 8;
            btnCancelDept.Text = "❌ Cancel";
            btnCancelDept.UseVisualStyleBackColor = false;
            btnCancelDept.Click += btnCancelDept_Click;
            // 
            // panelDeptButtons
            // 
            panelDeptButtons.Controls.Add(btnAddDept);
            panelDeptButtons.Controls.Add(btnDeleteDept);
            panelDeptButtons.Location = new Point(0, 892);
            panelDeptButtons.Name = "panelDeptButtons";
            panelDeptButtons.Size = new Size(800, 49);
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
            btnAddDept.Margin = new Padding(5);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(162, 48);
            btnAddDept.TabIndex = 0;
            btnAddDept.Text = "➕ Add";
            btnAddDept.UseVisualStyleBackColor = false;
            btnAddDept.Click += btnAddDept_Click;
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
            btnDeleteDept.Margin = new Padding(5);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(162, 48);
            btnDeleteDept.TabIndex = 1;
            btnDeleteDept.Text = "🗑️ Delete";
            btnDeleteDept.UseVisualStyleBackColor = false;
            btnDeleteDept.Click += btnDeleteDept_Click;
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
            dgvDepartments.EnableHeadersVisualStyles = false;
            dgvDepartments.Location = new Point(0, 252);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersVisible = false;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.RowTemplate.Height = 28;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(712, 639);
            dgvDepartments.TabIndex = 2;
            dgvDepartments.DataError += dgvDepartments_DataError;
            dgvDepartments.SelectionChanged += dgvDepartments_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 50;
            // 
            // colDepartmentName
            // 
            colDepartmentName.HeaderText = "Department";
            colDepartmentName.MinimumWidth = 6;
            colDepartmentName.Name = "colDepartmentName";
            colDepartmentName.ReadOnly = true;
            colDepartmentName.Resizable = DataGridViewTriState.False;
            colDepartmentName.Width = 200;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Resizable = DataGridViewTriState.False;
            colDescription.Width = 250;
            // 
            // colEmployeeCount
            // 
            colEmployeeCount.HeaderText = "Employee Count";
            colEmployeeCount.MinimumWidth = 20;
            colEmployeeCount.Name = "colEmployeeCount";
            colEmployeeCount.ReadOnly = true;
            colEmployeeCount.Resizable = DataGridViewTriState.False;
            colEmployeeCount.Width = 120;
            // 
            // lblDeptInfo
            // 
            lblDeptInfo.AutoSize = true;
            lblDeptInfo.Font = new Font("Segoe UI", 8F);
            lblDeptInfo.ForeColor = Color.Gray;
            lblDeptInfo.Location = new Point(16, 696);
            lblDeptInfo.Margin = new Padding(5, 0, 5, 0);
            lblDeptInfo.Name = "lblDeptInfo";
            lblDeptInfo.Size = new Size(292, 19);
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
            panelRight.Location = new Point(708, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(806, 975);
            panelRight.TabIndex = 1;
            // 
            // panelDesigHeader
            // 
            panelDesigHeader.BackColor = Color.FromArgb(30, 58, 95);
            panelDesigHeader.Controls.Add(lblDesigHeader);
            panelDesigHeader.Location = new Point(0, 974);
            panelDesigHeader.Name = "panelDesigHeader";
            panelDesigHeader.Size = new Size(706, 33);
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
            lblDesigHeader.Size = new Size(113, 23);
            lblDesigHeader.TabIndex = 0;
            lblDesigHeader.Text = "Designations";
            // 
            // panelDesigButtons
            // 
            panelDesigButtons.Controls.Add(btnAddDesig);
            panelDesigButtons.Controls.Add(btnDeleteDesig);
            panelDesigButtons.Location = new Point(0, 887);
            panelDesigButtons.Name = "panelDesigButtons";
            panelDesigButtons.Size = new Size(606, 54);
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
            btnAddDesig.Margin = new Padding(5);
            btnAddDesig.Name = "btnAddDesig";
            btnAddDesig.Size = new Size(162, 48);
            btnAddDesig.TabIndex = 0;
            btnAddDesig.Text = "➕ Add";
            btnAddDesig.UseVisualStyleBackColor = false;
            btnAddDesig.Click += btnAddDesig_Click;
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
            btnDeleteDesig.Margin = new Padding(5);
            btnDeleteDesig.Name = "btnDeleteDesig";
            btnDeleteDesig.Size = new Size(162, 48);
            btnDeleteDesig.TabIndex = 1;
            btnDeleteDesig.Text = "🗑️ Delete";
            btnDeleteDesig.UseVisualStyleBackColor = false;
            btnDeleteDesig.Click += btnDeleteDesig_Click;
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
            dgvDesignations.EnableHeadersVisualStyles = false;
            dgvDesignations.Location = new Point(10, 252);
            dgvDesignations.MultiSelect = false;
            dgvDesignations.Name = "dgvDesignations";
            dgvDesignations.ReadOnly = true;
            dgvDesignations.RowHeadersVisible = false;
            dgvDesignations.RowHeadersWidth = 51;
            dgvDesignations.RowTemplate.Height = 28;
            dgvDesignations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesignations.Size = new Size(647, 587);
            dgvDesignations.TabIndex = 2;
            dgvDesignations.DataError += dgvDesignations_DataError;
            dgvDesignations.SelectionChanged += dgvDesignations_SelectionChanged;
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
            Title.Width = 200;
            // 
            // DeptName
            // 
            DeptName.HeaderText = "Department";
            DeptName.MinimumWidth = 6;
            DeptName.Name = "DeptName";
            DeptName.ReadOnly = true;
            DeptName.Resizable = DataGridViewTriState.False;
            DeptName.Width = 200;
            // 
            // DesigEmployeeCount
            // 
            DesigEmployeeCount.HeaderText = "Employee Count";
            DesigEmployeeCount.MinimumWidth = 6;
            DesigEmployeeCount.Name = "DesigEmployeeCount";
            DesigEmployeeCount.ReadOnly = true;
            DesigEmployeeCount.Resizable = DataGridViewTriState.False;
            DesigEmployeeCount.Width = 120;
            // 
            // pnlDesigDetails
            // 
            pnlDesigDetails.BackColor = Color.FromArgb(248, 249, 250);
            pnlDesigDetails.BackgroundImage = Properties.Resources.background_for_all_without_logo;
            pnlDesigDetails.BackgroundImageLayout = ImageLayout.Stretch;
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
            pnlDesigDetails.Location = new Point(-1, -1);
            pnlDesigDetails.Name = "pnlDesigDetails";
            pnlDesigDetails.Size = new Size(652, 247);
            pnlDesigDetails.TabIndex = 3;
            pnlDesigDetails.Visible = false;
            pnlDesigDetails.Paint += pnlDesigDetails_Paint;
            // 
            // lblDesigDetailsTitle
            // 
            lblDesigDetailsTitle.AutoSize = true;
            lblDesigDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesigDetailsTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDetailsTitle.Location = new Point(16, 13);
            lblDesigDetailsTitle.Margin = new Padding(5, 0, 5, 0);
            lblDesigDetailsTitle.Name = "lblDesigDetailsTitle";
            lblDesigDetailsTitle.Size = new Size(198, 28);
            lblDesigDetailsTitle.TabIndex = 0;
            lblDesigDetailsTitle.Text = "Designation Details";
            // 
            // lblDesigTitle
            // 
            lblDesigTitle.AutoSize = true;
            lblDesigTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigTitle.Location = new Point(9, 55);
            lblDesigTitle.Name = "lblDesigTitle";
            lblDesigTitle.Size = new Size(90, 20);
            lblDesigTitle.TabIndex = 1;
            lblDesigTitle.Text = "Title Name:";
            // 
            // txtDesigTitle
            // 
            txtDesigTitle.BorderStyle = BorderStyle.FixedSingle;
            txtDesigTitle.Font = new Font("Segoe UI", 10F);
            txtDesigTitle.Location = new Point(134, 51);
            txtDesigTitle.Name = "txtDesigTitle";
            txtDesigTitle.Size = new Size(300, 30);
            txtDesigTitle.TabIndex = 2;
            // 
            // lblDesigDepartment
            // 
            lblDesigDepartment.AutoSize = true;
            lblDesigDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigDepartment.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigDepartment.Location = new Point(9, 111);
            lblDesigDepartment.Name = "lblDesigDepartment";
            lblDesigDepartment.Size = new Size(98, 20);
            lblDesigDepartment.TabIndex = 3;
            lblDesigDepartment.Text = "Department:";
            // 
            // cmbDesigDepartment
            // 
            cmbDesigDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesigDepartment.Font = new Font("Segoe UI", 10F);
            cmbDesigDepartment.Location = new Point(134, 106);
            cmbDesigDepartment.Name = "cmbDesigDepartment";
            cmbDesigDepartment.Size = new Size(300, 31);
            cmbDesigDepartment.TabIndex = 4;
            cmbDesigDepartment.SelectedIndexChanged += cmbDesigDepartment_SelectedIndexChanged_1;
            // 
            // lblDesigEmployeeCount
            // 
            lblDesigEmployeeCount.AutoSize = true;
            lblDesigEmployeeCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesigEmployeeCount.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesigEmployeeCount.Location = new Point(3, 161);
            lblDesigEmployeeCount.Name = "lblDesigEmployeeCount";
            lblDesigEmployeeCount.Size = new Size(127, 20);
            lblDesigEmployeeCount.TabIndex = 5;
            lblDesigEmployeeCount.Text = "Employee Count:";
            lblDesigEmployeeCount.Click += lblDesigEmployeeCount_Click;
            // 
            // txtDesigEmployeeCount
            // 
            txtDesigEmployeeCount.BackColor = Color.FromArgb(240, 240, 240);
            txtDesigEmployeeCount.BorderStyle = BorderStyle.FixedSingle;
            txtDesigEmployeeCount.Font = new Font("Segoe UI", 10F);
            txtDesigEmployeeCount.Location = new Point(136, 161);
            txtDesigEmployeeCount.Name = "txtDesigEmployeeCount";
            txtDesigEmployeeCount.ReadOnly = true;
            txtDesigEmployeeCount.Size = new Size(161, 30);
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
            btnSaveDesig.Location = new Point(440, 50);
            btnSaveDesig.Name = "btnSaveDesig";
            btnSaveDesig.Size = new Size(162, 48);
            btnSaveDesig.TabIndex = 7;
            btnSaveDesig.Text = "💾 Save";
            btnSaveDesig.UseVisualStyleBackColor = false;
            btnSaveDesig.Click += btnSaveDesig_Click;
            // 
            // btnCancelDesig
            // 
            btnCancelDesig.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelDesig.Cursor = Cursors.Hand;
            btnCancelDesig.FlatAppearance.BorderSize = 0;
            btnCancelDesig.FlatStyle = FlatStyle.Flat;
            btnCancelDesig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelDesig.ForeColor = Color.White;
            btnCancelDesig.Location = new Point(440, 106);
            btnCancelDesig.Name = "btnCancelDesig";
            btnCancelDesig.Size = new Size(162, 48);
            btnCancelDesig.TabIndex = 8;
            btnCancelDesig.Text = "❌ Cancel";
            btnCancelDesig.UseVisualStyleBackColor = false;
            btnCancelDesig.Click += btnCancelDesig_Click;
            // 
            // lblDesigInfo
            // 
            lblDesigInfo.AutoSize = true;
            lblDesigInfo.Font = new Font("Segoe UI", 8F);
            lblDesigInfo.ForeColor = Color.Gray;
            lblDesigInfo.Location = new Point(16, 696);
            lblDesigInfo.Margin = new Padding(5, 0, 5, 0);
            lblDesigInfo.Name = "lblDesigInfo";
            lblDesigInfo.Size = new Size(291, 19);
            lblDesigInfo.TabIndex = 4;
            lblDesigInfo.Text = "💡 Click a designation to view and edit details";
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
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
            btnReports.Location = new Point(0, 432);
            btnReports.Margin = new Padding(5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(332, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(25, 48, 78);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 377);
            btnPayroll.Margin = new Padding(5);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(332, 45);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(25, 48, 78);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 10F);
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 322);
            btnLeave.Margin = new Padding(5);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(332, 45);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(25, 48, 78);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 267);
            btnAttendance.Margin = new Padding(5);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(328, 45);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(52, 152, 219);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDepartment.ForeColor = Color.White;
            btnDepartment.Location = new Point(0, 221);
            btnDepartment.Margin = new Padding(5);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(328, 45);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(25, 48, 78);
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10F);
            btnEmployees.ForeColor = Color.FromArgb(200, 200, 200);
            btnEmployees.Location = new Point(0, 166);
            btnEmployees.Margin = new Padding(5);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(332, 45);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 111);
            btnDashboard.Margin = new Padding(5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(328, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "📊Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(351, 80);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo_and_name_for_header;
            pictureBoxLogo.Location = new Point(-5, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(353, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
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
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(351, 1055);
            panelSideMenu.TabIndex = 0;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1719, 1055);
            Controls.Add(panelContent);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexusHR - Department & Designation ";
            Load += DepartmentForm_Load_1;
            panelContent.ResumeLayout(false);
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            panelMainContent.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelDeptHeader.ResumeLayout(false);
            panelDeptHeader.PerformLayout();
            pnlDeptDetails.ResumeLayout(false);
            pnlDeptDetails.PerformLayout();
            panelDeptButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelDesigHeader.ResumeLayout(false);
            panelDesigHeader.PerformLayout();
            panelDesigButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).EndInit();
            pnlDesigDetails.ResumeLayout(false);
            pnlDesigDetails.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContent;
        private Panel panelMainContent;
        private Panel panelLeft;
        private Panel panelDeptHeader;
        private Label lblDeptHeader;
        private Panel panelDeptButtons;
        private Button btnAddDept;
        private Button btnDeleteDept;
        private DataGridView dgvDepartments;
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
        private Panel panelRight;
        private Panel panelDesigHeader;
        private Label lblDesigHeader;
        private Panel panelDesigButtons;
        private Button btnAddDesig;
        private Button btnDeleteDesig;
        private DataGridView dgvDesignations;
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
        private DataGridViewTextBoxColumn DesignationId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn DeptName;
        private DataGridViewTextBoxColumn DesigEmployeeCount;
        private Panel topBar;
        private Label lblPageTitle;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colDepartmentName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colEmployeeCount;
        private Button btnLogout;
        private Button btnReports;
        private Button btnPayroll;
        private Button btnLeave;
        private Button btnAttendance;
        private Button btnDepartment;
        private Button btnEmployees;
        private Button btnDashboard;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Panel panelSideMenu;
    }
}
