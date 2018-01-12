using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektKino.Models
{
    public class Reservation
    {
        [Key]
        public int orderId { get; set; }
        public int seanceId { get; set; }
        public int placesCount { get; set; }
        public string placesDict { get; set; }
        public int clientId { get; set; }
        public double amount { get; set; }
        public bool paid { get; set; }
    }
}