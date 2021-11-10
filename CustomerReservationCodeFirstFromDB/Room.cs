namespace CustomerReservationCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RoomId { get; set; }

        [Required]
        [StringLength(10)]
        public string RoomStatus { get; set; }

        public byte RoomTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
