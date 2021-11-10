
namespace HotelManagementApp
{
    partial class AdminHomeForm
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
            this.buttonStaffDetails = new System.Windows.Forms.Button();
            this.buttonRoomDetails = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonCustomerDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dataGridAdminTodaysReservations = new System.Windows.Forms.DataGridView();
            this.labelTodaysReservations = new System.Windows.Forms.Label();
            this.dataGridViewAdminRoomInformation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.buttonDateFilter = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminTodaysReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminRoomInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonStaffDetails);
            this.panel1.Controls.Add(this.buttonRoomDetails);
            this.panel1.Controls.Add(this.buttonReservations);
            this.panel1.Controls.Add(this.buttonCustomerDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 732);
            this.panel1.TabIndex = 0;
            // 
            // buttonStaffDetails
            // 
            this.buttonStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonStaffDetails.Location = new System.Drawing.Point(-2, 378);
            this.buttonStaffDetails.Name = "buttonStaffDetails";
            this.buttonStaffDetails.Size = new System.Drawing.Size(258, 64);
            this.buttonStaffDetails.TabIndex = 6;
            this.buttonStaffDetails.Text = "Staff Details";
            this.buttonStaffDetails.UseVisualStyleBackColor = false;
            // 
            // buttonRoomDetails
            // 
            this.buttonRoomDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRoomDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonRoomDetails.Location = new System.Drawing.Point(1, 299);
            this.buttonRoomDetails.Name = "buttonRoomDetails";
            this.buttonRoomDetails.Size = new System.Drawing.Size(258, 64);
            this.buttonRoomDetails.TabIndex = 5;
            this.buttonRoomDetails.Text = "Room Details";
            this.buttonRoomDetails.UseVisualStyleBackColor = false;
            // 
            // buttonReservations
            // 
            this.buttonReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonReservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonReservations.Location = new System.Drawing.Point(1, 215);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(256, 64);
            this.buttonReservations.TabIndex = 4;
            this.buttonReservations.Text = "Reservations";
            this.buttonReservations.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerDetails
            // 
            this.buttonCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonCustomerDetails.Location = new System.Drawing.Point(0, 135);
            this.buttonCustomerDetails.Name = "buttonCustomerDetails";
            this.buttonCustomerDetails.Size = new System.Drawing.Size(258, 64);
            this.buttonCustomerDetails.TabIndex = 3;
            this.buttonCustomerDetails.Text = "Customer Details";
            this.buttonCustomerDetails.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.labelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 115);
            this.panel2.TabIndex = 2;
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(0, 21);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(258, 62);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Transylvania";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridAdminTodaysReservations
            // 
            this.dataGridAdminTodaysReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridAdminTodaysReservations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAdminTodaysReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminTodaysReservations.Location = new System.Drawing.Point(286, 61);
            this.dataGridAdminTodaysReservations.Name = "dataGridAdminTodaysReservations";
            this.dataGridAdminTodaysReservations.RowHeadersWidth = 62;
            this.dataGridAdminTodaysReservations.RowTemplate.Height = 28;
            this.dataGridAdminTodaysReservations.Size = new System.Drawing.Size(642, 237);
            this.dataGridAdminTodaysReservations.TabIndex = 2;
            // 
            // labelTodaysReservations
            // 
            this.labelTodaysReservations.AutoSize = true;
            this.labelTodaysReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTodaysReservations.Location = new System.Drawing.Point(281, 28);
            this.labelTodaysReservations.Name = "labelTodaysReservations";
            this.labelTodaysReservations.Size = new System.Drawing.Size(200, 25);
            this.labelTodaysReservations.TabIndex = 3;
            this.labelTodaysReservations.Text = "Today\'s Reservations";
            // 
            // dataGridViewAdminRoomInformation
            // 
            this.dataGridViewAdminRoomInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridViewAdminRoomInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAdminRoomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminRoomInformation.Location = new System.Drawing.Point(286, 407);
            this.dataGridViewAdminRoomInformation.Name = "dataGridViewAdminRoomInformation";
            this.dataGridViewAdminRoomInformation.RowHeadersWidth = 62;
            this.dataGridViewAdminRoomInformation.RowTemplate.Height = 28;
            this.dataGridViewAdminRoomInformation.Size = new System.Drawing.Size(642, 295);
            this.dataGridViewAdminRoomInformation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room Information";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Location = new System.Drawing.Point(544, 21);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(252, 30);
            this.dateCheckIn.TabIndex = 8;
            // 
            // buttonDateFilter
            // 
            this.buttonDateFilter.Location = new System.Drawing.Point(806, 18);
            this.buttonDateFilter.Name = "buttonDateFilter";
            this.buttonDateFilter.Size = new System.Drawing.Size(122, 37);
            this.buttonDateFilter.TabIndex = 9;
            this.buttonDateFilter.Text = "Filter";
            this.buttonDateFilter.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonLogOut.Location = new System.Drawing.Point(-2, 458);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(258, 64);
            this.buttonLogOut.TabIndex = 8;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(640, 314);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 36);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Revenue:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRevenue
            // 
            this.textBoxRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBoxRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRevenue.Location = new System.Drawing.Point(778, 315);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.Size = new System.Drawing.Size(152, 30);
            this.textBoxRevenue.TabIndex = 14;
            // 
            // AdminHomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 732);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxRevenue);
            this.Controls.Add(this.buttonDateFilter);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAdminRoomInformation);
            this.Controls.Add(this.labelTodaysReservations);
            this.Controls.Add(this.dataGridAdminTodaysReservations);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "AdminHomeForm";
            this.Text = "AdminHomeForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminTodaysReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminRoomInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonCustomerDetails;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.Button buttonStaffDetails;
        private System.Windows.Forms.Button buttonRoomDetails;
        private System.Windows.Forms.DataGridView dataGridAdminTodaysReservations;
        private System.Windows.Forms.Label labelTodaysReservations;
        private System.Windows.Forms.DataGridView dataGridViewAdminRoomInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Button buttonDateFilter;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxRevenue;
    }
}