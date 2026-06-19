using System;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_managment_system
{
    partial class EmployeeForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            topPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAdd = new Button();
            btnExport = new Button();
            filterPanel = new Panel();
            txtSearch = new TextBox();
            cmbDeptFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();
            splitContainer1 = new SplitContainer();
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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            attendanceToolStripMenuItem = new ToolStripMenuItem();
            leaveToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            pnlRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(30, 58, 95);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAdd);
            topPanel.Controls.Add(btnExport);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 33);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1477, 63);
            topPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(92, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(458, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Management System";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1146, 6);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Add New";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(52, 152, 219);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1306, 6);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(137, 49);
            btnExport.TabIndex = 2;
            btnExport.Text = "📊 Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(248, 249, 250);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(cmbDeptFilter);
            filterPanel.Controls.Add(cmbStatusFilter);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 96);
            filterPanel.Margin = new Padding(3, 4, 3, 4);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(17, 13, 17, 13);
            filterPanel.Size = new Size(1477, 40);
            filterPanel.TabIndex = 3;
            filterPanel.Paint += filterPanel_Paint;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(20, 4);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by name, ID or email...";
            txtSearch.Size = new Size(285, 30);
            txtSearch.TabIndex = 0;
            // 
            // cmbDeptFilter
            // 
            cmbDeptFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptFilter.FlatStyle = FlatStyle.Flat;
            cmbDeptFilter.Font = new Font("Segoe UI", 10F);
            cmbDeptFilter.Location = new Point(320, 4);
            cmbDeptFilter.Margin = new Padding(3, 4, 3, 4);
            cmbDeptFilter.Name = "cmbDeptFilter";
            cmbDeptFilter.Size = new Size(171, 31);
            cmbDeptFilter.TabIndex = 1;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FlatStyle = FlatStyle.Flat;
            cmbStatusFilter.Font = new Font("Segoe UI", 10F);
            cmbStatusFilter.Location = new Point(508, 4);
            cmbStatusFilter.Margin = new Padding(3, 4, 3, 4);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(137, 31);
            cmbStatusFilter.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 136);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvEmployees);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlRightPanel);
            splitContainer1.Size = new Size(1477, 919);
            splitContainer1.SplitterDistance = 1047;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 2;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeight = 42;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { colEmployeeCode, colFirstName, colLastName, colDepartment, colDesignation, colNIC, colContact, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.Margin = new Padding(3, 4, 3, 4);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 38;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1047, 919);
            dgvEmployees.TabIndex = 0;
            // 
            // colEmployeeCode
            // 
            colEmployeeCode.HeaderText = "EMP ID";
            colEmployeeCode.MinimumWidth = 6;
            colEmployeeCode.Name = "colEmployeeCode";
            colEmployeeCode.ReadOnly = true;
            colEmployeeCode.Width = 125;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 120;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 120;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Width = 130;
            // 
            // colDesignation
            // 
            colDesignation.HeaderText = "Designation";
            colDesignation.MinimumWidth = 6;
            colDesignation.Name = "colDesignation";
            colDesignation.ReadOnly = true;
            colDesignation.Width = 130;
            // 
            // colNIC
            // 
            colNIC.HeaderText = "NIC";
            colNIC.MinimumWidth = 6;
            colNIC.Name = "colNIC";
            colNIC.ReadOnly = true;
            colNIC.Width = 120;
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            colContact.Width = 120;
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
            pnlRightPanel.Dock = DockStyle.Fill;
            pnlRightPanel.Location = new Point(0, 0);
            pnlRightPanel.Margin = new Padding(3, 4, 3, 4);
            pnlRightPanel.Name = "pnlRightPanel";
            pnlRightPanel.Size = new Size(423, 919);
            pnlRightPanel.TabIndex = 0;
            pnlRightPanel.Visible = false;
            // 
            // lblPanelTitle
            // 
            lblPanelTitle.AutoSize = true;
            lblPanelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPanelTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblPanelTitle.Location = new Point(23, 27);
            lblPanelTitle.Name = "lblPanelTitle";
            lblPanelTitle.Size = new Size(239, 37);
            lblPanelTitle.TabIndex = 0;
            lblPanelTitle.Text = "Employee Details";
            // 
            // picEmployeePhoto
            // 
            picEmployeePhoto.BackColor = Color.FromArgb(236, 240, 241);
            picEmployeePhoto.BorderStyle = BorderStyle.FixedSingle;
            picEmployeePhoto.Location = new Point(23, 87);
            picEmployeePhoto.Margin = new Padding(3, 4, 3, 4);
            picEmployeePhoto.Name = "picEmployeePhoto";
            picEmployeePhoto.Size = new Size(114, 133);
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
            btnUploadPhoto.Font = new Font("Segoe UI", 9F);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(149, 133);
            btnUploadPhoto.Margin = new Padding(3, 4, 3, 4);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(114, 47);
            btnUploadPhoto.TabIndex = 2;
            btnUploadPhoto.Text = "📷 Upload";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(30, 58, 95);
            lblFirstName.Location = new Point(23, 247);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(90, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(137, 240);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(251, 30);
            txtFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(30, 58, 95);
            lblLastName.Location = new Point(23, 287);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(137, 280);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(251, 30);
            txtLastName.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(30, 58, 95);
            lblGender.Location = new Point(23, 327);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Segoe UI", 10F);
            cmbGender.Location = new Point(137, 320);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(171, 31);
            cmbGender.TabIndex = 8;
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNIC.ForeColor = Color.FromArgb(30, 58, 95);
            lblNIC.Location = new Point(23, 367);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(39, 20);
            lblNIC.TabIndex = 9;
            lblNIC.Text = "NIC:";
            // 
            // txtNIC
            // 
            txtNIC.BorderStyle = BorderStyle.FixedSingle;
            txtNIC.Font = new Font("Segoe UI", 10F);
            txtNIC.Location = new Point(137, 360);
            txtNIC.Margin = new Padding(3, 4, 3, 4);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(251, 30);
            txtNIC.TabIndex = 10;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDOB.ForeColor = Color.FromArgb(30, 58, 95);
            lblDOB.Location = new Point(23, 407);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(104, 20);
            lblDOB.TabIndex = 11;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 10F);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(137, 400);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(251, 30);
            dtpDOB.TabIndex = 12;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJoinDate.ForeColor = Color.FromArgb(30, 58, 95);
            lblJoinDate.Location = new Point(23, 447);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(79, 20);
            lblJoinDate.TabIndex = 13;
            lblJoinDate.Text = "Join Date:";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Font = new Font("Segoe UI", 10F);
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(137, 440);
            dtpJoinDate.Margin = new Padding(3, 4, 3, 4);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(251, 30);
            dtpJoinDate.TabIndex = 14;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(30, 58, 95);
            lblContact.Location = new Point(23, 487);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 15;
            lblContact.Text = "Contact:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(137, 480);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(251, 30);
            txtContact.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 58, 95);
            lblEmail.Location = new Point(23, 527);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(137, 520);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 30);
            txtEmail.TabIndex = 18;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(30, 58, 95);
            lblCategory.Location = new Point(23, 567);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(77, 20);
            lblCategory.TabIndex = 19;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(137, 560);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(171, 31);
            cmbCategory.TabIndex = 20;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDepartment.ForeColor = Color.FromArgb(30, 58, 95);
            lblDepartment.Location = new Point(23, 607);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(98, 20);
            lblDepartment.TabIndex = 21;
            lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FlatStyle = FlatStyle.Flat;
            cmbDepartment.Font = new Font("Segoe UI", 10F);
            cmbDepartment.Location = new Point(137, 600);
            cmbDepartment.Margin = new Padding(3, 4, 3, 4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(228, 31);
            cmbDepartment.TabIndex = 22;
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesignation.ForeColor = Color.FromArgb(30, 58, 95);
            lblDesignation.Location = new Point(23, 647);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(97, 20);
            lblDesignation.TabIndex = 23;
            lblDesignation.Text = "Designation:";
            // 
            // cmbDesignation
            // 
            cmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesignation.FlatStyle = FlatStyle.Flat;
            cmbDesignation.Font = new Font("Segoe UI", 10F);
            cmbDesignation.Location = new Point(137, 640);
            cmbDesignation.Margin = new Padding(3, 4, 3, 4);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(251, 31);
            cmbDesignation.TabIndex = 24;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalary.ForeColor = Color.FromArgb(30, 58, 95);
            lblSalary.Location = new Point(23, 687);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(56, 20);
            lblSalary.TabIndex = 25;
            lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 10F);
            txtSalary.Location = new Point(137, 680);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(171, 30);
            txtSalary.TabIndex = 26;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(30, 58, 95);
            lblAddress.Location = new Point(23, 727);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 20);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(23, 753);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 59);
            txtAddress.TabIndex = 28;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(30, 58, 95);
            lblStatus.Location = new Point(23, 827);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Location = new Point(91, 820);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(114, 31);
            cmbStatus.TabIndex = 30;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(49, 867);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 46);
            btnSave.TabIndex = 31;
            btnSave.Text = "💾 Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(165, 867);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 46);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(279, 868);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 46);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(25, 48, 78);
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, employeesToolStripMenuItem, departmentToolStripMenuItem, attendanceToolStripMenuItem, leaveToolStripMenuItem, payrollToolStripMenuItem, reportsToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1477, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(135, 27);
            dashboardToolStripMenuItem.Text = "📊 Dashboard";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.ForeColor = Color.White;
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(133, 27);
            employeesToolStripMenuItem.Text = "👥 Employees";
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.ForeColor = Color.White;
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(144, 27);
            departmentToolStripMenuItem.Text = "🏢 Department";
            // 
            // attendanceToolStripMenuItem
            // 
            attendanceToolStripMenuItem.ForeColor = Color.White;
            attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            attendanceToolStripMenuItem.Size = new Size(140, 27);
            attendanceToolStripMenuItem.Text = "📅 Attendance";
            // 
            // leaveToolStripMenuItem
            // 
            leaveToolStripMenuItem.ForeColor = Color.White;
            leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            leaveToolStripMenuItem.Size = new Size(95, 27);
            leaveToolStripMenuItem.Text = "🏖 Leave";
            // 
            // payrollToolStripMenuItem
            // 
            payrollToolStripMenuItem.ForeColor = Color.White;
            payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            payrollToolStripMenuItem.Size = new Size(102, 27);
            payrollToolStripMenuItem.Text = "💰 Payroll";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.ForeColor = Color.White;
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(110, 27);
            reportsToolStripMenuItem.Text = "📈 Reports";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.ForeColor = Color.FromArgb(231, 76, 60);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(106, 27);
            logoutToolStripMenuItem.Text = "🚪 Logout";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 1055);
            Controls.Add(splitContainer1);
            Controls.Add(filterPanel);
            Controls.Add(topPanel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System - Navy Blue Theme";
            Load += EmployeeForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            pnlRightPanel.ResumeLayout(false);
            pnlRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Control declarations
        private Panel topPanel;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnExport;
        private Panel filterPanel;
        private TextBox txtSearch;
        private ComboBox cmbDeptFilter;
        private ComboBox cmbStatusFilter;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem attendanceToolStripMenuItem;
        private ToolStripMenuItem leaveToolStripMenuItem;
        private ToolStripMenuItem payrollToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}