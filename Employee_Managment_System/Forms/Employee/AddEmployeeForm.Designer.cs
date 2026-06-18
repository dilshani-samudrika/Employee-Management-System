namespace Employee_Managment
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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
            // NEW CONTROLS for credentials
            grpCredentials = new GroupBox();
            lblCredentialsInfo = new Label();
            lblUsernameLabel = new Label();
            lblGeneratedUsername = new Label();
            lblPasswordLabel = new Label();
            lblGeneratedPassword = new Label();
            btnRegeneratePassword = new Button();
            lblPasswordNote = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).BeginInit();
            grpCredentials.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(450, 490);
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
            txtFirstName.Location = new Point(160, 3);
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
            txtLastName.Location = new Point(160, 38);
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
            cmbGender.Location = new Point(160, 73);
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
            txtNIC.Location = new Point(160, 108);
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
            dtpDOB.Location = new Point(160, 143);
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
            dtpJoinDate.Location = new Point(160, 178);
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
            txtContact.Location = new Point(160, 213);
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
            txtEmail.Location = new Point(160, 248);
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
            cmbCategory.Location = new Point(160, 283);
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
            cmbDepartment.Location = new Point(160, 318);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(250, 28);
            cmbDepartment.TabIndex = 19;
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
            cmbDesignation.Location = new Point(160, 353);
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
            labelSalary.Text = "Basic Salary ($)";
            labelSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(160, 388);
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
            txtAddress.Location = new Point(160, 423);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 60);
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
            cmbStatus.Location = new Point(160, 458);
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
            // 
            // grpCredentials (NEW GroupBox)
            // 
            grpCredentials.BackColor = Color.FromArgb(255, 255, 224);
            grpCredentials.Controls.Add(lblCredentialsInfo);
            grpCredentials.Controls.Add(lblUsernameLabel);
            grpCredentials.Controls.Add(lblGeneratedUsername);
            grpCredentials.Controls.Add(lblPasswordLabel);
            grpCredentials.Controls.Add(lblGeneratedPassword);
            grpCredentials.Controls.Add(btnRegeneratePassword);
            grpCredentials.Controls.Add(lblPasswordNote);
            grpCredentials.Location = new Point(20, 680);
            grpCredentials.Name = "grpCredentials";
            grpCredentials.Size = new Size(480, 140);
            grpCredentials.TabIndex = 50;
            grpCredentials.TabStop = false;
            grpCredentials.Text = "🔐 Auto-Generated Login Credentials";
            grpCredentials.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // lblCredentialsInfo
            // 
            lblCredentialsInfo.AutoSize = true;
            lblCredentialsInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblCredentialsInfo.ForeColor = Color.Gray;
            lblCredentialsInfo.Location = new Point(10, 25);
            lblCredentialsInfo.Name = "lblCredentialsInfo";
            lblCredentialsInfo.Size = new Size(377, 15);
            lblCredentialsInfo.TabIndex = 0;
            lblCredentialsInfo.Text = "System will automatically generate these credentials when employee is saved:";
            // 
            // lblUsernameLabel
            // 
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsernameLabel.Location = new Point(10, 55);
            lblUsernameLabel.Name = "lblUsernameLabel";
            lblUsernameLabel.Size = new Size(78, 20);
            lblUsernameLabel.TabIndex = 1;
            lblUsernameLabel.Text = "Username:";
            // 
            // lblGeneratedUsername
            // 
            lblGeneratedUsername.AutoSize = true;
            lblGeneratedUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblGeneratedUsername.ForeColor = Color.FromArgb(0, 0, 192);
            lblGeneratedUsername.Location = new Point(100, 55);
            lblGeneratedUsername.Name = "lblGeneratedUsername";
            lblGeneratedUsername.Size = new Size(215, 20);
            lblGeneratedUsername.TabIndex = 2;
            lblGeneratedUsername.Text = "Will be generated as: EMPxxx";
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.AutoSize = true;
            lblPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPasswordLabel.Location = new Point(10, 85);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new Size(74, 20);
            lblPasswordLabel.TabIndex = 3;
            lblPasswordLabel.Text = "Password:";
            // 
            // lblGeneratedPassword
            // 
            lblGeneratedPassword.AutoSize = true;
            lblGeneratedPassword.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblGeneratedPassword.ForeColor = Color.DarkRed;
            lblGeneratedPassword.Location = new Point(100, 85);
            lblGeneratedPassword.Name = "lblGeneratedPassword";
            lblGeneratedPassword.Size = new Size(99, 18);
            lblGeneratedPassword.TabIndex = 4;
            lblGeneratedPassword.Text = "**********";
            // 
            // btnRegeneratePassword
            // 
            btnRegeneratePassword.BackColor = Color.FromArgb(52, 152, 219);
            btnRegeneratePassword.FlatStyle = FlatStyle.Flat;
            btnRegeneratePassword.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            btnRegeneratePassword.ForeColor = Color.White;
            btnRegeneratePassword.Location = new Point(220, 80);
            btnRegeneratePassword.Name = "btnRegeneratePassword";
            btnRegeneratePassword.Size = new Size(150, 28);
            btnRegeneratePassword.TabIndex = 5;
            btnRegeneratePassword.Text = "⟳ Regenerate Password";
            btnRegeneratePassword.UseVisualStyleBackColor = false;
            // 
            // lblPasswordNote
            // 
            lblPasswordNote.AutoSize = true;
            lblPasswordNote.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lblPasswordNote.ForeColor = Color.Gray;
            lblPasswordNote.Location = new Point(10, 118);
            lblPasswordNote.Name = "lblPasswordNote";
            lblPasswordNote.Size = new Size(448, 15);
            lblPasswordNote.TabIndex = 6;
            lblPasswordNote.Text = "⚠️ Note: Password will be securely hashed in database and sent to employee's email";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(250, 840);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(380, 840);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(540, 920);
            Controls.Add(grpCredentials);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnUploadPhoto);
            Controls.Add(picEmployeePhoto);
            Controls.Add(lblTitle);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Employee - Auto Credentials";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeePhoto).EndInit();
            grpCredentials.ResumeLayout(false);
            grpCredentials.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Control declarations
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

        // NEW Control declarations for credentials
        private GroupBox grpCredentials;
        private Label lblCredentialsInfo;
        private Label lblUsernameLabel;
        private Label lblGeneratedUsername;
        private Label lblPasswordLabel;
        private Label lblGeneratedPassword;
        private Button btnRegeneratePassword;
        private Label lblPasswordNote;
    }
}