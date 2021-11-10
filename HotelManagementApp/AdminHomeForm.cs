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
using System.Diagnostics;
using System.Data.Entity;


namespace HotelManagementApp
{
    public partial class AdminHomeForm : Form

    {

        private HotelManagementSystemEntities context;

        public AdminHomeForm()
        {
            InitializeComponent();

            //creating a context
            context = new HotelManagementSystemEntities();

            //database logging
            context.Database.Log = (s => Debug.Write(s));

            //Creating form object and loading it on button click
            StaffDetails staffDetails = new StaffDetails();
            buttonStaffDetails.Click += (s, e) => StaffDetailsForm<Reservation>(dataGridAdminTodaysReservations, staffDetails);

            AddReservation addReservation = new AddReservation();
            buttonReservations.Click += (s, e) => AddReservationForm<Reservation>(dataGridAdminTodaysReservations, addReservation);

            //CustomerDetailsButton
            CustomerDetails customerDetails = new CustomerDetails();
            buttonCustomerDetails.Click += (s, e) => CustomerDetailsForm<Reservation>(dataGridAdminTodaysReservations, customerDetails);

            //RoomDetailsButton
            RoomDetailsAdmin roomDetailsAdmin = new RoomDetailsAdmin();
            buttonRoomDetails.Click += (s, e) => RoomDetailsAdmin<RoomType>(dataGridAdminTodaysReservations, roomDetailsAdmin);

            buttonDateFilter.Click += ButtonDateFilter_Click;

            buttonLogOut.Click += ButtonLogOut_Click;

            context.SaveChanges();

            //method call on loading main form
            this.Load += MainForm_Load;
        }

        /// <summary>
        /// This fires up the Room Details form for the Administrator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="form"></param>
        private void RoomDetailsAdmin<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();


            if (result == DialogResult.OK)
            {
                InitializeDataGridViewReservations<Room>(dataGridAdminTodaysReservations, "Reservations", "RoomType");


            }

            form.Hide();
        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// This one in particular is used for displaying customer details on the admin form.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void CustomerDetailsForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();


            if (result == DialogResult.OK)
            {
                InitializeDataGridViewReservations<Room>(dataGridAdminTodaysReservations, "Reservations", "RoomType");


            }

            form.Hide();

        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Method to filter reservations by a selected date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDateFilter_Click(object sender, EventArgs e)
        {

            DateTime filter = dateCheckIn.Value;

            //query to select all reservations on a particular date
            var bookings = context.Reservations.Where(x => DbFunctions.TruncateTime(x.CheckInDate) == filter.Date);

            //query to select required room details from the previous filtered reservations
            var roomAll = from booking in bookings
                          select new
                          {
                              ID = booking.ReservationId,
                              Customer = booking.Customer.FirstName.Trim() + " " + booking.Customer.LastName.Trim(),
                              RoomId = booking.RoomId,
                              Type = booking.Room.RoomType.Name,
                              CheckIn = booking.CheckInDate,
                              CheckOut = booking.CheckOutDate
                          };

            //setting datasource of the datagridView
            dataGridAdminTodaysReservations.DataSource = roomAll.ToList();

            //Method call to calculate revenue on a particular date
            CalculateRevenue();
        }


        /// <summary>
        /// Method for initializing datagrids on loading main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

            InitializeDataGridViewRoomInfo<Room>(dataGridViewAdminRoomInformation, "Reservations", "RoomType");
            InitializeDataGridViewReservations<Reservation>(dataGridAdminTodaysReservations, "Employee", "Customer", "Room");

            //method call to generate revenue every time the datagrids are initialized
            CalculateRevenue();
        }

