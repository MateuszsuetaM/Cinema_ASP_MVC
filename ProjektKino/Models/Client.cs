using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektKino.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "uzupełnij pole \"imię\"")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "uzupełnij pole \"nazwisko\"")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "uzupełnij pole \"email\"")]
        [Display(Name = "Adres email")]
        public string Address { get; set; }


    }

}