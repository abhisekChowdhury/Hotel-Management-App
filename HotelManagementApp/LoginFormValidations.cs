using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerReservationCodeFirstFromDB;

namespace HotelManagementApp
{
    public static class LoginFormValidations
    {
        public static String GetEmployeeStatus(this Employee employee)
        {
            using (HotelManagementSystemEntities context = new HotelManagementSystemEntities())
            {
                context.Database.Log = (s => Debug.Write(s));

                Employee auth = context.Employees.Find(employee.EmployeeId);

                if (auth != null)
                {
                    UserSession.userID = auth.EmployeeId;
                    UserSession.userName = auth.EmployeeName.Trim();
                    return auth.Role.ToString().Trim();
                }
                else
                {
                    return "";
                }
            }


        }
    }
}
