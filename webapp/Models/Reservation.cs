namespace webapp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [Key]
        [Column("id.reservation")]
        public int id_reservation { get; set; }

        [Column("id.event")]
        public int? id_event { get; set; }

        [Column("id.user")]
        [StringLength(128)]
        public string id_user { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
