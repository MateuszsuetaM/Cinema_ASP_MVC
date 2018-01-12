using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektKino.Models
{
    public class Hall
    {
        [Key]
        public int hallId { get; set; }
        public int typ { get; set; }
    }
}