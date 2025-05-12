using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class SecurityCheckpoint
    {

        public int Checkpoint_ID { get; set; }
        public int Terminal_ID { get; set; }
        public Terminal Terminal { get; set; }

        public string Terminal_Name { get; set; }
        public int Passenger_Capacity { get; set; }
        public string Location { get; set; }

        
        public List<AirportOfficer> AirportOfficers { get; set; }


        public SecurityCheckpoint(int terminal_ID, Terminal terminal, string terminal_Name,
            int passenger_Capacity, string location,
            List<AirportOfficer> airportOfficers)
        {
            Terminal_ID = terminal_ID;
            Terminal = terminal;
            Terminal_Name = terminal_Name;
            Passenger_Capacity = passenger_Capacity;
            Location = location;
            AirportOfficers = airportOfficers;
        }
    }
}
