using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Terminal
    {
        public int Terminal_ID { get; set; }
        public string Terminal_Name { get; set; }
        public double Capacity { get; set; }
        public string Location { get; set; }

        public List<Gate> Gates { get; set; }
        public List<SecurityCheckpoint> SecurityCheckpoints { get; set; }

        public Terminal(string terminal_Name, double capacity, string location) 
        {
            Terminal_Name = terminal_Name;
            Capacity = capacity;
            Location = location;
        }
    }
}
