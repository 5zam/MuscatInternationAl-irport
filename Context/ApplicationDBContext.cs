using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace AirportManagementSystem.Cotext
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MuscatAirport_DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        public DbSet<Airline> Airlines_tb { get; set; }
        public DbSet<AirportOfficer> AirportOfficer_tb { get; set; }
        public DbSet<Baggage> Baggage_tb { get; set; }
        public DbSet<Flight> Flight_tb { get; set; }
        public DbSet<Gate> Gate_tb { get; set; }
        public DbSet<Passenger> Passenger_tb { get;set; }
        public DbSet<SecurityCheckpoint> SecurityCheckpoint_tb { get; set; }
        public DbSet<Terminal> Terminal_tb { get; set; }


    }
}
