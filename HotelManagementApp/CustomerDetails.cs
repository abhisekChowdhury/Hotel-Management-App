using CustomerReservationCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();

            this.Text = "Customer Details Form";

            this.Load += CustomerDetails_Load;

            //Event Click Listeners for all the buttons in the form
            listBoxCustomerDetails.SelectedIndexChanged += ListBoxCustomerDetails_SelectedIndexChanged;

            buttonUpdateCustomer.Click += ButtonUpdateCustomer_Click;

            buttonDeleteCustomer.Click += ButtonDeleteCustomer_Click;

            buttonAddCustomer.Click += buttonAddCustomer_Click;


        }
        /// <summary>
        /// Adding a new customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBoxCustomerName.Text.Trim(),
                LastName = textBoxCustomerLastName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim(),
                BillingAddress = textBoxBillingAddress.Text.Trim(),
                DOB = dateOfBirthElement.Value

            };


            // updating the db

            if (Controller<HotelManagementSystemEntities, Customer>.AddEntity(customer) == null)
            {
                MessageBox.Show("Cannot book the reservation to database");
                return;
            }

            //load the staff details form again
            CustomerDetails_Load(sender, e);
        }


        /// <summary>
        /// Event handler for delete button on Customer Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!(listBoxCustomerDetails.SelectedItem is Customer customer))
            {
                MessageBox.Show("Customer to be updated must be selected");
                return;
            }

            // updates the entity

            customer.FirstName = textBoxCustomerName.Text.Trim();
            customer.LastName = textBoxCustomerLastName.Text.Trim();


            //validations
            if (customer.FirstName.Trim() == "" || customer.LastName.Trim() == "")
            {
                MessageBox.Show("Customer information is missing.");
                return;
            }

            //delete the item in the database
            Controller<HotelManagementSystemEntities, Customer>.DeleteEntity(customer);

            MessageBox.Show("Customer deleted!!");

            //load the staff details form again
            CustomerDetails_Load(sender, e);

        }

        /// <summary>
        /// Event handler for update button on Customer Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!(listBoxCustomerDetails.SelectedItem is Customer customer))
            {
                MessageBox.Show("Customer to be updated must be selected");
                return;
            }

            // update the entity

            customer.FirstName = textBoxCustomerName.Text.Trim();
            customer.LastName = textBoxCustomerLastName.Text.Trim();
            customer.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            customer.BillingAddress = textBoxBillingAddress.Text.Trim();
            customer.DOB = dateOfBirthElement.Value;

            //validations
            if (customer.FirstName.Trim() == "" || customer.LastName.Trim() == "")
            {
                MessageBox.Show("Customer information is missing.");
                return;
            }

            // now update the db

            if (Controller<HotelManagementSystemEntities, Customer>.UpdateEntity(customer) == false)
            {
                MessageBox.Show("Cannot update customer details to database");
                return;
            }

            MessageBox.Show("Customer details updated!!");

            //Reloading the form so it doesn't close after an action is taken
            CustomerDetails_Load(sender, e);


        }

        /// <summary>
        /// Event handler for add button for Customer table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBoxCustomerName.Text.Trim(),
                LastName = textBoxCustomerLastName.Text.Trim(),
            };

            //validations
            if (customer.FirstName.Trim() == "" || customer.LastName.Trim() == "")
            {
                MessageBox.Show("Customer information is missing.");
                return;
            }

            //update the database
            if (Controller<HotelManagementSystemEntities, Customer>.AddEntity(customer) == null)
            {
                MessageBox.Show("Cannot add customer to the database!!");
                return;
            }

            MessageBox.Show("New Customer added!!");

            //load the staff details form again
            CustomerDetails_Load(sender, e);

        }


        /// <summary>
        /// Displaying data into the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxCustomerDetails.SelectedItem is Customer customer))
                return;
            textBoxCustomerName.Text = customer.FirstName;
            textBoxCustomerLastName.Text = customer.LastName;
            textBoxPhoneNumber.Text = customer.PhoneNumber.Trim();
            textBoxBillingAddress.Text = customer.BillingAddress.Trim();
            dateOfBirthElement.Value = customer.DOB.GetValueOrDefault();
        }

        /// <summary>
        /// Child form, on load. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerDetails_Load(object sender, EventArgs e)
        {

            //binding the listbox of customer to the Customer table
            listBoxCustomerDetails.DataSource = Controller<HotelManagementSystemEntities, Customer>.SetBindingList();

            textBoxCustomerName.ResetText();
            textBoxCustomerLastName.ResetText();
            textBoxBillingAddress.ResetText();
            textBoxPhoneNumber.ResetText();

            // no customer is selected to start
            listBoxCustomerDetails.SelectedIndex = -1;
        }

    }
}

