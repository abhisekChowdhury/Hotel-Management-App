using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CustomerReservationCodeFirstFromDB
{
    public partial class HotelManagementSystemEntities : DbContext
    {
        public HotelManagementSystemEntities()
            : base("name=HotelManagementSystemConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillingAddress)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Role)
                .IsFixedLength();

            modelBuilder.Entity<Reservation>()
                .Property(e => e.FoodService)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomStatus)
                .IsFixedLength();

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<RoomType>()
                .Property(e => e.BedSize)
                .IsFixedLength();

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomType)
                .WillCascadeOnDelete(false);
        }
    }
}
