namespace CustomerReservationCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomType")]
    public partial class RoomType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RoomTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int Price { get; set; }

        public byte? NumberOfBeds { get; set; }

        [StringLength(10)]
        public string BedSize { get; set; }

        public byte? NumberOfOccupants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
