using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.Policy;

namespace Employee_managment_system
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();

            // Basic Salary on the Salary Structure tab is a read-only reference
            textBox1.ReadOnly = true;
            textBox1.BackColor = SystemColors.Control;

            LoadEmployeesIntoCombos();
            LoadMonthSelection();

            chooseStatus.Items.Clear();
            chooseStatus.Items.AddRange(new object[] { "All", "Pending", "Processed", "Paid" });
            chooseStatus.SelectedIndex = 0;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            dataGridView1.ReadOnly = true;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            // Events not wired in the Designer
            employeeSelection.SelectedIndexChanged += employeeSelection_SelectedIndexChanged;
            textBox2.TextChanged += SalaryField_TextChanged;
            textBox3.TextChanged += SalaryField_TextChanged;
            textBox4.TextChanged += SalaryField_TextChanged;
            textBox5.TextChanged += SalaryField_TextChanged;
            textBox6.TextChanged += SalaryField_TextChanged;
            textBox7.TextChanged += SalaryField_TextChanged;
            textBox8.TextChanged += SalaryField_TextChanged;
            search_paymentHistory.Click += search_paymentHistory_Click;
            dataGridView2.CellClick += dataGridView2_CellClick;
            MonthSelection.SelectedIndexChanged += MonthSelection_SelectedIndexChanged;

            netPayment.Text = "Net Pay:";
            netPay.Text = "Rs. 0.00";
            TotalPayroll.Text = "Total Payroll: Rs. 0.00";
        }

        private void payrollmanaement_Load(object sender, EventArgs e)
        {
            dateFromPicker.Value = DateTime.Today.AddMonths(-1);
            dateTimePicker2.Value = DateTime.Today;
        }

        
        private void LoadEmployeesIntoCombos()
        {
            try
            {
                string query = "SELECT EmpNo, FullName FROM Employees ORDER BY FullName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("Display", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["Display"] = $"{row["FullName"]} ({row["EmpNo"]})";
                }

                employeeSelection.DataSource = dt;
                employeeSelection.DisplayMember = "Display";
                employeeSelection.ValueMember = "EmpNo";

                DataTable dtWithAll = dt.Copy();
                DataRow allRow = dtWithAll.NewRow();
                allRow["EmpNo"] = "All";
                allRow["FullName"] = "All";
                allRow["Display"] = "All";
                dtWithAll.Rows.InsertAt(allRow, 0);

                chooseEmployee.DataSource = dtWithAll;
                chooseEmployee.DisplayMember = "Display";
                chooseEmployee.ValueMember = "EmpNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonthSelection()
        {
            MonthSelection.Items.Clear();
            DateTime cursor = DateTime.Today;
            for (int i = 0; i < 12; i++)
            {
                MonthSelection.Items.Add(cursor.ToString("MMMM yyyy"));
                cursor = cursor.AddMonths(-1);
            }
            MonthSelection.SelectedIndex = 0;
        }

        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm att = new AttendanceForm();
            att.Show();
            this.Hide();
        }

        
        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveForm leave = new LeaveForm();
            leave.Show();
            this.Hide();
        }

        
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm payroll = new PayrollForm();
            payroll.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            reports report = new reports();
            report.Show();
            this.Hide();
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
        
        private void employeeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeSelection.SelectedValue == null) return;
            LoadSalaryStructure(employeeSelection.SelectedValue.ToString());
        }


        private void LoadSalaryStructure(string empNo)
        {
            try
            {
                string basicQuery = @"
            SELECT COALESCE(e.BasicSalary, des.BasicSalary, 0) AS Basic
            FROM Employees e
            LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
            WHERE e.EmpNo = @EmpNo";
                SqlParameter[] basicParams = { new SqlParameter("@EmpNo", empNo) };
                object basicResult = DatabaseHelper.ExecuteScalar(basicQuery, basicParams);
                textBox1.Text = (basicResult != null && basicResult != DBNull.Value)
                    ? Convert.ToDecimal(basicResult).ToString("0.00") : "0.00";

                string structQuery = @"
            SELECT HRA, DA, PFPercent, IncomeTaxPercent, ProfessionalTax, OtherDeductions
            FROM SalaryStructure WHERE EmpNo = @EmpNo";
                SqlParameter[] structParams = { new SqlParameter("@EmpNo", empNo) };
                DataTable dt = DatabaseHelper.ExecuteQuery(structQuery, structParams);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    textBox2.Text = Convert.ToDecimal(row["HRA"]).ToString("0.00");
                    textBox3.Text = Convert.ToDecimal(row["DA"]).ToString("0.00");
                    textBox5.Text = Convert.ToDecimal(row["PFPercent"]).ToString("0.00");
                    textBox6.Text = Convert.ToDecimal(row["IncomeTaxPercent"]).ToString("0.00");
                    textBox7.Text = Convert.ToDecimal(row["ProfessionalTax"]).ToString("0.00");
                    textBox8.Text = Convert.ToDecimal(row["OtherDeductions"]).ToString("0.00");
                }
                else
                {
                    textBox2.Text = "0.00";
                    textBox3.Text = "0.00";
                    textBox5.Text = "0.00";
                    textBox6.Text = "0.00";
                    textBox7.Text = "0.00";
                    textBox8.Text = "0.00";
                }

                LoadOTPay(empNo);
                UpdateNetPayPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salary structure: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadOTPay(string empNo)
        {
            try
            {
                if (MonthSelection.SelectedItem == null)
                {
                    textBox4.Text = "0.00";
                    return;
                }

                if (!DateTime.TryParseExact(MonthSelection.SelectedItem.ToString(), "MMMM yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime monthDate))
                {
                    textBox4.Text = "0.00";
                    return;
                }

                string query = @"
            SELECT COALESCE(des.OTRate, 0) AS OTRate,
                   (SELECT COALESCE(SUM(a.OTHours), 0) FROM Attendance a
                        WHERE a.EmpNo = e.EmpNo
                          AND MONTH(a.AttendDate) = @Month
                          AND YEAR(a.AttendDate) = @Year) AS TotalOTHours
            FROM Employees e
            LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
            WHERE e.EmpNo = @EmpNo";

                SqlParameter[] parameters = {
            new SqlParameter("@EmpNo", empNo),
            new SqlParameter("@Month", monthDate.Month),
            new SqlParameter("@Year", monthDate.Year)
        };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    decimal otRate = Convert.ToDecimal(dt.Rows[0]["OTRate"]);
                    decimal totalOTHours = Convert.ToDecimal(dt.Rows[0]["TotalOTHours"]);
                    decimal otPay = otRate * totalOTHours;
                    textBox4.Text = otPay.ToString("0.00");
                }
                else
                {
                    textBox4.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating OT pay: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "0.00";
            }
        }

        private void SalaryField_TextChanged(object sender, EventArgs e)
        {
            UpdateNetPayPreview();
        }

        private void UpdateNetPayPreview()
        {
            decimal basic = ParseDecimal(textBox1.Text);
            decimal hra = ParseDecimal(textBox2.Text);
            decimal da = ParseDecimal(textBox3.Text);
            decimal conveyance = ParseDecimal(textBox4.Text);
            decimal pfPercent = ParseDecimal(textBox5.Text);
            decimal incomeTaxPercent = ParseDecimal(textBox6.Text);
            decimal professionalTax = ParseDecimal(textBox7.Text);
            decimal otherDeductions = ParseDecimal(textBox8.Text);

            decimal allowances = hra + da + conveyance;
            decimal deductions = (basic * pfPercent / 100m) + (basic * incomeTaxPercent / 100m) + professionalTax + otherDeductions;
            decimal net = basic + allowances - deductions;

            netPayment.Text = "Net Pay:";
            netPay.Text = $"Rs. {net:N2}";
        }

        private decimal ParseDecimal(string text)
        {
            return decimal.TryParse(text, out decimal value) ? value : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeSelection.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee.", "Validation",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string empNo = employeeSelection.SelectedValue.ToString();

            decimal hra = ParseDecimal(textBox2.Text);
            decimal da = ParseDecimal(textBox3.Text);
            decimal pfPercent = ParseDecimal(textBox5.Text);
            decimal incomeTaxPercent = ParseDecimal(textBox6.Text);
            decimal professionalTax = ParseDecimal(textBox7.Text);
            decimal otherDeductions = ParseDecimal(textBox8.Text);

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM SalaryStructure WHERE EmpNo = @EmpNo";
                SqlParameter[] checkParams = { new SqlParameter("@EmpNo", empNo) };
                int exists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                SqlParameter[] parameters = {
            new SqlParameter("@EmpNo", empNo),
            new SqlParameter("@HRA", hra),
            new SqlParameter("@DA", da),
            new SqlParameter("@PFPercent", pfPercent),
            new SqlParameter("@IncomeTaxPercent", incomeTaxPercent),
            new SqlParameter("@ProfessionalTax", professionalTax),
            new SqlParameter("@OtherDeductions", otherDeductions)
        };

                if (exists > 0)
                {
                    string updateQuery = @"
                UPDATE SalaryStructure SET
                    HRA = @HRA, DA = @DA,
                    PFPercent = @PFPercent, IncomeTaxPercent = @IncomeTaxPercent,
                    ProfessionalTax = @ProfessionalTax, OtherDeductions = @OtherDeductions
                WHERE EmpNo = @EmpNo";

                    DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                }
                else
                {
                    string insertQuery = @"
                INSERT INTO SalaryStructure (EmpNo, HRA, DA, PFPercent, IncomeTaxPercent, ProfessionalTax, OtherDeductions)
                VALUES (@EmpNo, @HRA, @DA, @PFPercent, @IncomeTaxPercent, @ProfessionalTax, @OtherDeductions)";

                    DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                }

                UpdateNetPayPreview();
                MessageBox.Show("Salary structure saved successfully.", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving salary structure: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeSelection.SelectedValue != null)
            {
                LoadOTPay(employeeSelection.SelectedValue.ToString());
                UpdateNetPayPreview();
            }
        }

       
        private void generatePayroll_Click(object sender, EventArgs e)
        {
            if (MonthSelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.", "Validation",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(MonthSelection.SelectedItem.ToString(), "MMMM yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime monthDate))
            {
                MessageBox.Show("Invalid month selected.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int payMonth = monthDate.Month;
            int payYear = monthDate.Year;

            try
            {
                dataGridView1.Rows.Clear();
                decimal totalPayroll = 0;

                string query = @"
                    SELECT e.EmpNo, e.FullName,
                           COALESCE(e.BasicSalary, des.BasicSalary, 0) AS Basic,
                           COALESCE(ss.HRA,0) AS HRA,
                           COALESCE(ss.DA,0) AS DA,
                           COALESCE(ss.Conveyance,0) AS Conveyance,
                           COALESCE(ss.PFPercent,0) AS PFPercent,
                           COALESCE(ss.IncomeTaxPercent,0) AS IncomeTaxPercent,
                           COALESCE(ss.ProfessionalTax,0) AS ProfessionalTax,
                           COALESCE(ss.OtherDeductions,0) AS OtherDeductions,
                           COALESCE(des.OTRate,0) AS OTRate,
                           (SELECT COALESCE(SUM(a.OTHours),0) FROM Attendance a
                                WHERE a.EmpNo = e.EmpNo AND MONTH(a.AttendDate) = @Month AND YEAR(a.AttendDate) = @Year) AS TotalOTHours
                    FROM Employees e
                    LEFT JOIN Designations des ON e.DesignationID = des.DesignationID
                    LEFT JOIN SalaryStructure ss ON ss.EmpNo = e.EmpNo
                    ORDER BY e.FullName";

                SqlParameter[] parameters = {
                    new SqlParameter("@Month", payMonth),
                    new SqlParameter("@Year", payYear)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    string empNo = row["EmpNo"].ToString();
                    string fullName = row["FullName"].ToString();
                    decimal basic = Convert.ToDecimal(row["Basic"]);
                    decimal allowances = Convert.ToDecimal(row["HRA"]) + Convert.ToDecimal(row["DA"]) + Convert.ToDecimal(row["Conveyance"]);
                    decimal pfPercent = Convert.ToDecimal(row["PFPercent"]);
                    decimal incomeTaxPercent = Convert.ToDecimal(row["IncomeTaxPercent"]);
                    decimal professionalTax = Convert.ToDecimal(row["ProfessionalTax"]);
                    decimal otherDeductions = Convert.ToDecimal(row["OtherDeductions"]);
                    decimal otRate = Convert.ToDecimal(row["OTRate"]);
                    decimal totalOTHours = Convert.ToDecimal(row["TotalOTHours"]);

                    decimal otPay = totalOTHours * otRate;
                    decimal deductions = (basic * pfPercent / 100m) + (basic * incomeTaxPercent / 100m) + professionalTax + otherDeductions;
                    decimal netSalary = basic + allowances + otPay - deductions;

                    var record = GetOrCreatePayrollRecord(empNo, payMonth, payYear, basic, totalOTHours, otRate, otPay, allowances, deductions, netSalary);

                    int rowIndex = dataGridView1.Rows.Add(
                        fullName,
                        record.basic.ToString("N2"),
                        record.allowances.ToString("N2"),
                        record.deductions.ToString("N2"),
                        record.netSalary.ToString("N2"),
                        record.status
                    );
                    dataGridView1.Rows[rowIndex].Tag = record.payrollId;

                    totalPayroll += record.netSalary;
                }

                TotalPayroll.Text = $"Total Payroll: Rs. {totalPayroll:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating payroll: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private (int payrollId, string status, decimal basic, decimal allowances, decimal deductions, decimal netSalary)
            GetOrCreatePayrollRecord(string empNo, int payMonth, int payYear, decimal basic, decimal totalOTHours,
                                      decimal otRate, decimal otPay, decimal allowances, decimal deductions, decimal netSalary)
        {
            string checkQuery = @"
                SELECT PayrollID, Status, BasicSalary, Allowances, Deductions, NetSalary
                FROM Payroll WHERE EmpNo = @EmpNo AND PayMonth = @Month AND PayYear = @Year";

            SqlParameter[] checkParams = {
                new SqlParameter("@EmpNo", empNo),
                new SqlParameter("@Month", payMonth),
                new SqlParameter("@Year", payYear)
            };

            DataTable existing = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);

            if (existing.Rows.Count > 0)
            {
                DataRow row = existing.Rows[0];
                return (
                    Convert.ToInt32(row["PayrollID"]),
                    row["Status"].ToString(),
                    Convert.ToDecimal(row["BasicSalary"]),
                    Convert.ToDecimal(row["Allowances"]),
                    Convert.ToDecimal(row["Deductions"]),
                    Convert.ToDecimal(row["NetSalary"])
                );
            }

            string insertQuery = @"
                INSERT INTO Payroll (EmpNo, PayMonth, PayYear, BasicSalary, TotalOTHours, OTRate, OTPay,
                                      Allowances, Deductions, NetSalary, GeneratedDate, Status)
                VALUES (@EmpNo, @Month, @Year, @Basic, @TotalOTHours, @OTRate, @OTPay,
                        @Allowances, @Deductions, @NetSalary, GETDATE(), 'Pending');
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlParameter[] insertParams = {
                new SqlParameter("@EmpNo", empNo),
                new SqlParameter("@Month", payMonth),
                new SqlParameter("@Year", payYear),
                new SqlParameter("@Basic", basic),
                new SqlParameter("@TotalOTHours", totalOTHours),
                new SqlParameter("@OTRate", otRate),
                new SqlParameter("@OTPay", otPay),
                new SqlParameter("@Allowances", allowances),
                new SqlParameter("@Deductions", deductions),
                new SqlParameter("@NetSalary", netSalary)
            };

            int newId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(insertQuery, insertParams));

            return (newId, "Pending", basic, allowances, deductions, netSalary);
        }

        private void process_selected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one record to process.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int updatedCount = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Tag == null) continue;
                int payrollId = (int)row.Tag;

                string query = "UPDATE Payroll SET Status = 'Processed' WHERE PayrollID = @Id AND Status = 'Pending'";
                SqlParameter[] parameters = { new SqlParameter("@Id", payrollId) };

                int affected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (affected > 0)
                {
                    row.Cells["Status"].Value = "Processed";
                    updatedCount++;
                }
            }

            MessageBox.Show($"{updatedCount} record(s) marked as Processed.", "Success",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void release_payment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one record to release payment for.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Release payment for the selected record(s)? This will mark them as Paid.",
                               "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            int updatedCount = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Tag == null) continue;
                int payrollId = (int)row.Tag;

                string query = @"UPDATE Payroll
                                  SET Status = 'Paid', PaymentDate = GETDATE(), PaymentMethod = 'Bank Transfer'
                                  WHERE PayrollID = @Id AND Status IN ('Pending', 'Processed')";
                SqlParameter[] parameters = { new SqlParameter("@Id", payrollId) };

                int affected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (affected > 0)
                {
                    row.Cells["Status"].Value = "Paid";
                    updatedCount++;
                }
            }

            MessageBox.Show($"Payment released for {updatedCount} record(s).", "Success",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void payslip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee record to view the payslip.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string slip = $"Employee: {row.Cells["Employee"].Value}\n" +
                          $"Basic Salary: Rs. {row.Cells["Basic"].Value}\n" +
                          $"Allowances: Rs. {row.Cells["Allowance"].Value}\n" +
                          $"Deductions: Rs. {row.Cells["Deduct"].Value}\n" +
                          $"Net Pay: Rs. {row.Cells["Net_pay"].Value}\n" +
                          $"Status: {row.Cells["Status"].Value}";

            MessageBox.Show(slip, "Payslip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void search_paymentHistory_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();

                DateTime fromDate = dateFromPicker.Value.Date;
                DateTime toDate = dateTimePicker2.Value.Date;
                string empFilter = chooseEmployee.SelectedValue?.ToString() ?? "All";
                string statusFilter = chooseStatus.SelectedItem?.ToString() ?? "All";

                string query = @"
                    SELECT p.PayrollID, p.PayMonth, p.PayYear, e.FullName, p.NetSalary,
                           p.PaymentDate, p.PaymentMethod, p.Status
                    FROM Payroll p
                    LEFT JOIN Employees e ON p.EmpNo = e.EmpNo
                    WHERE p.GeneratedDate BETWEEN @From AND @To
                      AND (@EmpNo = 'All' OR p.EmpNo = @EmpNo)
                      AND (@Status = 'All' OR p.Status = @Status)
                    ORDER BY p.GeneratedDate DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@From", fromDate),
                    new SqlParameter("@To", toDate.AddDays(1).AddSeconds(-1)),
                    new SqlParameter("@EmpNo", empFilter),
                    new SqlParameter("@Status", statusFilter)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                decimal totalNet = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string monthLabel = new DateTime(Convert.ToInt32(row["PayYear"]), Convert.ToInt32(row["PayMonth"]), 1).ToString("MMMM yyyy");
                    decimal netSalary = Convert.ToDecimal(row["NetSalary"]);
                    string paymentDate = row["PaymentDate"] == DBNull.Value ? "-" : Convert.ToDateTime(row["PaymentDate"]).ToString("dd-MMM-yyyy");
                    string paymentMethod = row["PaymentMethod"] == DBNull.Value ? "-" : row["PaymentMethod"].ToString();

                    dataGridView2.Rows.Add(
                        row["PayrollID"].ToString(),
                        monthLabel,
                        row["FullName"]?.ToString() ?? "",
                        netSalary.ToString("N2"),
                        paymentDate,
                        paymentMethod,
                        row["Status"].ToString(),
                        "View"
                    );

                    totalNet += netSalary;
                }

                TotalnetPay.Text = $"Rs. {totalNet:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching payment history: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView2.Columns[e.ColumnIndex].Name != "Action") return;

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            string detail = $"Payment ID: {row.Cells["payId"].Value}\n" +
                            $"Month: {row.Cells["month"].Value}\n" +
                            $"Employee: {row.Cells["Employee_"].Value}\n" +
                            $"Net Pay: Rs. {row.Cells["NetPay_"].Value}\n" +
                            $"Payment Date: {row.Cells["payDate"].Value}\n" +
                            $"Payment Method: {row.Cells["method"].Value}\n" +
                            $"Status: {row.Cells["Status_"].Value}";

            MessageBox.Show(detail, "Payment Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateFromPicker.Value > dateTimePicker2.Value)
                dateTimePicker2.Value = dateFromPicker.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

