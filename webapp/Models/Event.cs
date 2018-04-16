using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Event
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public int Id { get; set; }
        public int Descript { get; set; }
    }
}