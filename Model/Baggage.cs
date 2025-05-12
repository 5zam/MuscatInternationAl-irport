using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Baggage
    {
        public int Baggage_ID { get; set; }
        public int Passenger_ID { get; set; }
        public Passenger Passenger { get; set; }

        public double Weight { get; set; }
        public string Tracking_Number { get; set; }


        public Baggage(int passenger_ID, Passenger passenger, double weight, string tracking_Number)
        {
            Passenger_ID = passenger_ID;
            Passenger = passenger;
            Weight = weight;
            Tracking_Number = tracking_Number;
        }

    }
}
