using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{

    /*This class works as a store for the session opened after logging into the system.
    This class should use the set and get methods to obtain the credentials,
    but it will only be indicated as it should work.
    */
    class UserSession
    {
        public static byte userID = 0;
        public static string userName = "";

        /*       
             public static string userID
                {
                    get { return userID; }
                    set { userID = value; }
                }         
         */

    }
}
