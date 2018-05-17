namespace webapp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [Column("id.user")]
        public int id_user { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        //[Column("id.reservation")]
        //public int? id_reservation { get; set; }

        //public virtual Reservation Reservation { get; set; }
    }
}
