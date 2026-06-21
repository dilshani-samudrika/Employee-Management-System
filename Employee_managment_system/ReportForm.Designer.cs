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
            headerPanel = new Panel();
            headerTitle = new Label();
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
            headerPanel.SuspendLayout();
            filterCardPanel.SuspendLayout();
            previewHeaderPanel.SuspendLayout();
            previewCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewGrid).BeginInit();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(27, 42, 74);
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(351, 0);
            headerPanel.Margin = new Padding(5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1950, 96);
            headerPanel.TabIndex = 0;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.ForeColor = Color.White;
            headerTitle.Location = new Point(41, 26);
            headerTitle.Margin = new Padding(5, 0, 5, 0);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(139, 32);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "📊  Reports";
            // 
            // filterCardPanel
            // 
            filterCardPanel.BackColor = Color.White;
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
            filterCardPanel.Location = new Point(392, 128);
            filterCardPanel.Margin = new Padding(5);
            filterCardPanel.Name = "filterCardPanel";
            filterCardPanel.Size = new Size(1869, 234);
            filterCardPanel.TabIndex = 1;
            filterCardPanel.Paint += filterCardPanel_Paint;
            // 
            // reportTypeLabel
            // 
            reportTypeLabel.AutoSize = true;
            reportTypeLabel.ForeColor = Color.FromArgb(73, 80, 87);
            reportTypeLabel.Location = new Point(5, 55);
            reportTypeLabel.Margin = new Padding(5, 0, 5, 0);
            reportTypeLabel.Name = "reportTypeLabel";
            reportTypeLabel.Size = new Size(147, 32);
            reportTypeLabel.TabIndex = 0;
            reportTypeLabel.Text = "Report Type:";
            // 
            // reportTypeCombo
            // 
            reportTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            reportTypeCombo.FormattingEnabled = true;
            reportTypeCombo.Items.AddRange(new object[] { "Employee List", "Department Summary", "Active/Inactive Status" });
            reportTypeCombo.Location = new Point(195, 29);
            reportTypeCombo.Margin = new Padding(5);
            reportTypeCombo.Name = "reportTypeCombo";
            reportTypeCombo.Size = new Size(306, 40);
            reportTypeCombo.TabIndex = 1;
            reportTypeCombo.SelectedIndexChanged += reportTypeCombo_SelectedIndexChanged;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.ForeColor = Color.FromArgb(73, 80, 87);
            formatLabel.Location = new Point(544, 35);
            formatLabel.Margin = new Padding(5, 0, 5, 0);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(94, 32);
            formatLabel.TabIndex = 2;
            formatLabel.Text = "Format:";
            // 
            // formatCombo
            // 
            formatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            formatCombo.FormattingEnabled = true;
            formatCombo.Items.AddRange(new object[] { "PDF", "CSV", "Excel" });
            formatCombo.Location = new Point(650, 29);
            formatCombo.Margin = new Padding(5);
            formatCombo.Name = "formatCombo";
            formatCombo.Size = new Size(144, 40);
            formatCombo.TabIndex = 3;
            formatCombo.SelectedIndexChanged += formatCombo_SelectedIndexChanged;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.ForeColor = Color.FromArgb(73, 80, 87);
            fromLabel.Location = new Point(829, 35);
            fromLabel.Margin = new Padding(5, 0, 5, 0);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(74, 32);
            fromLabel.TabIndex = 4;
            fromLabel.Text = "From:";
            // 
            // fromDatePicker
            // 
            fromDatePicker.CustomFormat = "dd-MMM-yyyy";
            fromDatePicker.Format = DateTimePickerFormat.Custom;
            fromDatePicker.Location = new Point(910, 29);
            fromDatePicker.Margin = new Padding(5);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(225, 39);
            fromDatePicker.TabIndex = 5;
            fromDatePicker.ValueChanged += fromDatePicker_ValueChanged;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(73, 80, 87);
            toLabel.Location = new Point(1162, 35);
            toLabel.Margin = new Padding(5, 0, 5, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(44, 32);
            toLabel.TabIndex = 6;
            toLabel.Text = "To:";
            // 
            // toDatePicker
            // 
            toDatePicker.CustomFormat = "dd-MMM-yyyy";
            toDatePicker.Format = DateTimePickerFormat.Custom;
            toDatePicker.Location = new Point(1219, 29);
            toDatePicker.Margin = new Padding(5);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(225, 39);
            toDatePicker.TabIndex = 7;
            toDatePicker.ValueChanged += toDatePicker_ValueChanged;
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.ForeColor = Color.FromArgb(73, 80, 87);
            deptLabel.Location = new Point(1471, 35);
            deptLabel.Margin = new Padding(5, 0, 5, 0);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new Size(71, 32);
            deptLabel.TabIndex = 8;
            deptLabel.Text = "Dept:";
            // 
            // deptCombo
            // 
            deptCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCombo.FormattingEnabled = true;
            deptCombo.Items.AddRange(new object[] { "All" });
            deptCombo.Location = new Point(1552, 29);
            deptCombo.Margin = new Padding(5);
            deptCombo.Name = "deptCombo";
            deptCombo.Size = new Size(160, 40);
            deptCombo.TabIndex = 9;
            deptCombo.SelectedIndexChanged += deptCombo_SelectedIndexChanged;
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.FromArgb(30, 58, 95);
            generateButton.FlatAppearance.BorderSize = 0;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.ForeColor = Color.White;
            generateButton.Location = new Point(195, 112);
            generateButton.Margin = new Padding(5);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(260, 67);
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
            printButton.Location = new Point(479, 112);
            printButton.Margin = new Padding(5);
            printButton.Name = "printButton";
            printButton.Size = new Size(195, 67);
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
            exportButton.Location = new Point(699, 112);
            exportButton.Margin = new Padding(5);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(195, 67);
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
            previewHeaderPanel.Location = new Point(392, 360);
            previewHeaderPanel.Margin = new Padding(5);
            previewHeaderPanel.Name = "previewHeaderPanel";
            previewHeaderPanel.Size = new Size(1869, 67);
            previewHeaderPanel.TabIndex = 2;
            // 
            // previewHeaderTitle
            // 
            previewHeaderTitle.AutoSize = true;
            previewHeaderTitle.ForeColor = Color.White;
            previewHeaderTitle.Location = new Point(24, 16);
            previewHeaderTitle.Margin = new Padding(5, 0, 5, 0);
            previewHeaderTitle.Name = "previewHeaderTitle";
            previewHeaderTitle.Size = new Size(215, 32);
            previewHeaderTitle.TabIndex = 0;
            previewHeaderTitle.Text = "📄  Report Preview";
            // 
            // pageInfoLabel
            // 
            pageInfoLabel.AutoSize = true;
            pageInfoLabel.ForeColor = Color.White;
            pageInfoLabel.Location = new Point(1576, 16);
            pageInfoLabel.Margin = new Padding(5, 0, 5, 0);
            pageInfoLabel.Name = "pageInfoLabel";
            pageInfoLabel.Size = new Size(288, 32);
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
            previewCardPanel.Location = new Point(392, 427);
            previewCardPanel.Margin = new Padding(5);
            previewCardPanel.Name = "previewCardPanel";
            previewCardPanel.Size = new Size(1868, 687);
            previewCardPanel.TabIndex = 3;
            // 
            // reportTitleLabel
            // 
            reportTitleLabel.Anchor = AnchorStyles.Top;
            reportTitleLabel.AutoSize = true;
            reportTitleLabel.ForeColor = Color.FromArgb(27, 42, 74);
            reportTitleLabel.Location = new Point(763, 56);
            reportTitleLabel.Margin = new Padding(5, 0, 5, 0);
            reportTitleLabel.Name = "reportTitleLabel";
            reportTitleLabel.Size = new Size(352, 32);
            reportTitleLabel.TabIndex = 0;
            reportTitleLabel.Text = "Employee Management System";
            reportTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reportSubtitleLabel
            // 
            reportSubtitleLabel.ForeColor = Color.FromArgb(27, 42, 74);
            reportSubtitleLabel.Location = new Point(0, 96);
            reportSubtitleLabel.Margin = new Padding(5, 0, 5, 0);
            reportSubtitleLabel.Name = "reportSubtitleLabel";
            reportSubtitleLabel.Size = new Size(1866, 42);
            reportSubtitleLabel.TabIndex = 1;
            reportSubtitleLabel.Text = "Employee List Report";
            reportSubtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reportMetaLabel
            // 
            reportMetaLabel.ForeColor = Color.Gray;
            reportMetaLabel.Location = new Point(-5, 134);
            reportMetaLabel.Margin = new Padding(5, 0, 5, 0);
            reportMetaLabel.Name = "reportMetaLabel";
            reportMetaLabel.Size = new Size(1866, 37);
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
            previewGrid.Location = new Point(41, 208);
            previewGrid.Margin = new Padding(5);
            previewGrid.Name = "previewGrid";
            previewGrid.ReadOnly = true;
            previewGrid.RightToLeft = RightToLeft.No;
            previewGrid.RowHeadersVisible = false;
            previewGrid.RowHeadersWidth = 82;
            previewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            previewGrid.Size = new Size(1788, 384);
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
            totalRecordsLabel.Location = new Point(41, 621);
            totalRecordsLabel.Margin = new Padding(5, 0, 5, 0);
            totalRecordsLabel.Name = "totalRecordsLabel";
            totalRecordsLabel.Size = new Size(180, 32);
            totalRecordsLabel.TabIndex = 4;
            totalRecordsLabel.Text = "Total Records: 0";
            // 
            // footerLabel
            // 
            footerLabel.ForeColor = Color.Gray;
            footerLabel.Location = new Point(1138, 621);
            footerLabel.Margin = new Padding(5, 0, 5, 0);
            footerLabel.Name = "footerLabel";
            footerLabel.Size = new Size(691, 37);
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
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(351, 1152);
            panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(lblAppTitle);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(351, 128);
            panelLogo.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(188, 48);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(111, 32);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "NexusHR";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (System.Drawing.Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, -5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(151, 133);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 144);
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
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(0, 224);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(358, 72);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(25, 48, 78);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 304);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(358, 72);
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
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 384);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(358, 72);
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
            btnLeave.ForeColor = Color.FromArgb(200, 200, 200);
            btnLeave.Location = new Point(0, 464);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(358, 72);
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
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 544);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(358, 72);
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
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 624);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(358, 72);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 928);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(358, 72);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(2301, 1152);
            Controls.Add(headerPanel);
            Controls.Add(filterCardPanel);
            Controls.Add(previewHeaderPanel);
            Controls.Add(previewCardPanel);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "reports";
            Text = "Reports";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterCardPanel.ResumeLayout(false);
            filterCardPanel.PerformLayout();
            previewHeaderPanel.ResumeLayout(false);
            previewHeaderPanel.PerformLayout();
            previewCardPanel.ResumeLayout(false);
            previewCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewGrid).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerTitle;
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

        // Sidebar Panel Container
        private Panel panelSideMenu;

        // Logo Section
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label lblAppTitle;

        // Navigation Buttons
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnLogout;
    }
}