        /// <summary>
        /// Common generic method to initialize datagridview controls. Allows users to add and delete data,
        /// sets the datasource, autosizes the control to the columns.
        /// <para>
        /// A list of columns to hide is an optional parameter. No error checking is done on this.
        /// </para>
        /// <para>
        /// We could use a form to delete items, but easy to use gridview for this, so set up 
        /// UserDeleted event.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="gridView">DataGridView to be initialized</param>
        /// <param name="navProperties">Columns to be hidden in the DataGridView</param>
        private void InitializeDataGridViewRoomInfo<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource

            var list = Controller<HotelManagementSystemEntities, Room>.GetEntitiesWithIncluded("RoomType").ToList();


            var rooms = context.Rooms.Where(x => x.RoomStatus == "Available").ToList();

            var roomAll = from room in rooms
                          select new
                          {
                              ID = room.RoomId,
                              Type = room.RoomType.Name,
                              Price = room.RoomType.Price,
                              Beds = room.RoomType.NumberOfBeds
                          };

            gridView.DataSource = roomAll.ToList();

            // columns are autocreated, but skip the navigation properties
            // this MUST come after DataSource is set
            /*
            foreach (string column in navProperties)
                gridView.Columns[column].Visible = false;

            */


            //totalRooms.Text = gridView.Rows.Count.ToString();

        }

        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void GridView_DataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        private void InitializeDataGridViewReservations<T>(DataGridView gridView, params string[] navProperties) where T : class
        {

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource

            DateTime filter = DateTime.Now;

            var bookings = context.Reservations.Where(x => DbFunctions.TruncateTime(x.CheckInDate) == filter.Date);

            var roomAll = from booking in bookings
                          select new
                          {
                              ID = booking.ReservationId,
                              Customer = booking.Customer.FirstName.Trim() + " " + booking.Customer.LastName.Trim(),
                              RoomId = booking.RoomId,
                              Type = booking.Room.RoomType.Name,
                              CheckIn = booking.CheckInDate,
                              CheckOut = booking.CheckOutDate
                          };

            gridView.DataSource = roomAll.ToList();
        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void StaffDetailsForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();


            if (result == DialogResult.OK)
            {
                InitializeDataGridViewReservations<Room>(dataGridAdminTodaysReservations, "Reservations", "RoomType");


            }

            form.Hide();

        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddReservationForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();


            if (result == DialogResult.OK)
            {
                InitializeDataGridViewReservations<Reservation>(dataGridView, "Reservations", "RoomType");

            }

            form.Hide();

        }

        private void CalculateRevenue()
        {
            //today's date
            DateTime today = DateTime.Today;

            //Check In Date
            DateTime filter = dateCheckIn.Value;

            //date seven days ago
            DateTime sevenDaysEarlier = today.AddDays(-7);

            //join query on Rooms and reservations to get selected rooms having checkout date in the past week
            var selectedRooms = context.Reservations.Join(context.Rooms,
                                            reservation => reservation.RoomId,
                                            room => room.RoomId,
                                            (reservation, room) => new
                                            {
                                                RoomID = reservation.RoomId,
                                                RoomTypeID = room.RoomTypeId,
                                                CheckOutDate = reservation.CheckOutDate,
                                                CheckInDate = reservation.CheckInDate
                                            })
                                            .Where(x => DbFunctions.TruncateTime(x.CheckInDate) == filter.Date);


            //join query on Rooms and RoomTypes to get prices of selected rooms
            var priceList = selectedRooms.Join(context.RoomTypes,
                                                room => room.RoomTypeID,
                                                roomType => roomType.RoomTypeId,
                                                (room, roomType) => new
                                                {
                                                    RoomID = room.RoomID,
                                                    CheckOutDate = room.CheckOutDate,
                                                    CheckInDate = room.CheckInDate,
                                                    RoomPrice = roomType.Price
                                                });

            //calculating total price using foreach
            double sum = 0;
            foreach (var item in priceList)
            {
                sum += item.RoomPrice * ((item.CheckOutDate - item.CheckInDate).TotalDays);
            }

            //setting text box with appropriate data
            textBoxRevenue.Text = sum.ToString("C");


        }




    }
}
