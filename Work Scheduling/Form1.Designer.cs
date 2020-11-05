namespace Work_Scheduling
{
    partial class Form1
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lbxWeekSchedule = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cbxWeekdays = new System.Windows.Forms.ComboBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnUnassigned = new System.Windows.Forms.RadioButton();
            this.rbtnAssigned = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWeeklySalary = new System.Windows.Forms.Label();
            this.btnDesireList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 65);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(203, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(102, 16);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(113, 20);
            this.tbxEmployeeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Name";
            // 
            // tbxEmployeeSalary
            // 
            this.tbxEmployeeSalary.Location = new System.Drawing.Point(103, 39);
            this.tbxEmployeeSalary.Name = "tbxEmployeeSalary";
            this.tbxEmployeeSalary.Size = new System.Drawing.Size(112, 20);
            this.tbxEmployeeSalary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Salary";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 16;
            this.lbxEmployees.Location = new System.Drawing.Point(12, 107);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(109, 196);
            this.lbxEmployees.TabIndex = 5;
            this.lbxEmployees.SelectedValueChanged += new System.EventHandler(this.lbxEmployees_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Available Employees";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(127, 149);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(88, 26);
            this.btnRemoveEmployee.TabIndex = 7;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // lbxWeekSchedule
            // 
            this.lbxWeekSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWeekSchedule.FormattingEnabled = true;
            this.lbxWeekSchedule.ItemHeight = 20;
            this.lbxWeekSchedule.Location = new System.Drawing.Point(236, 35);
            this.lbxWeekSchedule.Name = "lbxWeekSchedule";
            this.lbxWeekSchedule.Size = new System.Drawing.Size(298, 164);
            this.lbxWeekSchedule.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Week Schedule";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(127, 208);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(88, 26);
            this.btnAssign.TabIndex = 10;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cbxWeekdays
            // 
            this.cbxWeekdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWeekdays.FormattingEnabled = true;
            this.cbxWeekdays.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbxWeekdays.Location = new System.Drawing.Point(127, 181);
            this.cbxWeekdays.Name = "cbxWeekdays";
            this.cbxWeekdays.Size = new System.Drawing.Size(88, 21);
            this.cbxWeekdays.TabIndex = 11;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(127, 240);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 12;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnUnassigned
            // 
            this.rbtnUnassigned.AutoSize = true;
            this.rbtnUnassigned.Location = new System.Drawing.Point(127, 263);
            this.rbtnUnassigned.Name = "rbtnUnassigned";
            this.rbtnUnassigned.Size = new System.Drawing.Size(81, 17);
            this.rbtnUnassigned.TabIndex = 13;
            this.rbtnUnassigned.TabStop = true;
            this.rbtnUnassigned.Text = "Unassigned";
            this.rbtnUnassigned.UseVisualStyleBackColor = true;
            this.rbtnUnassigned.CheckedChanged += new System.EventHandler(this.rbtnUnassigned_CheckedChanged);
            // 
            // rbtnAssigned
            // 
            this.rbtnAssigned.AutoSize = true;
            this.rbtnAssigned.Location = new System.Drawing.Point(127, 286);
            this.rbtnAssigned.Name = "rbtnAssigned";
            this.rbtnAssigned.Size = new System.Drawing.Size(68, 17);
            this.rbtnAssigned.TabIndex = 14;
            this.rbtnAssigned.TabStop = true;
            this.rbtnAssigned.Text = "Assigned";
            this.rbtnAssigned.UseVisualStyleBackColor = true;
            this.rbtnAssigned.CheckedChanged += new System.EventHandler(this.rbtnAssigned_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Weekly Salary";
            // 
            // lblWeeklySalary
            // 
            this.lblWeeklySalary.AutoSize = true;
            this.lblWeeklySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklySalary.Location = new System.Drawing.Point(134, 107);
            this.lblWeeklySalary.Name = "lblWeeklySalary";
            this.lblWeeklySalary.Size = new System.Drawing.Size(44, 31);
            this.lblWeeklySalary.TabIndex = 16;
            this.lblWeeklySalary.Text = "€0";
            // 
            // btnDesireList
            // 
            this.btnDesireList.Location = new System.Drawing.Point(236, 208);
            this.btnDesireList.Name = "btnDesireList";
            this.btnDesireList.Size = new System.Drawing.Size(88, 26);
            this.btnDesireList.TabIndex = 17;
            this.btnDesireList.Text = "Desire List";
            this.btnDesireList.UseVisualStyleBackColor = true;
            this.btnDesireList.Click += new System.EventHandler(this.btnDesireList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 311);
            this.Controls.Add(this.btnDesireList);
            this.Controls.Add(this.lblWeeklySalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnAssigned);
            this.Controls.Add(this.rbtnUnassigned);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.cbxWeekdays);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxWeekSchedule);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmployeeSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEmployeeName);
            this.Controls.Add(this.btnAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Work Scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmployeeSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.ListBox lbxWeekSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cbxWeekdays;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnUnassigned;
        private System.Windows.Forms.RadioButton rbtnAssigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWeeklySalary;
        private System.Windows.Forms.Button btnDesireList;
    }
}

