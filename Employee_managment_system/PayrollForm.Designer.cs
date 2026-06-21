using Employee_managment_system.Properties;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Employee_managment_system
{
    partial class PayrollForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollForm));
            headerPanel = new Panel();
            headerTitle = new Label();
            salaryCardPanel = new Panel();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            employeeSelection = new ComboBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            payslip = new Button();
            release_payment = new Button();
            process_selected = new Button();
            TotalPayroll = new Label();
            dataGridView1 = new DataGridView();
            Employee = new DataGridViewTextBoxColumn();
            Basic = new DataGridViewTextBoxColumn();
            Allowance = new DataGridViewTextBoxColumn();
            Deduct = new DataGridViewTextBoxColumn();
            Net_pay = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            generatePayroll = new Button();
            MonthSelection = new ComboBox();
            label12 = new Label();
            payrollTime = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            label14 = new Label();
            TotalnetPay = new Label();
            search_paymentHistory = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateFromPicker = new DateTimePicker();
            chooseStatus = new ComboBox();
            chooseEmployee = new ComboBox();
            status__ = new Label();
            Employee__ = new Label();
            dateTo = new Label();
            dateFrom = new Label();
            dataGridView2 = new DataGridView();
            payId = new DataGridViewTextBoxColumn();
            month = new DataGridViewTextBoxColumn();
            Employee_ = new DataGridViewTextBoxColumn();
            NetPay_ = new DataGridViewTextBoxColumn();
            payDate = new DataGridViewTextBoxColumn();
            method = new DataGridViewTextBoxColumn();
            Status_ = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            label13 = new Label();
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
            netPayment = new Label();
            netPay = new Label();
            headerPanel.SuspendLayout();
            salaryCardPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(27, 42, 74);
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Location = new Point(351, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(2033, 70);
            headerPanel.TabIndex = 100;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.ForeColor = Color.White;
            headerTitle.Location = new Point(30, 18);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(276, 32);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "💰  Payroll Management";
            // 
            // salaryCardPanel
            // 
            salaryCardPanel.BackColor = Color.White;
            salaryCardPanel.BorderStyle = BorderStyle.FixedSingle;
            salaryCardPanel.Controls.Add(netPayment);
            salaryCardPanel.Controls.Add(button1);
            salaryCardPanel.Controls.Add(netPay);
            salaryCardPanel.Controls.Add(label11);
            salaryCardPanel.Controls.Add(label10);
            salaryCardPanel.Controls.Add(textBox8);
            salaryCardPanel.Controls.Add(textBox7);
            salaryCardPanel.Controls.Add(textBox6);
            salaryCardPanel.Controls.Add(textBox5);
            salaryCardPanel.Controls.Add(textBox4);
            salaryCardPanel.Controls.Add(textBox3);
            salaryCardPanel.Controls.Add(textBox2);
            salaryCardPanel.Controls.Add(textBox1);
            salaryCardPanel.Controls.Add(label9);
            salaryCardPanel.Controls.Add(label8);
            salaryCardPanel.Controls.Add(label7);
            salaryCardPanel.Controls.Add(label6);
            salaryCardPanel.Controls.Add(label5);
            salaryCardPanel.Controls.Add(label4);
            salaryCardPanel.Controls.Add(label3);
            salaryCardPanel.Controls.Add(employeeSelection);
            salaryCardPanel.Controls.Add(label2);
            salaryCardPanel.Location = new Point(20, 20);
            salaryCardPanel.Name = "salaryCardPanel";
            salaryCardPanel.Size = new Size(900, 890);
            salaryCardPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(643, 653);
            button1.Name = "button1";
            button1.Size = new Size(198, 46);
            button1.TabIndex = 21;
            button1.Text = "Save Structure";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(30, 58, 95);
            label11.Location = new Point(30, 27);
            label11.Name = "label11";
            label11.Size = new Size(180, 32);
            label11.TabIndex = 7;
            label11.Text = "Salary Structure";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(73, 80, 87);
            label10.Location = new Point(481, 519);
            label10.Name = "label10";
            label10.Size = new Size(203, 32);
            label10.TabIndex = 19;
            label10.Text = "Other Deductions";
            label10.Click += label10_Click;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(481, 554);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(360, 39);
            textBox8.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(30, 554);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(327, 39);
            textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(481, 467);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(360, 39);
            textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(30, 467);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(327, 39);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(481, 367);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(360, 39);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(30, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 39);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(481, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 39);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(30, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 39);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(73, 80, 87);
            label9.Location = new Point(30, 519);
            label9.Name = "label9";
            label9.Size = new Size(182, 32);
            label9.TabIndex = 10;
            label9.Text = "Professional Tax";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(73, 80, 87);
            label8.Location = new Point(481, 432);
            label8.Name = "label8";
            label8.Size = new Size(167, 32);
            label8.TabIndex = 9;
            label8.Text = "Income Tax(%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(73, 80, 87);
            label7.Location = new Point(30, 432);
            label7.Name = "label7";
            label7.Size = new Size(191, 32);
            label7.TabIndex = 8;
            label7.Text = "PF Deduction(%)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(73, 80, 87);
            label6.Location = new Point(481, 332);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 7;
            label6.Text = "OT pay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(73, 80, 87);
            label5.Location = new Point(491, 234);
            label5.Name = "label5";
            label5.Size = new Size(60, 32);
            label5.TabIndex = 6;
            label5.Text = "HRA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(73, 80, 87);
            label4.Location = new Point(30, 332);
            label4.Name = "label4";
            label4.Size = new Size(226, 32);
            label4.TabIndex = 5;
            label4.Text = "Dearness Allowance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(73, 80, 87);
            label3.Location = new Point(30, 234);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 4;
            label3.Text = "Basic Salary";
            // 
            // employeeSelection
            // 
            employeeSelection.FormattingEnabled = true;
            employeeSelection.Location = new Point(30, 162);
            employeeSelection.Name = "employeeSelection";
            employeeSelection.Size = new Size(811, 40);
            employeeSelection.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(73, 80, 87);
            label2.Location = new Point(30, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 1;
            label2.Text = "Employee";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(400, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1807, 890);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(salaryCardPanel);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1791, 836);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Salary Structure";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(payslip);
            tabPage2.Controls.Add(release_payment);
            tabPage2.Controls.Add(process_selected);
            tabPage2.Controls.Add(TotalPayroll);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(generatePayroll);
            tabPage2.Controls.Add(MonthSelection);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(payrollTime);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1791, 836);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Process Payroll";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // payslip
            // 
            payslip.BackColor = SystemColors.MenuHighlight;
            payslip.ForeColor = Color.MintCream;
            payslip.Location = new Point(1208, 603);
            payslip.Name = "payslip";
            payslip.Size = new Size(228, 113);
            payslip.TabIndex = 9;
            payslip.Text = "Payslip";
            payslip.UseVisualStyleBackColor = false;
            payslip.Click += payslip_Click;
            // 
            // release_payment
            // 
            release_payment.BackColor = Color.FromArgb(41, 173, 100);
            release_payment.ForeColor = Color.MintCream;
            release_payment.Location = new Point(627, 603);
            release_payment.Name = "release_payment";
            release_payment.Size = new Size(228, 113);
            release_payment.TabIndex = 8;
            release_payment.Text = "Release payment";
            release_payment.UseVisualStyleBackColor = false;
            release_payment.Click += release_payment_Click;
            // 
            // process_selected
            // 
            process_selected.BackColor = Color.FromArgb(36, 58, 95);
            process_selected.ForeColor = Color.MintCream;
            process_selected.Location = new Point(70, 603);
            process_selected.Name = "process_selected";
            process_selected.Size = new Size(245, 113);
            process_selected.TabIndex = 7;
            process_selected.Text = "Process selected";
            process_selected.UseVisualStyleBackColor = false;
            process_selected.Click += process_selected_Click;
            // 
            // TotalPayroll
            // 
            TotalPayroll.AutoSize = true;
            TotalPayroll.ForeColor = SystemColors.ActiveCaptionText;
            TotalPayroll.Location = new Point(29, 518);
            TotalPayroll.Name = "TotalPayroll";
            TotalPayroll.Size = new Size(0, 32);
            TotalPayroll.TabIndex = 6;
            TotalPayroll.Click += label13_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee, Basic, Allowance, Deduct, Net_pay, Status });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Cyan;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(22, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Size = new Size(1285, 289);
            dataGridView1.TabIndex = 5;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            // 
            // Employee
            // 
            Employee.HeaderText = "Employee";
            Employee.MinimumWidth = 10;
            Employee.Name = "Employee";
            Employee.Width = 200;
            // 
            // Basic
            // 
            Basic.HeaderText = "Basic";
            Basic.MinimumWidth = 10;
            Basic.Name = "Basic";
            Basic.Width = 200;
            // 
            // Allowance
            // 
            Allowance.HeaderText = "Allowance";
            Allowance.MinimumWidth = 10;
            Allowance.Name = "Allowance";
            Allowance.Width = 200;
            // 
            // Deduct
            // 
            Deduct.HeaderText = "Deduct";
            Deduct.MinimumWidth = 10;
            Deduct.Name = "Deduct";
            Deduct.Width = 200;
            // 
            // Net_pay
            // 
            Net_pay.HeaderText = "Net pay";
            Net_pay.MinimumWidth = 10;
            Net_pay.Name = "Net_pay";
            Net_pay.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            Status.Width = 200;
            // 
            // generatePayroll
            // 
            generatePayroll.BackColor = Color.FromArgb(30, 58, 95);
            generatePayroll.ForeColor = SystemColors.ControlLight;
            generatePayroll.Location = new Point(485, 66);
            generatePayroll.Name = "generatePayroll";
            generatePayroll.Size = new Size(186, 46);
            generatePayroll.TabIndex = 4;
            generatePayroll.Text = "Generate Payroll";
            generatePayroll.UseVisualStyleBackColor = false;
            generatePayroll.Click += generatePayroll_Click;
            // 
            // MonthSelection
            // 
            MonthSelection.FormattingEnabled = true;
            MonthSelection.Location = new Point(128, 72);
            MonthSelection.Name = "MonthSelection";
            MonthSelection.Size = new Size(242, 40);
            MonthSelection.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(22, 73);
            label12.Name = "label12";
            label12.Size = new Size(98, 32);
            label12.TabIndex = 2;
            label12.Text = "Month :";
            // 
            // payrollTime
            // 
            payrollTime.AutoSize = true;
            payrollTime.ForeColor = Color.FromArgb(30, 58, 95);
            payrollTime.Location = new Point(236, 21);
            payrollTime.Name = "payrollTime";
            payrollTime.Size = new Size(0, 32);
            payrollTime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 58, 95);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 0;
            label1.Text = "Process Payroll";
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(TotalnetPay);
            tabPage3.Controls.Add(search_paymentHistory);
            tabPage3.Controls.Add(dateTimePicker2);
            tabPage3.Controls.Add(dateFromPicker);
            tabPage3.Controls.Add(chooseStatus);
            tabPage3.Controls.Add(chooseEmployee);
            tabPage3.Controls.Add(status__);
            tabPage3.Controls.Add(Employee__);
            tabPage3.Controls.Add(dateTo);
            tabPage3.Controls.Add(dateFrom);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label13);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1791, 836);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Payment History";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(81, 618);
            label14.Name = "label14";
            label14.Size = new Size(154, 32);
            label14.TabIndex = 12;
            label14.Text = "Total Net Pay";
            label14.Click += label14_Click;
            // 
            // TotalnetPay
            // 
            TotalnetPay.AutoSize = true;
            TotalnetPay.ForeColor = SystemColors.ActiveCaptionText;
            TotalnetPay.Location = new Point(30, 1100);
            TotalnetPay.Name = "TotalnetPay";
            TotalnetPay.Size = new Size(154, 32);
            TotalnetPay.TabIndex = 11;
            TotalnetPay.Text = "Total Net Pay";
            // 
            // search_paymentHistory
            // 
            search_paymentHistory.BackColor = Color.FromArgb(36, 58, 95);
            search_paymentHistory.ForeColor = Color.MintCream;
            search_paymentHistory.Location = new Point(1551, 135);
            search_paymentHistory.Name = "search_paymentHistory";
            search_paymentHistory.Size = new Size(192, 56);
            search_paymentHistory.TabIndex = 10;
            search_paymentHistory.Text = "Search";
            search_paymentHistory.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(434, 143);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 39);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateFromPicker
            // 
            dateFromPicker.Format = DateTimePickerFormat.Short;
            dateFromPicker.Location = new Point(47, 143);
            dateFromPicker.Name = "dateFromPicker";
            dateFromPicker.Size = new Size(251, 39);
            dateFromPicker.TabIndex = 8;
            dateFromPicker.ValueChanged += dateFromPicker_ValueChanged;
            // 
            // chooseStatus
            // 
            chooseStatus.FormattingEnabled = true;
            chooseStatus.Location = new Point(1230, 145);
            chooseStatus.Name = "chooseStatus";
            chooseStatus.Size = new Size(242, 40);
            chooseStatus.TabIndex = 7;
            // 
            // chooseEmployee
            // 
            chooseEmployee.FormattingEnabled = true;
            chooseEmployee.Location = new Point(814, 142);
            chooseEmployee.Name = "chooseEmployee";
            chooseEmployee.Size = new Size(242, 40);
            chooseEmployee.TabIndex = 6;
            chooseEmployee.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // status__
            // 
            status__.AutoSize = true;
            status__.ForeColor = Color.FromArgb(36, 58, 95);
            status__.Location = new Point(1230, 93);
            status__.Name = "status__";
            status__.Size = new Size(85, 32);
            status__.TabIndex = 5;
            status__.Text = "Status ";
            // 
            // Employee__
            // 
            Employee__.AutoSize = true;
            Employee__.ForeColor = Color.FromArgb(36, 58, 95);
            Employee__.Location = new Point(814, 93);
            Employee__.Name = "Employee__";
            Employee__.Size = new Size(119, 32);
            Employee__.TabIndex = 4;
            Employee__.Text = "Employee";
            // 
            // dateTo
            // 
            dateTo.AutoSize = true;
            dateTo.ForeColor = Color.FromArgb(36, 58, 95);
            dateTo.Location = new Point(445, 93);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(101, 32);
            dateTo.TabIndex = 3;
            dateTo.Text = "Date To:";
            // 
            // dateFrom
            // 
            dateFrom.AutoSize = true;
            dateFrom.ForeColor = Color.FromArgb(36, 58, 95);
            dateFrom.Location = new Point(47, 93);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(131, 32);
            dateFrom.TabIndex = 2;
            dateFrom.Text = "Date From:";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { payId, month, Employee_, NetPay_, payDate, method, Status_, Action });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.Cyan;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView2.Location = new Point(2, 231);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView2.Size = new Size(1687, 291);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            
            // 
            // payId
            // 
            payId.HeaderText = "Payment ID";
            payId.MinimumWidth = 10;
            payId.Name = "payId";
            payId.Width = 200;
            // 
            // month
            // 
            month.HeaderText = "Month";
            month.MinimumWidth = 10;
            month.Name = "month";
            month.Width = 200;
            // 
            // Employee_
            // 
            Employee_.HeaderText = "Employee";
            Employee_.MinimumWidth = 10;
            Employee_.Name = "Employee_";
            Employee_.Width = 200;
            // 
            // NetPay_
            // 
            NetPay_.HeaderText = "Net Pay";
            NetPay_.MinimumWidth = 10;
            NetPay_.Name = "NetPay_";
            NetPay_.Width = 200;
            // 
            // payDate
            // 
            payDate.HeaderText = "Payment date";
            payDate.MinimumWidth = 10;
            payDate.Name = "payDate";
            payDate.Width = 200;
            // 
            // method
            // 
            method.HeaderText = "Payment Method";
            method.MinimumWidth = 10;
            method.Name = "method";
            method.Width = 200;
            // 
            // Status_
            // 
            Status_.HeaderText = "Status";
            Status_.MinimumWidth = 10;
            Status_.Name = "Status_";
            Status_.Width = 200;
            // 
            // Action
            // 
            Action.HeaderText = "action";
            Action.MinimumWidth = 10;
            Action.Name = "Action";
            Action.Width = 200;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(36, 58, 95);
            label13.Location = new Point(47, 42);
            label13.Name = "label13";
            label13.Size = new Size(188, 32);
            label13.TabIndex = 0;
            label13.Text = "Payment History";
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
            panelSideMenu.Size = new Size(351, 885);
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
            pictureBoxLogo.Location = new Point(0, -9);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(182, 146);
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
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.ForeColor = Color.FromArgb(200, 200, 200);
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
            btnPayroll.BackColor = Color.FromArgb(52, 152, 219);
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.ForeColor = Color.White;
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
            btnReports.BackColor = Color.FromArgb(25, 48, 78);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.FromArgb(200, 200, 200);
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
            // netPayment
            // 
            netPayment.AutoSize = true;
            netPayment.Location = new Point(167, 653);
            netPayment.Name = "netPayment";
            netPayment.RightToLeft = RightToLeft.Yes;
            netPayment.Size = new Size(198,46);
            netPayment.TabIndex = 22;
            // 
            // netPay
            // 
            netPay.AutoSize = true;
            netPay.BackColor = Color.PaleGreen;
            netPay.Location = new Point(300, 653);
            netPay.Name = "netPay";
            netPay.RightToLeft = RightToLeft.Yes;
            netPay.Size = new Size(198,46);
            netPay.TabIndex = 20;
            netPay.Click += label12_Click;
            // 
            // PayrollForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2340, 885);
            Controls.Add(panelSideMenu);
            Controls.Add(headerPanel);
            Controls.Add(tabControl1);
            ForeColor = Color.Cyan;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PayrollForm";
            Text = "Payroll Management";
            Load += payrollmanaement_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            salaryCardPanel.ResumeLayout(false);
            salaryCardPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerTitle;
        private Panel salaryCardPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox employeeSelection;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label11;
        private Label label1;
        private Label payrollTime;
        private Label netPay;
        private Button button1;
        private Label label12;
        private ComboBox MonthSelection;
        private Button generatePayroll;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Basic;
        private DataGridViewTextBoxColumn Allowance;
        private DataGridViewTextBoxColumn Deduct;
        private DataGridViewTextBoxColumn Net_pay;
        private DataGridViewTextBoxColumn Status;
        private Label TotalPayroll;
        private Button process_selected;
        private Button payslip;
        private Button release_payment;
        private Label label13;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn payId;
        private DataGridViewTextBoxColumn month;
        private DataGridViewTextBoxColumn Employee_;
        private DataGridViewTextBoxColumn NetPay_;
        private DataGridViewTextBoxColumn payDate;
        private DataGridViewTextBoxColumn method;
        private DataGridViewTextBoxColumn Status_;
        private Label label16;
        private Label label15;
        private Label dateFrom;
        private DataGridViewTextBoxColumn Action;
        private Label dateTo;
        private Label status__;
        private Label Employee__;
        private ComboBox chooseEmployee;
        private ComboBox chooseStatus;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateFromPicker;
        private Button search_paymentHistory;
        private Label TotalnetPay;
        private Label label14;
        private Label netPayment;
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
    }
}