using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerReservationCodeFirstFromDB;
using EFControllerUtilities;

namespace HotelManagementApp
{
    public partial class StaffDetails : Form
    {

        public StaffDetails()
        {
            InitializeComponent();

            this.Text = "Staff Details Form";

            this.Load += StaffDetails_Load;

            listBoxEmployeeDetails.SelectedIndexChanged += ListBoxEmployeeDetails_SelectedIndexChanged;

            buttonAddEmployee.Click += ButtonAddEmployee_Click;

            buttonUpdateEmployee.Click += ButtonUpdateEmployee_Click;

            buttonDeleteEmployee.Click += ButtonDeleteEmployee_Click;




        }
        /// <summary>
        /// Event handler for delete button on Employee Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (!(listBoxEmployeeDetails.SelectedItem is Employee employee))
            {
                MessageBox.Show("Employee to be updated must be selected");
                return;
            }

            // update the entity

            employee.EmployeeName = textBoxEmployeeName.Text.Trim();
            employee.Role = comboBoxStaffRole.Text;


            //validations
            if (employee.EmployeeName.Trim() == "" || employee.Role == "")
            {
                MessageBox.Show("Employee information is missing.");
                return;
            }

            //delete the item in the database
            Controller<HotelManagementSystemEntities, Employee>.DeleteEntity(employee);

            MessageBox.Show("Employee deleted!!");

            //load the staff details form again
            StaffDetails_Load(sender, e);

        }

        /// <summary>
        /// Event handler for update button on Employee Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (!(listBoxEmployeeDetails.SelectedItem is Employee employee))
            {
                MessageBox.Show("Employee to be updated must be selected");
                return;
            }

            // update the entity

            employee.EmployeeName = textBoxEmployeeName.Text.Trim();
            employee.Role = comboBoxStaffRole.Text.Trim();


            //validations
            if (employee.EmployeeName.Trim() == "" || employee.Role == "")
            {
                MessageBox.Show("Employee information is missing.");
                return;
            }

            // now update the db

            if (Controller<HotelManagementSystemEntities, Employee>.UpdateEntity(employee) == false)
            {
                MessageBox.Show("Cannot update employee details to database");
                return;
            }

            MessageBox.Show("Employee details updated!!");

            //load the staff details form again
            StaffDetails_Load(sender, e);


        }

        /// <summary>
        /// Event handler for add button for Employee table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeName = textBoxEmployeeName.Text.Trim(),
                Role = comboBoxStaffRole.Text.Trim()
            };

            //validations
            if (employee.EmployeeName.Trim() == "" || employee.Role.Trim() == "")
            {
                MessageBox.Show("Employee information is missing.");
                return;
            }

            //update the database
            if (Controller<HotelManagementSystemEntities, Employee>.AddEntity(employee) == null)
            {
                MessageBox.Show("Cannot add employee to the database!!");
                return;
            }

            MessageBox.Show("New Employee added!!");

            //load the staff details form again
            StaffDetails_Load(sender, e);

        }

        private void ListBoxEmployeeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxEmployeeDetails.SelectedItem is Employee employee))
                return;
            textBoxEmployeeName.Text = employee.EmployeeName;
            comboBoxStaffRole.Text = employee.Role;
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {

            //binding the listbox of employees to the Employees table
            listBoxEmployeeDetails.DataSource = Controller<HotelManagementSystemEntities, Employee>.SetBindingList();

            textBoxEmployeeName.Text = "";
            comboBoxStaffRole.Text = "";

            // no employee is selected to start
            listBoxEmployeeDetails.SelectedIndex = -1;
        }



    }
}
