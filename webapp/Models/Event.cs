namespace webapp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        [Column("id.event")]
        public int id_event { get; set; }

        [Column("id.building")]
        public int? id_building { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        [Column("id.artist")]
        public int? id_artist { get; set; }

        [Column("id.etype")]
        public int id_etype { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Building Building { get; set; }

        public virtual Event_Type Event_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
