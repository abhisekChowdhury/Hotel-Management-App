using CustomerReservationCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class RoomDetailsAdmin : Form
    {
        public RoomDetailsAdmin()
        {
            InitializeComponent();

            //Evemts for Update, Back and Delete Buttons
            buttonUpdate.Click += ButtonUpdate_Click;
            buttonBack.Click += ButtonBack_Click;
            buttonDelete.Click += ButtonDelete_Click;
            
            //Loads the form
            this.Load += (s, e) => UpdateRoomForm_Load();

        }

        /// <summary>
        /// Triggers the delete button, with the capability of deleting a room entry from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!(roomListBox.SelectedItem is Room room))
            {
                MessageBox.Show("Room to be updated must be selected");
                return;
            }

            // update the entity

            room.RoomTypeId = Byte.Parse(numberRoomTextBox.Text.Trim());

            //delete the item in the database
            Controller<HotelManagementSystemEntities, Room>.DeleteEntity(room);

            MessageBox.Show("Room deleted!!");

            //load the staff details form again
            UpdateRoomForm_Load();
        }

        /// <summary>
        /// Closes the Room Details form
        /// </summary>  
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Assigning each text box with details from the selected item in the listbox
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

            //Updates database
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
        /// Displays room data into a ReadOnly GridView panel
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