namespace Employee_managment_system
{
    partial class LeaveForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveForm));
            btnLogout = new Button();
            btnReports = new Button();
            btnPayroll = new Button();
            btnLeave = new Button();
            btnAttendance = new Button();
            btnDepartment = new Button();
            btnEmployees = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            topBar = new Panel();
            lblPageTitle = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvHistory = new DataGridView();
            label7 = new Label();
            dgvPending = new DataGridView();
            label6 = new Label();
            panel5 = new Panel();
            lblTodayLeaveCount = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblRejectedCount = new Label();
            label4 = new Label();
            pnlPending = new Panel();
            label2 = new Label();
            lblPendingCount = new Label();
            panel7 = new Panel();
            lblApprovedCount = new Label();
            label3 = new Label();
            panelSideMenu = new Panel();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            topBar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            pnlPending.SuspendLayout();
            panel7.SuspendLayout();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 48, 78);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 750);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
            btnReports.Location = new Point(0, 390);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(328, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click_1;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(25, 48, 78);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 340);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(328, 45);
            btnPayroll.TabIndex = 6;
            btnPayroll.Text = "💰 Payroll";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click_1;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(52, 152, 219);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeave.ForeColor = Color.White;
            btnLeave.Location = new Point(0, 290);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(328, 45);
            btnLeave.TabIndex = 5;
            btnLeave.Text = "🏖 Leave";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(25, 48, 78);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F);
            btnAttendance.ForeColor = Color.FromArgb(200, 200, 200);
            btnAttendance.Location = new Point(0, 240);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(328, 45);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click_1;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(25, 48, 78);
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F);
            btnDepartment.ForeColor = Color.FromArgb(200, 200, 200);
            btnDepartment.Location = new Point(0, 190);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(328, 45);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "🏢 Department";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click_1;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(25, 48, 78);
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = SystemColors.ScrollBar;
            btnEmployees.Location = new Point(0, 140);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(328, 45);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "👥 Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 48, 78);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(200, 200, 200);
            btnDashboard.Location = new Point(0, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(328, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 58, 95);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(topBar);
            panelLogo.Controls.Add(panel3);
            panelLogo.Controls.Add(panel2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1870, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_and_name_for_header;
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(25, 48, 78);
            topBar.Controls.Add(lblPageTitle);
            topBar.ForeColor = SystemColors.ControlLightLight;
            topBar.Location = new Point(335, 0);
            topBar.Margin = new Padding(5);
            topBar.Name = "topBar";
            topBar.Size = new Size(1297, 80);
            topBar.TabIndex = 12;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(20, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(254, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Leave Managment";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(221, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 703);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(222, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 728);
            panel2.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.background_for_all_without_logo;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(dgvHistory);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(dgvPending);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(pnlPending);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(347, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(1523, 1016);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = SystemColors.Menu;
            dgvHistory.Location = new Point(41, 562);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.ScrollBars = ScrollBars.Vertical;
            dgvHistory.Size = new Size(1120, 334);
            dgvHistory.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(32, 61, 101);
            label7.Location = new Point(41, 502);
            label7.Name = "label7";
            label7.Size = new Size(160, 31);
            label7.TabIndex = 17;
            label7.Text = "Leave History";
            // 
            // dgvPending
            // 
            dgvPending.AllowUserToAddRows = false;
            dgvPending.AllowUserToDeleteRows = false;
            dgvPending.AllowUserToResizeRows = false;
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPending.BackgroundColor = Color.White;
            dgvPending.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPending.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Navy;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPending.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPending.EnableHeadersVisualStyles = false;
            dgvPending.GridColor = SystemColors.MenuBar;
            dgvPending.Location = new Point(41, 213);
            dgvPending.MultiSelect = false;
            dgvPending.Name = "dgvPending";
            dgvPending.ReadOnly = true;
            dgvPending.RowHeadersVisible = false;
            dgvPending.RowHeadersWidth = 51;
            dgvPending.ScrollBars = ScrollBars.Vertical;
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.Size = new Size(1120, 266);
            dgvPending.TabIndex = 16;
            dgvPending.CellClick += dgvPending_CellClick;
            dgvPending.CellContentClick += dgvPending_CellContentClick;
            dgvPending.MouseClick += dgvPending_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(32, 61, 101);
            label6.Location = new Point(41, 163);
            label6.Name = "label6";
            label6.Size = new Size(285, 31);
            label6.TabIndex = 15;
            label6.Text = "+ PendingLeave Requests";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(228, 145, 44);
            panel5.Controls.Add(lblTodayLeaveCount);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(851, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 100);
            panel5.TabIndex = 14;
            // 
            // lblTodayLeaveCount
            // 
            lblTodayLeaveCount.AutoSize = true;
            lblTodayLeaveCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayLeaveCount.ForeColor = Color.White;
            lblTodayLeaveCount.Location = new Point(133, 44);
            lblTodayLeaveCount.Name = "lblTodayLeaveCount";
            lblTodayLeaveCount.Size = new Size(49, 38);
            lblTodayLeaveCount.TabIndex = 9;
            lblTodayLeaveCount.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 3);
            label5.Name = "label5";
            label5.Size = new Size(265, 28);
            label5.TabIndex = 11;
            label5.Text = "Employees on Leave Today";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(210, 64, 63);
            panel6.Controls.Add(lblRejectedCount);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(581, 25);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 100);
            panel6.TabIndex = 13;
            // 
            // lblRejectedCount
            // 
            lblRejectedCount.AutoSize = true;
            lblRejectedCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRejectedCount.ForeColor = Color.White;
            lblRejectedCount.Location = new Point(101, 44);
            lblRejectedCount.Name = "lblRejectedCount";
            lblRejectedCount.Size = new Size(49, 38);
            lblRejectedCount.TabIndex = 10;
            lblRejectedCount.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 3);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 10;
            label4.Text = "Rejected Leaves";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(98, 175, 89);
            pnlPending.Controls.Add(label2);
            pnlPending.Controls.Add(lblPendingCount);
            pnlPending.Location = new Point(41, 25);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(250, 100);
            pnlPending.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 4);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 8;
            label2.Text = "Pending Leave Requests";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(98, 44);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(49, 38);
            lblPendingCount.TabIndex = 8;
            lblPendingCount.Text = "00";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(51, 96, 173);
            panel7.Controls.Add(lblApprovedCount);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(311, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 100);
            panel7.TabIndex = 12;
            // 
            // lblApprovedCount
            // 
            lblApprovedCount.AutoSize = true;
            lblApprovedCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovedCount.ForeColor = Color.White;
            lblApprovedCount.Location = new Point(101, 44);
            lblApprovedCount.Name = "lblApprovedCount";
            lblApprovedCount.Size = new Size(49, 38);
            lblApprovedCount.TabIndex = 11;
            lblApprovedCount.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 3);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 9;
            label3.Text = "Approved Leaves";
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(25, 48, 78);
            panelSideMenu.Controls.Add(panel4);
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
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(1870, 1055);
            panelSideMenu.TabIndex = 2;
            // 
            // LeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1870, 1055);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LeaveForm";
            Text = "NexusHR - Leave Managment";
            Load += Form1_Load;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Label lblAppTitle;
        private PictureBox pictureBoxLogo;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnLogout;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label lblPageTitle;
        private Panel panel1;
        private DataGridView dgvPending;
        private Label label6;
        private Panel panel5;
        private Label lblTodayLeaveCount;
        private Label label5;
        private Panel panel6;
        private Label lblRejectedCount;
        private Label label4;
        private Panel pnlPending;
        private Label label2;
        private Label lblPendingCount;
        private Panel panel7;
        private Label lblApprovedCount;
        private Label label3;
        private DataGridView dgvHistory;
        private Label label7;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel topBar;
    }
}