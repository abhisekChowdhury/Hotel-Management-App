using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerReservationCodeFirstFromDB;
using EFControllerUtilities;



namespace HotelManagementApp
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            buttonReceptionist.Click += ButtonReceptionist_Click;
            buttonAdmin.Click += ButtonAdmin_Click;

        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeId = Byte.Parse(textBoxUsername.Text)
            };

            if (textBoxUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username!");
            }

            else
            {
                if (employee.GetEmployeeStatus() == "Administrator")
                {
                    this.Hide();
                    AdminHomeForm adminHomeForm = new AdminHomeForm();
                    adminHomeForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username!");
                }
            }

        }

        private void ButtonReceptionist_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee()
            {
                EmployeeId = Byte.Parse(textBoxUsername.Text)
            };

            if (textBoxUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username!");
            }
            else
            {
                if (employee.GetEmployeeStatus() == "Staff")
                {

                    this.Hide();
                    ReceptionistHomeForm receptionistHomeForm = new ReceptionistHomeForm();
                    receptionistHomeForm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username!");
                }
            }
        }
    }
}
