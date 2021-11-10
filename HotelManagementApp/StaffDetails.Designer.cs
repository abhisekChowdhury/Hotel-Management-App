
namespace HotelManagementApp
{
    partial class StaffDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxEmployeeDetails = new System.Windows.Forms.ListBox();
            this.comboBoxStaffRole = new System.Windows.Forms.ComboBox();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxStaffRole);
            this.panel1.Controls.Add(this.buttonDeleteEmployee);
            this.panel1.Controls.Add(this.buttonUpdateEmployee);
            this.panel1.Controls.Add(this.buttonAddEmployee);
            this.panel1.Controls.Add(this.textBoxEmployeeName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 501);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.labelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 136);
            this.panel2.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(32, 22);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(402, 93);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "Transylvania";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employee Details";
            // 
            // listBoxEmployeeDetails
            // 
            this.listBoxEmployeeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listBoxEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listBoxEmployeeDetails.FormattingEnabled = true;
            this.listBoxEmployeeDetails.ItemHeight = 25;
            this.listBoxEmployeeDetails.Location = new System.Drawing.Point(470, 103);
            this.listBoxEmployeeDetails.Name = "listBoxEmployeeDetails";
            this.listBoxEmployeeDetails.Size = new System.Drawing.Size(424, 350);
            this.listBoxEmployeeDetails.TabIndex = 3;
            // 
            // comboBoxStaffRole
            // 
            this.comboBoxStaffRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.comboBoxStaffRole.FormattingEnabled = true;
            this.comboBoxStaffRole.Items.AddRange(new object[] {
            "Staff",
            "Administrator"});
            this.comboBoxStaffRole.Location = new System.Drawing.Point(186, 281);
            this.comboBoxStaffRole.Name = "comboBoxStaffRole";
            this.comboBoxStaffRole.Size = new System.Drawing.Size(175, 33);
            this.comboBoxStaffRole.TabIndex = 17;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(276, 389);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(112, 48);
            this.buttonDeleteEmployee.TabIndex = 16;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonUpdateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(146, 389);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(112, 48);
            this.buttonUpdateEmployee.TabIndex = 15;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonAddEmployee.Location = new System.Drawing.Point(16, 389);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(112, 48);
            this.buttonAddEmployee.TabIndex = 14;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(186, 226);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(175, 30);
            this.textBoxEmployeeName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Manage Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(927, 501);
            this.Controls.Add(this.listBoxEmployeeDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffDetails";
            this.Text = "StaffDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxEmployeeDetails;
        private System.Windows.Forms.ComboBox comboBoxStaffRole;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}