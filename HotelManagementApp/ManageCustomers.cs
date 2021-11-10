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
    public partial class ManageCustomers : Form
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string billingAddress;

        public ManageCustomers()
        {
            InitializeComponent();

            this.Load += (s, e) => ManageCustomers_Form();

            //Event listeners for all the buttons in the form
            buttonAddCustomer.Click += buttonAddCustomer_Click;

            buttonClear.Click += ButtonClear_Click;

            customerListBox.SelectedIndexChanged += (s, e) => GetCustomer();

            buttonUpdateCustomer.Click += buttonModifyCustomer_Click;

        }

        /// <summary>
        /// Updates customer details as prompted by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifyCustomer_Click(object sender, EventArgs e)
        {
            if (!(customerListBox.SelectedItem is Customer customer))
            {
                MessageBox.Show("Customer to be updated must be selected");
                return;
            }

            customer.FirstName = textBoxFirstName.Text.Trim();
            customer.LastName = textBoxLastName.Text.Trim();
            customer.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            customer.BillingAddress = textBoxBillingAddress.Text.Trim();
            customer.DOB = dateOfBirthElement.Value;

            // now update the db

            if (Controller<HotelManagementSystemEntities, Customer>.UpdateEntity(customer) == false)
            {
                MessageBox.Show("Cannot update customer details to database");
                return;
            }

            MessageBox.Show("Customer details updated!!");

            //load the staff details form again
            customerListBox.DataSource = Controller<HotelManagementSystemEntities, Customer>.SetBindingList();



        }


        /// <summary>
        /// Clears all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {

            // set all textboxes to blank
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            textBoxPhoneNumber.ResetText();
            textBoxBillingAddress.ResetText();
        }

        /// <summary>
        /// Allows users to add a new customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
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

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        /// Fetches customer information to display into a listbox
        /// </summary>
        private void GetCustomer()
        {
            if (!(customerListBox.SelectedItem is Customer customer))
                return;

            textBoxFirstName.Text = customer.FirstName.Trim();
            textBoxLastName.Text = customer.LastName.Trim();
            textBoxPhoneNumber.Text = customer.PhoneNumber.Trim();
            textBoxBillingAddress.Text = customer.BillingAddress.Trim();
            dateOfBirthElement.Value = customer.DOB.GetValueOrDefault();


        }

        /// <summary>
        /// ManageCustomers form, on load.
        /// </summary>
        private void ManageCustomers_Form()
        {

            customerListBox.DataSource = Controller<HotelManagementSystemEntities, Customer>.SetBindingList();

            //No course selected
            customerListBox.SelectedIndex = -1;

            // set all textboxes to blank
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            textBoxBillingAddress.ResetText();
            textBoxPhoneNumber.ResetText();
        }
    }
}
