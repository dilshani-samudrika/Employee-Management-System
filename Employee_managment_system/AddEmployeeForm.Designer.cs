namespace Employee_managment_system
{
    partial class AddEmployeeForm
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelFirstName = new Label();
            txtFirstName = new TextBox();
            labelLastName = new Label();
            txtLastName = new TextBox();
            labelGender = new Label();
            cmbGender = new ComboBox();
            labelNIC = new Label();
            txtNIC = new TextBox();
            labelDOB = new Label();
            dtpDOB = new DateTimePicker();
            labelJoinDate = new Label();
            dtpJoinDate = new DateTimePicker();
            labelContact = new Label();
            txtContact = new TextBox();
            labelEmail = new Label();
            txtEmail = new TextBox();
            labelCategory = new Label();
            cmbCategory = new ComboBox();
            labelDepartment = new Label();
            cmbDepartment = new ComboBox();
            labelDesignation = new Label();
            cmbDesignation = new ComboBox();
            labelSalary = new Label();
            txtSalary = new TextBox();
            labelAddress = new Label();
            txtAddress = new TextBox();
            labelStatus = new Label();
            cmbStatus = new ComboBox();
            picEmployeePhoto = new PictureBox();
            btnUploadPhoto = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 37);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Add New Employee";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(labelFirstName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(labelLastName, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(labelGender, 0, 2);
            tableLayoutPanel1.Controls.Add(cmbGender, 1, 2);
            tableLayoutPanel1.Controls.Add(labelNIC, 0, 3);
            tableLayoutPanel1.Controls.Add(txtNIC, 1, 3);
            tableLayoutPanel1.Controls.Add(labelDOB, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpDOB, 1, 4);
            tableLayoutPanel1.Controls.Add(labelJoinDate, 0, 5);
            tableLayoutPanel1.Controls.Add(dtpJoinDate, 1, 5);
            tableLayoutPanel1.Controls.Add(labelContact, 0, 6);
            tableLayoutPanel1.Controls.Add(txtContact, 1, 6);
            tableLayoutPanel1.Controls.Add(labelEmail, 0, 7);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 7);
            tableLayoutPanel1.Controls.Add(labelCategory, 0, 8);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 8);
            tableLayoutPanel1.Controls.Add(labelDepartment, 0, 9);
            tableLayoutPanel1.Controls.Add(cmbDepartment, 1, 9);
            tableLayoutPanel1.Controls.Add(labelDesignation, 0, 10);
            tableLayoutPanel1.Controls.Add(cmbDesignation, 1, 10);
            tableLayoutPanel1.Controls.Add(labelSalary, 0, 11);
            tableLayoutPanel1.Controls.Add(txtSalary, 1, 11);
            tableLayoutPanel1.Controls.Add(labelAddress, 0, 12);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 12);
            tableLayoutPanel1.Controls.Add(labelStatus, 0, 13);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 13);
            tableLayoutPanel1.Location = new Point(20, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(394, 490);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.Location = new Point(3, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(120, 35);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First name *";
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.Location = new Point(3, 35);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(120, 35);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last name *";
            labelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 3;
            // 
            // labelGender
            // 
            labelGender.Location = new Point(3, 70);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(120, 35);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender";
            labelGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(140, 73);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(250, 28);
            cmbGender.TabIndex = 5;
            // 
            // labelNIC
            // 
            labelNIC.Location = new Point(3, 105);
            labelNIC.Name = "labelNIC";
            labelNIC.Size = new Size(120, 35);
            labelNIC.TabIndex = 6;
            labelNIC.Text = "NIC *";
            labelNIC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(140, 108);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(250, 27);
            txtNIC.TabIndex = 7;
            // 
            // labelDOB
            // 
            labelDOB.Location = new Point(3, 140);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(120, 35);
            labelDOB.TabIndex = 8;
            labelDOB.Text = "Date of Birth";
            labelDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(140, 143);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 9;
            // 
            // labelJoinDate
            // 
            labelJoinDate.Location = new Point(3, 175);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(120, 35);
            labelJoinDate.TabIndex = 10;
            labelJoinDate.Text = "Join Date";
            labelJoinDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(140, 178);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(250, 27);
            dtpJoinDate.TabIndex = 11;
            // 
            // labelContact
            // 
            labelContact.Location = new Point(3, 210);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(120, 35);
            labelContact.TabIndex = 12;
            labelContact.Text = "Contact No";
            labelContact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(140, 213);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(250, 27);
            txtContact.TabIndex = 13;
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(3, 245);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(120, 35);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email *";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 15;
            // 
            // labelCategory
            // 
            labelCategory.Location = new Point(3, 280);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(120, 35);
            labelCategory.TabIndex = 16;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(140, 283);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(250, 28);
            cmbCategory.TabIndex = 17;
            // 
            // labelDepartment
            // 
            labelDepartment.Location = new Point(3, 315);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(120, 35);
            labelDepartment.TabIndex = 18;
            labelDepartment.Text = "Department";
            labelDepartment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Location = new Point(140, 318);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(250, 28);
            cmbDepartment.TabIndex = 19;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // labelDesignation
            // 
            labelDesignation.Location = new Point(3, 350);
            labelDesignation.Name = "labelDesignation";
            labelDesignation.Size = new Size(120, 35);
            labelDesignation.TabIndex = 20;
            labelDesignation.Text = "Designation";
            labelDesignation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDesignation
            // 
            cmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesignation.Location = new Point(140, 353);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(250, 28);
            cmbDesignation.TabIndex = 21;
            // 
            // labelSalary
            // 
            labelSalary.Location = new Point(3, 385);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(120, 35);
            labelSalary.TabIndex = 22;
            labelSalary.Text = "Basic Salary (Rs)";
            labelSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(140, 388);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(250, 27);
            txtSalary.TabIndex = 23;
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(3, 420);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(120, 35);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Address";
            labelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 423);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 29);
            txtAddress.TabIndex = 25;
            // 
            // labelStatus
            // 
            labelStatus.Location = new Point(3, 455);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(120, 35);
            labelStatus.TabIndex = 26;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(140, 458);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 28);
            cmbStatus.TabIndex = 27;
            // 
            // picEmployeePhoto
            // 
            picEmployeePhoto.BorderStyle = BorderStyle.FixedSingle;
            picEmployeePhoto.Location = new Point(20, 70);
            picEmployeePhoto.Name = "picEmployeePhoto";
            picEmployeePhoto.Size = new Size(120, 120);
            picEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployeePhoto.TabIndex = 3;
            picEmployeePhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(150, 110);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(120, 35);
            btnUploadPhoto.TabIndex = 2;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(116, 723);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(368, 723);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(242, 723);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(540, 780);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnUploadPhoto);
            Controls.Add(picEmployeePhoto);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NexusHR - Add New Employee ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelFirstName;
        private TextBox txtFirstName;
        private Label labelLastName;
        private TextBox txtLastName;
        private Label labelGender;
        private ComboBox cmbGender;
        private Label labelNIC;
        private TextBox txtNIC;
        private Label labelDOB;
        private DateTimePicker dtpDOB;
        private Label labelJoinDate;
        private DateTimePicker dtpJoinDate;
        private Label labelContact;
        private TextBox txtContact;
        private Label labelEmail;
        private TextBox txtEmail;
        private Label labelCategory;
        private ComboBox cmbCategory;
        private Label labelDepartment;
        private ComboBox cmbDepartment;
        private Label labelDesignation;
        private ComboBox cmbDesignation;
        private Label labelSalary;
        private TextBox txtSalary;
        private Label labelAddress;
        private TextBox txtAddress;
        private Label labelStatus;
        private ComboBox cmbStatus;
        private PictureBox picEmployeePhoto;
        private Button btnUploadPhoto;
        private Button btnSave;
        private Button btnCancel;
        private Button btnClear;
    }
}
