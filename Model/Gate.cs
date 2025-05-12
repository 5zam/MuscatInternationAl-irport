using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Gate
    {
       public int Gate_ID { get; set; }
        public int Terminal_ID { get; set; }
        public Terminal Terminal { get; set; }
        public int Airline_ID { get; set; }
        public Airline Airline { get; set; }
        public string Gate_Number { get; set; }
        public string Availability_Status { get; set; }

        public Gate(int terminal_ID, Terminal terminal, int airline_ID,
           Airline airline, string gate_Number, string availability_Status)
        {
            Terminal_ID = terminal_ID;
            Terminal = terminal;
            Airline_ID = airline_ID;
            Airline = airline;
            Gate_Number = gate_Number;
            Availability_Status = availability_Status;
        }


    }
}
