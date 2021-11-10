namespace CustomerReservationCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ReservationId { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckInDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckOutDate { get; set; }

        [StringLength(1)]
        public string FoodService { get; set; }

        public byte RoomId { get; set; }

        public byte EmployeeId { get; set; }

        public byte CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Room Room { get; set; }
    }
}
