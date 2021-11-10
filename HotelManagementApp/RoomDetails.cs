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


    public partial class RoomDetails : Form
    {

        public RoomDetails()
        {
            InitializeComponent();

            buttonUpdate.Click += ButtonUpdate_Click;
            buttonBack.Click += ButtonBack_Click;

            this.Load += (s, e) => UpdateRoomForm_Load();

        }

        /// <summary>
        /// Close the Child form without modification
        /// </summary>  
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Assign the values from listbox to each textbox based on the selected room
        /// </summary>  
        private void GetRoom()
        {
            if (!(roomListBox.SelectedItem is Room room))
                return;

            //Asign values
            numberRoomTextBox.Text = room.RoomId.ToString();
            numberBedtextBox.Text = room.RoomType.NumberOfBeds.ToString();
            kindOfBedstextBo.Text = room.RoomType.BedSize.Trim();
            maxOccupationTextBox.Text = room.RoomType.NumberOfOccupants.ToString();
            priceTextBox.Text = room.RoomType.Price.ToString("C");

            typeRoomComboBox.SelectedIndex = (room.RoomType.RoomTypeId) - 1;

        }

        /// <summary>
        /// Update room information based on assigned room type
        /// </summary> 
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            Debug.WriteLine((typeRoomComboBox.SelectedIndex + 1).ToString());

            //Get the room type to assign the selected room
            RoomType type = typeRoomComboBox.SelectedItem as RoomType;


            //Asign new values to selected room
            if (roomListBox.SelectedItem is Room roomToUpdate)
            {
                roomToUpdate.RoomTypeId = type.RoomTypeId;
                roomToUpdate.RoomType = type;
            }
            else
            {
                MessageBox.Show("Select a room to Update");
                return;
            }

            //Update process to DB
            if (Controller<HotelManagementSystemEntities, Room>.UpdateEntity(roomToUpdate) == false)
            {
                MessageBox.Show("Cannot update room to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Load all feature to Update Room Child Form
        /// </summary>
        private void UpdateRoomForm_Load()
        {
            //Delete hand event to room list
            roomListBox.SelectedIndexChanged -= (s, e) => GetRoom();

            //Get information from Data Base and asign to DataGrid & ComboBox
            roomListBox.DataSource = Controller<HotelManagementSystemEntities, Room>.GetEntitiesWithIncluded("RoomType");
            InitializeDataGridView<RoomType>(typeRoomsdataGridView, "Rooms");
            var typeRoom = Controller<HotelManagementSystemEntities, RoomType>.GetEntities();

            typeRoomComboBox.DataSource = typeRoom.ToList();
            roomListBox.SelectedIndex = -1;

            //Asign hand event to room list
            roomListBox.SelectedIndexChanged += (s, e) => GetRoom();

        }



        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource            
            var list = Controller<HotelManagementSystemEntities, RoomType>.GetEntities();

            gridView.DataSource = list.ToList();
            // columns are autocreated, but skip the navigation properties
            // this MUST come after DataSource is set

            foreach (string column in navProperties)
                gridView.Columns[column].Visible = false;

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

    }

}
