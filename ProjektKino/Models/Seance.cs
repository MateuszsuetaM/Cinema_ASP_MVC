using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektKino.Models
{
    public class Seance
    {
        [Key]
        public int seanceId { get; set; }
        public DateTime start { get; set; }
        public double length { get; set; }
        public int movieId { get; set; }
        public int hallId { get; set; }
    }
}