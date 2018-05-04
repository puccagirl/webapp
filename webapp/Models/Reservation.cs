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
        public int? id_user { get; set; }
    }
}
