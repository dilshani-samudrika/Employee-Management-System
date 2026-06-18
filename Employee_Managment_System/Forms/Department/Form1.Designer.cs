using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Departmanet_managment
{
    partial class DepartmentDesignationForm
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
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            gbDeptForm = new GroupBox();
            btnCancelDept = new Button();
            btnSaveDept = new Button();
            txtManagerId = new TextBox();
            txtDeptSection = new TextBox();
            txtDeptName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnDeleteDept = new Button();
            btnEditDept = new Button();
            btnNewDept = new Button();
            dgvDepartments = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            colDepartmentName = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            EmployeeCount = new DataGridViewTextBoxColumn();
            ManagerId = new DataGridViewTextBoxColumn();
            gbDesigForm = new GroupBox();
            cmbDesigDepartment = new ComboBox();
            btnCancelDesig = new Button();
            btnSaveDesig = new Button();
            txtDesigTitle = new TextBox();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            btnDeleteDesig = new Button();
            btnEditDesig = new Button();
            btnNewDesig = new Button();
            dgvDesignations = new DataGridView();
            DesignationId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            SssignedCount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbDeptForm.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            gbDesigForm.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(gbDeptForm);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(dgvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gbDesigForm);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(dgvDesignations);
            splitContainer1.Size = new Size(1078, 653);
            splitContainer1.SplitterDistance = 572;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(12, 500);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(501, 32);
            label4.TabIndex = 3;
            label4.Text = "Select a department to edit/delete. Cannot delete if employee count > 0";
            // 
            // gbDeptForm
            // 
            gbDeptForm.Controls.Add(btnCancelDept);
            gbDeptForm.Controls.Add(btnSaveDept);
            gbDeptForm.Controls.Add(txtManagerId);
            gbDeptForm.Controls.Add(txtDeptSection);
            gbDeptForm.Controls.Add(txtDeptName);
            gbDeptForm.Controls.Add(label3);
            gbDeptForm.Controls.Add(label2);
            gbDeptForm.Controls.Add(label1);
            gbDeptForm.Dock = DockStyle.Top;
            gbDeptForm.Location = new Point(0, 345);
            gbDeptForm.Name = "gbDeptForm";
            gbDeptForm.Size = new Size(572, 150);
            gbDeptForm.TabIndex = 2;
            gbDeptForm.TabStop = false;
            gbDeptForm.Text = "Department details";
            gbDeptForm.Visible = false;
            // 
            // btnCancelDept
            // 
            btnCancelDept.Location = new Point(446, 118);
            btnCancelDept.Name = "btnCancelDept";
            btnCancelDept.Size = new Size(94, 29);
            btnCancelDept.TabIndex = 7;
            btnCancelDept.Text = "Cancel";
            btnCancelDept.UseVisualStyleBackColor = true;
            btnCancelDept.Click += btnCancelDept_Click;
            // 
            // btnSaveDept
            // 
            btnSaveDept.Location = new Point(325, 118);
            btnSaveDept.Name = "btnSaveDept";
            btnSaveDept.Size = new Size(94, 29);
            btnSaveDept.TabIndex = 6;
            btnSaveDept.Text = "Save";
            btnSaveDept.UseVisualStyleBackColor = true;
            btnSaveDept.Click += btnSaveDept_Click;
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(156, 74);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(125, 27);
            txtManagerId.TabIndex = 5;
            // 
            // txtDeptSection
            // 
            txtDeptSection.Location = new Point(379, 38);
            txtDeptSection.Name = "txtDeptSection";
            txtDeptSection.Size = new Size(125, 27);
            txtDeptSection.TabIndex = 4;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(156, 38);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(125, 27);
            txtDeptName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 81);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Manager ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 45);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Section";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Department name";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteDept);
            panel1.Controls.Add(btnEditDept);
            panel1.Controls.Add(btnNewDept);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 45);
            panel1.TabIndex = 1;
            // 
            // btnDeleteDept
            // 
            btnDeleteDept.Location = new Point(354, 6);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(94, 29);
            btnDeleteDept.TabIndex = 2;
            btnDeleteDept.Text = "Delete";
            btnDeleteDept.UseVisualStyleBackColor = true;
            btnDeleteDept.Click += btnDeleteDept_Click;
            // 
            // btnEditDept
            // 
            btnEditDept.Location = new Point(238, 6);
            btnEditDept.Name = "btnEditDept";
            btnEditDept.Size = new Size(94, 29);
            btnEditDept.TabIndex = 1;
            btnEditDept.Text = "Edit";
            btnEditDept.UseVisualStyleBackColor = true;
            btnEditDept.Click += btnEditDept_Click;
            // 
            // btnNewDept
            // 
            btnNewDept.Location = new Point(126, 6);
            btnNewDept.Name = "btnNewDept";
            btnNewDept.Size = new Size(94, 29);
            btnNewDept.TabIndex = 0;
            btnNewDept.Text = "New";
            btnNewDept.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            dgvDepartments.BackgroundColor = SystemColors.Control;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Columns.AddRange(new DataGridViewColumn[] { id, colDepartmentName, Section, EmployeeCount, ManagerId });
            dgvDepartments.Dock = DockStyle.Top;
            dgvDepartments.Location = new Point(0, 0);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.Size = new Size(572, 300);
            dgvDepartments.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "DeptID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // colDepartmentName
            // 
            colDepartmentName.HeaderText = "Department name";
            colDepartmentName.MinimumWidth = 6;
            colDepartmentName.Name = "colDepartmentName";
            colDepartmentName.Width = 150;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.Width = 120;
            // 
            // EmployeeCount
            // 
            EmployeeCount.HeaderText = "Emp count";
            EmployeeCount.MinimumWidth = 6;
            EmployeeCount.Name = "EmployeeCount";
            EmployeeCount.ReadOnly = true;
            EmployeeCount.Width = 90;
            // 
            // ManagerId
            // 
            ManagerId.HeaderText = "Manager ID";
            ManagerId.MinimumWidth = 6;
            ManagerId.Name = "ManagerId";
            ManagerId.Width = 125;
            // 
            // gbDesigForm
            // 
            gbDesigForm.Controls.Add(cmbDesigDepartment);
            gbDesigForm.Controls.Add(btnCancelDesig);
            gbDesigForm.Controls.Add(btnSaveDesig);
            gbDesigForm.Controls.Add(txtDesigTitle);
            gbDesigForm.Controls.Add(label5);
            gbDesigForm.Controls.Add(label7);
            gbDesigForm.Dock = DockStyle.Top;
            gbDesigForm.Location = new Point(0, 295);
            gbDesigForm.Name = "gbDesigForm";
            gbDesigForm.Size = new Size(500, 150);
            gbDesigForm.TabIndex = 3;
            gbDesigForm.TabStop = false;
            gbDesigForm.Text = "Designation details";
            gbDesigForm.Visible = false;
            // 
            // cmbDesigDepartment
            // 
            cmbDesigDepartment.FormattingEnabled = true;
            cmbDesigDepartment.Location = new Point(156, 78);
            cmbDesigDepartment.Name = "cmbDesigDepartment";
            cmbDesigDepartment.Size = new Size(200, 28);
            cmbDesigDepartment.TabIndex = 8;
            // 
            // btnCancelDesig
            // 
            btnCancelDesig.Location = new Point(394, 118);
            btnCancelDesig.Name = "btnCancelDesig";
            btnCancelDesig.Size = new Size(94, 29);
            btnCancelDesig.TabIndex = 7;
            btnCancelDesig.Text = "Cancel";
            btnCancelDesig.UseVisualStyleBackColor = true;
            btnCancelDesig.Click += btnCancelDesig_Click;
            // 
            // btnSaveDesig
            // 
            btnSaveDesig.Location = new Point(279, 118);
            btnSaveDesig.Name = "btnSaveDesig";
            btnSaveDesig.Size = new Size(94, 29);
            btnSaveDesig.TabIndex = 6;
            btnSaveDesig.Text = "Save";
            btnSaveDesig.UseVisualStyleBackColor = true;
            btnSaveDesig.Click += btnSaveDesig_Click;
            // 
            // txtDesigTitle
            // 
            txtDesigTitle.Location = new Point(156, 38);
            txtDesigTitle.Name = "txtDesigTitle";
            txtDesigTitle.Size = new Size(200, 27);
            txtDesigTitle.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 81);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 2;
            label5.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 45);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 0;
            label7.Text = "Designation title";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDeleteDesig);
            panel2.Controls.Add(btnEditDesig);
            panel2.Controls.Add(btnNewDesig);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 45);
            panel2.TabIndex = 2;
            // 
            // btnDeleteDesig
            // 
            btnDeleteDesig.Location = new Point(354, 6);
            btnDeleteDesig.Name = "btnDeleteDesig";
            btnDeleteDesig.Size = new Size(94, 29);
            btnDeleteDesig.TabIndex = 2;
            btnDeleteDesig.Text = "Delete";
            btnDeleteDesig.UseVisualStyleBackColor = true;
            btnDeleteDesig.Click += btnDeleteDesig_Click;
            // 
            // btnEditDesig
            // 
            btnEditDesig.Location = new Point(238, 6);
            btnEditDesig.Name = "btnEditDesig";
            btnEditDesig.Size = new Size(94, 29);
            btnEditDesig.TabIndex = 1;
            btnEditDesig.Text = "Edit";
            btnEditDesig.UseVisualStyleBackColor = true;
            btnEditDesig.Click += btnEditDesig_Click;
            // 
            // btnNewDesig
            // 
            btnNewDesig.Location = new Point(126, 6);
            btnNewDesig.Name = "btnNewDesig";
            btnNewDesig.Size = new Size(94, 29);
            btnNewDesig.TabIndex = 0;
            btnNewDesig.Text = "New";
            btnNewDesig.UseVisualStyleBackColor = true;
            btnNewDesig.Click += btnNewDesig_Click;
            // 
            // dgvDesignations
            // 
            dgvDesignations.BackgroundColor = SystemColors.Control;
            dgvDesignations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesignations.Columns.AddRange(new DataGridViewColumn[] { DesignationId, Title, DepartmentName, SssignedCount });
            dgvDesignations.Dock = DockStyle.Top;
            dgvDesignations.Location = new Point(0, 0);
            dgvDesignations.Name = "dgvDesignations";
            dgvDesignations.RowHeadersWidth = 51;
            dgvDesignations.Size = new Size(500, 250);
            dgvDesignations.TabIndex = 0;
            // 
            // DesignationId
            // 
            DesignationId.HeaderText = "ID";
            DesignationId.MinimumWidth = 6;
            DesignationId.Name = "DesignationId";
            DesignationId.ReadOnly = true;
            DesignationId.Width = 60;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 150;
            // 
            // DepartmentName
            // 
            DepartmentName.HeaderText = "Department";
            DepartmentName.MinimumWidth = 6;
            DepartmentName.Name = "DepartmentName";
            DepartmentName.ReadOnly = true;
            DepartmentName.Width = 120;
            // 
            // SssignedCount
            // 
            SssignedCount.HeaderText = "Employees Assigned";
            SssignedCount.MinimumWidth = 6;
            SssignedCount.Name = "SssignedCount";
            SssignedCount.ReadOnly = true;
            SssignedCount.Width = 120;
            // 
            // DepartmentDesignationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 653);
            Controls.Add(splitContainer1);
            Name = "DepartmentDesignationForm";
            Text = "Department & Designation Studio";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbDeptForm.ResumeLayout(false);
            gbDeptForm.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            gbDesigForm.ResumeLayout(false);
            gbDesigForm.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDesignations).EndInit();
            ResumeLayout(false);
        }

        // Control declarations (already present above)
        private SplitContainer splitContainer1;
        private DataGridView dgvDepartments;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colDepartmentName;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn EmployeeCount;
        private DataGridViewTextBoxColumn ManagerId;
        private Panel panel1;
        private Button btnDeleteDept;
        private Button btnEditDept;
        private Button btnNewDept;
        private GroupBox gbDeptForm;
        private Button btnCancelDept;
        private Button btnSaveDept;
        private TextBox txtManagerId;
        private TextBox txtDeptSection;
        private TextBox txtDeptName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView dgvDesignations;
        private DataGridViewTextBoxColumn DesignationId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn DepartmentName;
        private DataGridViewTextBoxColumn SssignedCount;
        private Panel panel2;
        private Button btnDeleteDesig;
        private Button btnEditDesig;
        private Button btnNewDesig;
        private GroupBox gbDesigForm;
        private ComboBox cmbDesigDepartment;
        private Button btnCancelDesig;
        private Button btnSaveDesig;
        private TextBox txtDesigTitle;
        private Label label5;
        private Label label7;
    }
}