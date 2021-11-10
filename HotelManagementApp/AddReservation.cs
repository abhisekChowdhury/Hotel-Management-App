using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EFControllerUtilities;
using CustomerReservationCodeFirstFromDB;

namespace HotelManagementApp
{
    public partial class AddReservation : Form
    {

        public int idRoom;
        public int idCustomer;
        public AddReservation()
        {
            InitializeComponent();

            this.Load += (s, e) => AddReservationForm_Load();

            buttonReserve.Click += ButtonAddReservation_Click;
            buttonClear.Click += ButtonClear_Click;

        }

        /// <summary>
        /// Clear information of reservation on text box
        /// </summary
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            //No course selected
            customerListBox.SelectedIndex = -1;
            roomListBox.SelectedIndex = -1;

            // set all textboxes to blank
            textBoxCustomer.ResetText();
            textBoxRoom.ResetText();

            idRoom = 0;
            idCustomer = 0;

        }

        /// <summary>
        /// Create a new reservation to DB
        /// </summary
        private void ButtonAddReservation_Click(object sender, EventArgs e)
        {

            //Create a new reservation object, and assign information 
            Reservation booking = new Reservation()
            {
                RoomId = (byte)(idRoom),
                EmployeeId = UserSession.userID,
                CustomerId = (byte)(idRoom),
                CheckInDate = dateCheckIn.Value,
                CheckOutDate = dateCheckOut.Value,
                FoodService = (checkFoodService.Checked ? "Y" : "N")
            };


            //Validity checks
            if (idRoom == 0)
            {
                MessageBox.Show("Before creating the reservation, Please choice a Room");
                return;
            }

            if (idCustomer == 0)
            {
                MessageBox.Show("Before creating the reservation, Please choice a Customer");
                return;
            }


            // updating the db
            if (Controller<HotelManagementSystemEntities, Reservation>.AddEntity(booking) == null)
            {
                MessageBox.Show("Cannot book the reservation to database");
                return;
            }
            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Get customer information from the listbox for a new reservation
        /// </summary
        private void GetCustomer()
        {
            if (!(customerListBox.SelectedItem is Customer customer))
                return;
            textBoxCustomer.Text = customer.FirstName.Trim() + " " + customer.LastName.Trim();
            idCustomer = customer.CustomerId;
        }

        /// <summary>
        /// Get room information from the listbox for a new reservation
        /// </summary
        private void GetRoom()
        {
            if (!(roomListBox.SelectedItem is Room room))
                return;
            textBoxRoom.Text = room.RoomId.ToString();
            idRoom = room.RoomId;
        }

        /// <summary>
        /// Load all feature to Add Reservtion child Room
        /// </summary
        private void AddReservationForm_Load()
        {
            customerListBox.SelectedIndexChanged -= (s, e) => GetCustomer();
            roomListBox.SelectedIndexChanged -= (s, e) => GetRoom();

            customerListBox.DataSource = Controller<HotelManagementSystemEntities, Customer>.SetBindingList();
            roomListBox.DataSource = Controller<HotelManagementSystemEntities, Room>.GetEntitiesWithIncluded("RoomType");

            //No course selected
            customerListBox.SelectedIndex = -1;
            roomListBox.SelectedIndex = -1;

            customerListBox.SelectedIndexChanged += (s, e) => GetCustomer();
            roomListBox.SelectedIndexChanged += (s, e) => GetRoom();

            // set all textboxes to blank
            textBoxCustomer.ResetText();
            textBoxRoom.ResetText();

            idRoom = 0;
            idCustomer = 0;

        }
    }
}
