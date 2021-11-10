
namespace HotelManagementApp
{
    partial class ReceptionistHomeForm
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalRooms = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.labelDeluxe = new System.Windows.Forms.Label();
            this.totalRoomLabel = new System.Windows.Forms.Label();
            this.buttonRoomDetails = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonCustomerDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dataGridViewTodaysReservations = new System.Windows.Forms.DataGridView();
            this.labelTodaysReservations = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.buttonDateFilter = new System.Windows.Forms.Button();
            this.bookCount = new System.Windows.Forms.Label();
            this.totalBook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodaysReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonRoomDetails);
            this.panel1.Controls.Add(this.buttonReservations);
            this.panel1.Controls.Add(this.buttonCustomerDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 770);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 396);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(289, 78);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalRooms);
            this.panel3.Controls.Add(this.userNameLabel);
            this.panel3.Controls.Add(this.labelDeluxe);
            this.panel3.Controls.Add(this.totalRoomLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 250);
            this.panel3.TabIndex = 5;
            // 
            // totalRooms
            // 
            this.totalRooms.AllowDrop = true;
            this.totalRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalRooms.Location = new System.Drawing.Point(86, 63);
            this.totalRooms.Name = "totalRooms";
            this.totalRooms.Size = new System.Drawing.Size(93, 25);
            this.totalRooms.TabIndex = 11;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(0, 182);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(289, 43);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Staff";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeluxe
            // 
            this.labelDeluxe.Location = new System.Drawing.Point(76, 139);
            this.labelDeluxe.Name = "labelDeluxe";
            this.labelDeluxe.Size = new System.Drawing.Size(103, 43);
            this.labelDeluxe.TabIndex = 1;
            this.labelDeluxe.Text = "Welcome:";
            this.labelDeluxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalRoomLabel
            // 
            this.totalRoomLabel.Location = new System.Drawing.Point(29, 17);
            this.totalRoomLabel.Name = "totalRoomLabel";
            this.totalRoomLabel.Size = new System.Drawing.Size(222, 46);
            this.totalRoomLabel.TabIndex = 0;
            this.totalRoomLabel.Text = "Total Available rooms:";
            // 
            // buttonRoomDetails
            // 
            this.buttonRoomDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRoomDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonRoomDetails.Location = new System.Drawing.Point(0, 312);
            this.buttonRoomDetails.Name = "buttonRoomDetails";
            this.buttonRoomDetails.Size = new System.Drawing.Size(289, 78);
            this.buttonRoomDetails.TabIndex = 4;
            this.buttonRoomDetails.Text = "Room Details";
            this.buttonRoomDetails.UseVisualStyleBackColor = false;
            // 
            // buttonReservations
            // 
            this.buttonReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonReservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonReservations.Location = new System.Drawing.Point(0, 225);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(289, 81);
            this.buttonReservations.TabIndex = 3;
            this.buttonReservations.Text = "New Reservations";
            this.buttonReservations.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerDetails
            // 
            this.buttonCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonCustomerDetails.Location = new System.Drawing.Point(0, 139);
            this.buttonCustomerDetails.Name = "buttonCustomerDetails";
            this.buttonCustomerDetails.Size = new System.Drawing.Size(289, 80);
            this.buttonCustomerDetails.TabIndex = 2;
            this.buttonCustomerDetails.Text = "Manage Customers";
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
            this.panel2.Size = new System.Drawing.Size(289, 116);
            this.panel2.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(0, 23);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(280, 61);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Transylvania";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTodaysReservations
            // 
            this.dataGridViewTodaysReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridViewTodaysReservations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTodaysReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodaysReservations.Location = new System.Drawing.Point(319, 62);
            this.dataGridViewTodaysReservations.Name = "dataGridViewTodaysReservations";
            this.dataGridViewTodaysReservations.RowHeadersWidth = 62;
            this.dataGridViewTodaysReservations.RowTemplate.Height = 28;
            this.dataGridViewTodaysReservations.Size = new System.Drawing.Size(710, 328);
            this.dataGridViewTodaysReservations.TabIndex = 1;
            // 
            // labelTodaysReservations
            // 
            this.labelTodaysReservations.AutoSize = true;
            this.labelTodaysReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTodaysReservations.Location = new System.Drawing.Point(314, 24);
            this.labelTodaysReservations.Name = "labelTodaysReservations";
            this.labelTodaysReservations.Size = new System.Drawing.Size(200, 25);
            this.labelTodaysReservations.TabIndex = 2;
            this.labelTodaysReservations.Text = "Today\'s Reservations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 463);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(710, 282);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available room information:";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Location = new System.Drawing.Point(520, 19);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(252, 30);
            this.dateCheckIn.TabIndex = 7;
            // 
            // buttonDateFilter
            // 
            this.buttonDateFilter.Location = new System.Drawing.Point(787, 18);
            this.buttonDateFilter.Name = "buttonDateFilter";
            this.buttonDateFilter.Size = new System.Drawing.Size(122, 37);
            this.buttonDateFilter.TabIndex = 8;
            this.buttonDateFilter.Text = "Filter";
            this.buttonDateFilter.UseVisualStyleBackColor = true;
            // 
            // bookCount
            // 
            this.bookCount.AutoSize = true;
            this.bookCount.Location = new System.Drawing.Point(749, 403);
            this.bookCount.Name = "bookCount";
            this.bookCount.Size = new System.Drawing.Size(180, 25);
            this.bookCount.TabIndex = 9;
            this.bookCount.Text = "Total Reservations:";
            // 
            // totalBook
            // 
            this.totalBook.AllowDrop = true;
            this.totalBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalBook.Location = new System.Drawing.Point(935, 402);
            this.totalBook.Name = "totalBook";
            this.totalBook.Size = new System.Drawing.Size(93, 25);
            this.totalBook.TabIndex = 10;
            // 
            // ReceptionistHomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1040, 770);
            this.Controls.Add(this.totalBook);
            this.Controls.Add(this.bookCount);
            this.Controls.Add(this.buttonDateFilter);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTodaysReservations);
            this.Controls.Add(this.dataGridViewTodaysReservations);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "ReceptionistHomeForm";
            this.Text = "ReceptionistHomeForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodaysReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTodaysReservations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelTodaysReservations;
        private System.Windows.Forms.Button buttonCustomerDetails;
        private System.Windows.Forms.Button buttonRoomDetails;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalRoomLabel;
        private System.Windows.Forms.Label labelDeluxe;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Button buttonDateFilter;
        private System.Windows.Forms.Label bookCount;
        private System.Windows.Forms.Label totalBook;
        private System.Windows.Forms.Label totalRooms;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button buttonLogOut;
    }
}