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
    public partial class ReceptionistHomeForm : Form
    {
        private HotelManagementSystemEntities context;

        public ReceptionistHomeForm()
        {
            InitializeComponent();

            context = new HotelManagementSystemEntities();
            context.Database.Log = (s => Debug.Write(s));

            context.SaveChanges();
            //Setting configuration on Buttons
            AddReservation addNewReservation = new AddReservation();
            buttonReservations.Click += (s, e) => AddOrUpdateForm<Reservation>(dataGridViewTodaysReservations, addNewReservation);

            RoomDetails updateRooms = new RoomDetails();
            buttonRoomDetails.Click += (s, e) => AddOrUpdateForm<Reservation>(dataGridViewTodaysReservations, updateRooms);

            //Manage Customers Button
            ManageCustomers addNewCustomer = new ManageCustomers();
            buttonCustomerDetails.Click += (s, e) => AddOrUpdateForm<Customer>(dataGridViewTodaysReservations, addNewCustomer);

            buttonLogOut.Click += (s, e) => LogOut();
            buttonDateFilter.Click += (s, e) => FilterByDate();


            this.Load += MainForm_Load;

        }
        

        /// <summary>
        /// Return to Log In form
        /// </summary
        private void LogOut()
        {
            this.Hide();
            LoginForm logOut = new LoginForm();
            logOut.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Filter reservation datagrid view by Datatime picker
        /// </summary
        private void FilterByDate()
        {
            DateTime filter = dateCheckIn.Value;
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

            dataGridViewTodaysReservations.DataSource = roomAll.ToList();
            totalBook.Text = dataGridViewTodaysReservations.Rows.Count.ToString();

        }

        /// <summary>
        /// Load all feature to Repectionist Home Room
        /// </summary
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView<Room>(dataGridView1, "Reservations", "RoomType");
            InitializeDataGridViewRegistration<Reservation>(dataGridViewTodaysReservations, "Employee", "Customer", "Room");

            userNameLabel.Text = UserSession.userName;

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
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.AllowUserToDeleteRows = false;
            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);
            // create a binding list and set the DataSource

            var list = Controller<HotelManagementSystemEntities, Room>.GetEntitiesWithIncluded("RoomType").ToList();

            var roomAll = from room in list
                          where room.RoomStatus.Contains("Available")
                          select new
                          {
                              ID = room.RoomId,
                              Type = room.RoomType.Name,
                              Price = room.RoomType.Price,
                              Beds = room.RoomType.NumberOfBeds
                          };

            gridView.DataSource = roomAll.ToList();

            //Get the number of available room.
            totalRooms.Text = gridView.Rows.Count.ToString();
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


        /// <summary>
        /// Generic method to load a table and set it to a BindingList for use
        /// by DataGridView.
        /// 
        /// Can be used to reload tables from db. This is done in the generic
        /// addupdate form processing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private BindingList<T> SetBindingList<T>() where T : class
        {
            DbSet<T> dbSet = context.Set<T>();
            dbSet.Load();
            BindingList<T> list = dbSet.Local.ToBindingList<T>();
            return list;
        }

        /// <summary>
        /// Staff member can't delete the reservation, so only admin can delete the reservation
        /// Display information of reservation by date
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void InitializeDataGridViewRegistration<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
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

            //Get the number of reservation by date
            totalBook.Text = gridView.Rows.Count.ToString();
        }


        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitializeDataGridViewRegistration<Reservation>(dataGridViewTodaysReservations, "Employee", "Customer", "Room");
                InitializeDataGridView<Room>(dataGridView1, "Reservations", "RoomType");                
            }
            form.Hide();
        }

    }
}
