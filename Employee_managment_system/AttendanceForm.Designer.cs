namespace Employee_managment_system
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            panelSideMenu = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            txtLate = new TextBox();
            txtHalfDay = new TextBox();
            txtAbsent = new TextBox();
            txtPresent = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvPending = new DataGridView();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            topBar = new Panel();
            lblPageTitle = new Label();
            btnDashboard = new Button();
            btnEmployees = new Button();
            btnDepartment = new Button();
            btnAttendance = new Button();
            btnLeave = new Button();
            btnPayroll = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            panel5.SuspendLayout();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(25, 48, 78);
            panelSideMenu.Controls.Add(pictureBox2);
            panelSideMenu.Controls.Add(panel4);
            panelSideMenu.Controls.Add(topBar);
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
            panelSideMenu.Size = new Size(1879, 1051);
            panelSideMenu.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_and_name_for_header;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.background_for_all_without_logo;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(dgvPending);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(348, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(1519, 978);
            panel4.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(txtLate);
            panel6.Controls.Add(txtHalfDay);
            panel6.Controls.Add(txtAbsent);
            panel6.Controls.Add(txtPresent);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(12, 836);
            panel6.Name = "panel6";
            panel6.Size = new Size(1345, 105);
            panel6.TabIndex = 18;
            panel6.Paint += panel6_Paint;
            // 
            // txtLate
            // 
            txtLate.Location = new Point(816, 42);
            txtLate.Name = "txtLate";
            txtLate.ReadOnly = true;
            txtLate.Size = new Size(77, 27);
            txtLate.TabIndex = 8;
            // 
            // txtHalfDay
            // 
            txtHalfDay.Location = new Point(610, 42);
            txtHalfDay.Name = "txtHalfDay";
            txtHalfDay.ReadOnly = true;
            txtHalfDay.Size = new Size(77, 27);
            txtHalfDay.TabIndex = 7;
            // 
            // txtAbsent
            // 
            txtAbsent.Location = new Point(351, 42);
            txtAbsent.Name = "txtAbsent";
            txtAbsent.ReadOnly = true;
            txtAbsent.Size = new Size(77, 27);
            txtAbsent.TabIndex = 6;
            // 
            // txtPresent
            // 
            txtPresent.Location = new Point(116, 42);
            txtPresent.Name = "txtPresent";
            txtPresent.ReadOnly = true;
            txtPresent.Size = new Size(77, 27);
            txtPresent.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 175, 89);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(997, 29);
            button1.Name = "button1";
            button1.Size = new Size(148, 45);
            button1.TabIndex = 4;
            button1.Text = "📊 Export CSV";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrchid;
            label6.Location = new Point(741, 35);
            label6.Name = "label6";
            label6.Size = new Size(57, 28);
            label6.TabIndex = 3;
            label6.Text = "Late:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(228, 145, 44);
            label5.Location = new Point(480, 38);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 2;
            label5.Text = "Half - Day:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(210, 64, 63);
            label4.Location = new Point(245, 38);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 1;
            label4.Text = "Absent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(98, 175, 89);
            label3.Location = new Point(16, 38);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 0;
            label3.Text = "Present: ";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPending.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPending.EnableHeadersVisualStyles = false;
            dgvPending.GridColor = SystemColors.MenuBar;
            dgvPending.Location = new Point(12, 113);
            dgvPending.MultiSelect = false;
            dgvPending.Name = "dgvPending";
            dgvPending.ReadOnly = true;
            dgvPending.RowHeadersVisible = false;
            dgvPending.RowHeadersWidth = 51;
            dgvPending.ScrollBars = ScrollBars.Vertical;
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.Size = new Size(1345, 717);
            dgvPending.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(122, 156, 199);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dateTimePicker1);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(11, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(1346, 61);
            panel5.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(670, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 18);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 2;
            label2.Text = "Department:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(25, 48, 78);
            topBar.Controls.Add(lblPageTitle);
            topBar.ForeColor = SystemColors.ControlLightLight;
            topBar.Location = new Point(348, 2);
            topBar.Margin = new Padding(5);
            topBar.Name = "topBar";
            topBar.Size = new Size(1297, 78);
            topBar.TabIndex = 13;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(20, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(327, 37);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Attendance Managment";
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
            btnDashboard.Click += btnDashboard_Click;
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
            btnEmployees.Click += btnEmployees_Click;
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
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(52, 152, 219);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 240);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(328, 45);
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
            btnLeave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeave.ForeColor = SystemColors.ScrollBar;
            btnLeave.Location = new Point(0, 290);
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
            btnPayroll.Font = new Font("Segoe UI", 10F);
            btnPayroll.ForeColor = Color.FromArgb(200, 200, 200);
            btnPayroll.Location = new Point(0, 340);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(220, 45);
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
            btnReports.Location = new Point(0, 390);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 45);
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
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 750);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 1051);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AttendanceForm";
            Text = "NexusHR - Attendance Managment";
            Load += Form2_Load;
            panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSideMenu;
        private Panel panel4;
        private Button btnAttendance;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnLogout;
        private Panel panel5;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvPending;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox txtPresent;
        private TextBox txtLate;
        private TextBox txtHalfDay;
        private TextBox txtAbsent;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnDepartment;
        private Panel topBar;
        private Label lblPageTitle;
        private PictureBox pictureBox2;
    }
}