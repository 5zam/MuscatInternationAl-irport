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
    }
}
