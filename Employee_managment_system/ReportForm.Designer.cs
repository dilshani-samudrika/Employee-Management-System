using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Employee_managment_system
{
    partial class reports
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports));
            filterCardPanel = new Panel();
            reportTypeLabel = new Label();
            reportTypeCombo = new ComboBox();
            formatLabel = new Label();
            formatCombo = new ComboBox();
            fromLabel = new Label();
            fromDatePicker = new DateTimePicker();
            toLabel = new Label();
            toDatePicker = new DateTimePicker();
            deptLabel = new Label();
            deptCombo = new ComboBox();
            generateButton = new Button();
            printButton = new Button();
            exportButton = new Button();
            previewHeaderPanel = new Panel();
            previewHeaderTitle = new Label();
            pageInfoLabel = new Label();
            previewCardPanel = new Panel();
            reportTitleLabel = new Label();
            reportSubtitleLabel = new Label();
            reportMetaLabel = new Label();
            previewGrid = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colDesignation = new DataGridViewTextBoxColumn();
            colJoiningDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            totalRecordsLabel = new Label();
            footerLabel = new Label();
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
            btnLogout = new Button();
            topBar = new Panel();
            lblPageTitle = new Label();
            filterCardPanel.SuspendLayout();
            previewHeaderPanel.SuspendLayout();
            previewCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewGrid).BeginInit();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // filterCardPanel
            // 
            filterCardPanel.BackColor = Color.White;
            filterCardPanel.BackgroundImage = Properties.Resources.background_for_all_without_logo;
            filterCardPanel.BorderStyle = BorderStyle.FixedSingle;
            filterCardPanel.Controls.Add(reportTypeLabel);
            filterCardPanel.Controls.Add(reportTypeCombo);
            filterCardPanel.Controls.Add(formatLabel);
            filterCardPanel.Controls.Add(formatCombo);
            filterCardPanel.Controls.Add(fromLabel);
            filterCardPanel.Controls.Add(fromDatePicker);
            filterCardPanel.Controls.Add(toLabel);
            filterCardPanel.Controls.Add(toDatePicker);
            filterCardPanel.Controls.Add(deptLabel);
            filterCardPanel.Controls.Add(deptCombo);
            filterCardPanel.Controls.Add(generateButton);
            filterCardPanel.Controls.Add(printButton);
            filterCardPanel.Controls.Add(exportButton);
            filterCardPanel.Location = new Point(351, 80);
            filterCardPanel.Name = "filterCardPanel";
            filterCardPanel.Size = new Size(1314, 155);
            filterCardPanel.TabIndex = 1;
            filterCardPanel.Paint += filterCardPanel_Paint;
            // 
            // reportTypeLabel
            // 
            reportTypeLabel.AutoSize = true;
            reportTypeLabel.ForeColor = Color.FromArgb(73, 80, 87);
            reportTypeLabel.Location = new Point(14, 22);
            reportTypeLabel.Name = "reportTypeLabel";
            reportTypeLabel.Size = new Size(92, 20);
            reportTypeLabel.TabIndex = 0;
            reportTypeLabel.Text = "Report Type:";
            // 
            // reportTypeCombo
            // 
            reportTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            reportTypeCombo.FormattingEnabled = true;
            reportTypeCombo.Items.AddRange(new object[] { "Employee List", "Department Summary", "Active/Inactive Status" });
            reportTypeCombo.Location = new Point(120, 18);
            reportTypeCombo.Name = "reportTypeCombo";
            reportTypeCombo.Size = new Size(190, 28);
            reportTypeCombo.TabIndex = 1;
            reportTypeCombo.SelectedIndexChanged += reportTypeCombo_SelectedIndexChanged;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.ForeColor = Color.FromArgb(73, 80, 87);
            formatLabel.Location = new Point(335, 22);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(59, 20);
            formatLabel.TabIndex = 2;
            formatLabel.Text = "Format:";
            // 
            // formatCombo
            // 
            formatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            formatCombo.FormattingEnabled = true;
            formatCombo.Items.AddRange(new object[] { "PDF", "CSV", "Excel" });
            formatCombo.Location = new Point(400, 18);
            formatCombo.Name = "formatCombo";
            formatCombo.Size = new Size(90, 28);
            formatCombo.TabIndex = 3;
            formatCombo.SelectedIndexChanged += formatCombo_SelectedIndexChanged;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.ForeColor = Color.FromArgb(73, 80, 87);
            fromLabel.Location = new Point(510, 22);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(46, 20);
            fromLabel.TabIndex = 4;
            fromLabel.Text = "From:";
            // 
            // fromDatePicker
            // 
            fromDatePicker.CustomFormat = "dd-MMM-yyyy";
            fromDatePicker.Format = DateTimePickerFormat.Custom;
            fromDatePicker.Location = new Point(560, 18);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(140, 27);
            fromDatePicker.TabIndex = 5;
            fromDatePicker.ValueChanged += fromDatePicker_ValueChanged;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(73, 80, 87);
            toLabel.Location = new Point(715, 22);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(28, 20);
            toLabel.TabIndex = 6;
            toLabel.Text = "To:";
            // 
            // toDatePicker
            // 
            toDatePicker.CustomFormat = "dd-MMM-yyyy";
            toDatePicker.Format = DateTimePickerFormat.Custom;
            toDatePicker.Location = new Point(750, 18);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(140, 27);
            toDatePicker.TabIndex = 7;
            toDatePicker.ValueChanged += toDatePicker_ValueChanged;
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.ForeColor = Color.FromArgb(73, 80, 87);
            deptLabel.Location = new Point(905, 22);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new Size(45, 20);
            deptLabel.TabIndex = 8;
            deptLabel.Text = "Dept:";
            // 
            // deptCombo
            // 
            deptCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCombo.FormattingEnabled = true;
            deptCombo.Items.AddRange(new object[] { "All" });
            deptCombo.Location = new Point(955, 18);
            deptCombo.Name = "deptCombo";
            deptCombo.Size = new Size(100, 28);
            deptCombo.TabIndex = 9;
            deptCombo.SelectedIndexChanged += deptCombo_SelectedIndexChanged;
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.FromArgb(30, 58, 95);
            generateButton.FlatAppearance.BorderSize = 0;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.ForeColor = Color.White;
            generateButton.Location = new Point(120, 70);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(160, 42);
            generateButton.TabIndex = 10;
            generateButton.Text = "▶  Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // printButton
            // 
            printButton.BackColor = Color.FromArgb(52, 152, 219);
            printButton.FlatAppearance.BorderSize = 0;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.ForeColor = Color.White;
            printButton.Location = new Point(295, 70);
            printButton.Name = "printButton";
            printButton.Size = new Size(120, 42);
            printButton.TabIndex = 11;
            printButton.Text = "🖶  Print";
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(40, 167, 69);
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(430, 70);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(120, 42);
            exportButton.TabIndex = 12;
            exportButton.Text = "⬇  Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // previewHeaderPanel
            // 
            previewHeaderPanel.BackColor = Color.FromArgb(27, 42, 74);
            previewHeaderPanel.Controls.Add(previewHeaderTitle);
            previewHeaderPanel.Controls.Add(pageInfoLabel);
            previewHeaderPanel.Location = new Point(351, 233);
            previewHeaderPanel.Name = "previewHeaderPanel";
            previewHeaderPanel.Size = new Size(1317, 42);
            previewHeaderPanel.TabIndex = 2;
            // 
            // previewHeaderTitle
            // 
            previewHeaderTitle.AutoSize = true;
            previewHeaderTitle.ForeColor = Color.White;
            previewHeaderTitle.Location = new Point(15, 10);
            previewHeaderTitle.Name = "previewHeaderTitle";
            previewHeaderTitle.Size = new Size(138, 20);
            previewHeaderTitle.TabIndex = 0;
            previewHeaderTitle.Text = "📄  Report Preview";
            // 
            // pageInfoLabel
            // 
            pageInfoLabel.AutoSize = true;
            pageInfoLabel.ForeColor = Color.White;
            pageInfoLabel.Location = new Point(970, 10);
            pageInfoLabel.Name = "pageInfoLabel";
            pageInfoLabel.Size = new Size(178, 20);
            pageInfoLabel.TabIndex = 1;
            pageInfoLabel.Text = "Page 1 of 1 | Zoom: 100%";
            // 
            // previewCardPanel
            // 
            previewCardPanel.BackColor = Color.White;
            previewCardPanel.BorderStyle = BorderStyle.FixedSingle;
            previewCardPanel.Controls.Add(reportTitleLabel);
            previewCardPanel.Controls.Add(reportSubtitleLabel);
            previewCardPanel.Controls.Add(reportMetaLabel);
            previewCardPanel.Controls.Add(previewGrid);
            previewCardPanel.Controls.Add(totalRecordsLabel);
            previewCardPanel.Controls.Add(footerLabel);
            previewCardPanel.Location = new Point(400, 290);
            previewCardPanel.Name = "previewCardPanel";
            previewCardPanel.Size = new Size(1099, 430);
            previewCardPanel.TabIndex = 3;
            // 
            // reportTitleLabel
            // 
            reportTitleLabel.Anchor = AnchorStyles.Top;
            reportTitleLabel.AutoSize = true;
            reportTitleLabel.ForeColor = Color.FromArgb(27, 42, 74);
            reportTitleLabel.Location = new Point(444, 35);
            reportTitleLabel.Name = "reportTitleLabel";
            reportTitleLabel.Size = new Size(218, 20);
            reportTitleLabel.TabIndex = 0;
            reportTitleLabel.Text = "Employee Management System";
            reportTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reportSubtitleLabel
            // 
            reportSubtitleLabel.ForeColor = Color.FromArgb(27, 42, 74);
            reportSubtitleLabel.Location = new Point(0, 60);
            reportSubtitleLabel.Name = "reportSubtitleLabel";
            reportSubtitleLabel.Size = new Size(1148, 26);
            reportSubtitleLabel.TabIndex = 1;
            reportSubtitleLabel.Text = "Employee List Report";
            reportSubtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reportMetaLabel
            // 
            reportMetaLabel.ForeColor = Color.Gray;
            reportMetaLabel.Location = new Point(-3, 84);
            reportMetaLabel.Name = "reportMetaLabel";
            reportMetaLabel.Size = new Size(1148, 23);
            reportMetaLabel.TabIndex = 2;
            reportMetaLabel.Text = "Period: — | Generated: — | By: Admin";
            reportMetaLabel.TextAlign = ContentAlignment.MiddleCenter;
            reportMetaLabel.Click += reportMetaLabel_Click;
            // 
            // previewGrid
            // 
            previewGrid.AllowUserToAddRows = false;
            previewGrid.AllowUserToDeleteRows = false;
            previewGrid.BackgroundColor = Color.White;
            previewGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 42, 74);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            previewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            previewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previewGrid.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colDepartment, colDesignation, colJoiningDate, colStatus });
            previewGrid.Location = new Point(25, 130);
            previewGrid.Name = "previewGrid";
            previewGrid.ReadOnly = true;
            previewGrid.RightToLeft = RightToLeft.No;
            previewGrid.RowHeadersVisible = false;
            previewGrid.RowHeadersWidth = 82;
            previewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            previewGrid.Size = new Size(1100, 240);
            previewGrid.TabIndex = 3;
            previewGrid.CellContentClick += previewGrid_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 10;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 60;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 220;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 10;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Width = 180;
            // 
            // colDesignation
            // 
            colDesignation.HeaderText = "Designation";
            colDesignation.MinimumWidth = 10;
            colDesignation.Name = "colDesignation";
            colDesignation.ReadOnly = true;
            colDesignation.Width = 180;
            // 
            // colJoiningDate
            // 
            colJoiningDate.HeaderText = "Joining Date";
            colJoiningDate.MinimumWidth = 10;
            colJoiningDate.Name = "colJoiningDate";
            colJoiningDate.ReadOnly = true;
            colJoiningDate.Width = 180;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 10;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 140;
            // 
            // totalRecordsLabel
            // 
            totalRecordsLabel.AutoSize = true;
            totalRecordsLabel.ForeColor = Color.Gray;
            totalRecordsLabel.Location = new Point(25, 388);
            totalRecordsLabel.Name = "totalRecordsLabel";
            totalRecordsLabel.Size = new Size(114, 20);
            totalRecordsLabel.TabIndex = 4;
            totalRecordsLabel.Text = "Total Records: 0";
            // 
            // footerLabel
            // 
            footerLabel.ForeColor = Color.Gray;
            footerLabel.Location = new Point(700, 388);
            footerLabel.Name = "footerLabel";
            footerLabel.Size = new Size(425, 23);
            footerLabel.TabIndex = 5;
            footerLabel.Text = "Employee Management System © 2026     Page 1 of 1";
            footerLabel.TextAlign = ContentAlignment.MiddleRight;
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
            panelSideMenu.Margin = new Padding(2);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(351, 856);
            panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(351, 75);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo_and_name_for_header;
            pictureBoxLogo.Location = new Point(-1, -3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(353, 83);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 90);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(328, 45);
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
            btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnEmployees.ForeColor = SystemColors.ScrollBar;
            btnEmployees.Location = new Point(0, 140);
            btnEmployees.Margin = new Padding(2);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(328, 45);
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
            btnDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 190);
            btnDepartment.Margin = new Padding(2);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(328, 45);
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
            btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 240);
            btnAttendance.Margin = new Padding(2);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(328, 45);
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
            btnLeave.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 290);
            btnLeave.Margin = new Padding(2);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(328, 45);
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
            btnPayroll.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 340);
            btnPayroll.Margin = new Padding(2);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(328, 45);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(52, 152, 219);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 390);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(328, 45);
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
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 811);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(351, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(25, 48, 78);
            topBar.Controls.Add(lblPageTitle);
            topBar.Dock = DockStyle.Top;
            topBar.ForeColor = SystemColors.ControlLightLight;
            topBar.Location = new Point(351, 0);
            topBar.Margin = new Padding(5);
            topBar.Name = "topBar";
            topBar.Size = new Size(1317, 80);
            topBar.TabIndex = 4;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(20, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(269, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Report Managment";
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            BackgroundImage = Properties.Resources.background_for_all_without_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1668, 856);
            Controls.Add(topBar);
            Controls.Add(filterCardPanel);
            Controls.Add(previewHeaderPanel);
            Controls.Add(previewCardPanel);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "reports";
            Text = "NexusHR - Reports";
            filterCardPanel.ResumeLayout(false);
            filterCardPanel.PerformLayout();
            previewHeaderPanel.ResumeLayout(false);
            previewHeaderPanel.PerformLayout();
            previewCardPanel.ResumeLayout(false);
            previewCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewGrid).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel filterCardPanel;
        private System.Windows.Forms.Label reportTypeLabel;
        private System.Windows.Forms.ComboBox reportTypeCombo;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel previewHeaderPanel;
        private System.Windows.Forms.Label previewHeaderTitle;
        private System.Windows.Forms.Label pageInfoLabel;
        private System.Windows.Forms.Panel previewCardPanel;
        private System.Windows.Forms.Label reportTitleLabel;
        private System.Windows.Forms.Label reportSubtitleLabel;
        private System.Windows.Forms.Label reportMetaLabel;
        private System.Windows.Forms.DataGridView previewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label totalRecordsLabel;
        private System.Windows.Forms.Label footerLabel;
        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnLogout;
        private PictureBox pictureBoxLogo;
        private Panel topBar;
        private Label lblPageTitle;
        private Button button1;
    }
}