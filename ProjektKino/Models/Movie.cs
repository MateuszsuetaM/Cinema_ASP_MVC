using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektKino.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
        public string title { get; set; }
        public int length { get; set; }
    }
}