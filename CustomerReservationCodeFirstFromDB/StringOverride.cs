using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReservationCodeFirstFromDB
{
	partial class Customer
	{
		/// <summary>
		/// Max length of customer name. Is used to set column size in HotelManagementSystemEntities.
		/// </summary>
		public const int CurtomerNameMaxLength = 50;
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return CustomerId + ": " + FirstName.Trim() + " " + LastName.Trim();
		}
	}


	partial class Room
	{
		/// <summary>
		/// Max length of customer name. Is used to set column size in HotelManagementSystemEntities.
		/// </summary>
		public const int CurtomerNameMaxLength = 50;
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "#: " + RoomId.ToString() + " " + (RoomType is null ? RoomTypeId.ToString() : RoomType.Name);
		}
	}

	partial class Employee
	{
		/// <summary>
		/// Max length of customer name. Is used to set column size in HotelManagementSystemEntities.
		/// </summary>
		public const int CurtomerNameMaxLength = 50;
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return EmployeeId + ": " + EmployeeName.Trim() + " -> Role: " + Role.Trim();
		}
	}


	partial class RoomType
	{
		/// <summary>
		/// Max length of customer name. Is used to set column size in HotelManagementSystemEntities.
		/// </summary>
		public const int CurtomerNameMaxLength = 50;
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name.Trim();
		}
	}
}