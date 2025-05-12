using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Flight
    {

        public int Flight_ID { get; set; }
        public Airline Airline_ID { get; set; }
        public string Departure_City { get; set; }
        public string Destination_City { get; set; }
        public DateTime Departure_Time { get; set; }
        public DateTime Arrival_Time { get; set; }
        public string Flight_Status { get; set; }
        public int Gate_Number { get; set; }

        public List<Passenger> Passengers { get; set; }


        public Flight(Airline airline_ID, string departure_City, string destination_City,
            DateTime departure_Time, DateTime arrival_Time,
            string flight_Status, int gate_Number, List<Passenger> passengers)
        {
            Airline_ID = airline_ID;
            Departure_City = departure_City;
            Destination_City = destination_City;
            Departure_Time = departure_Time;
            Arrival_Time = arrival_Time;
            Flight_Status = flight_Status;
            Gate_Number = gate_Number;
            Passengers = passengers;
        }

    }
}
