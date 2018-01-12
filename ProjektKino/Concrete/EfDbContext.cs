using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjektKino.Models;

namespace ProjektKino.Concrete
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() : base("DefaultConnection")
        { }
        public DbSet<Client> Client { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}