using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Passenger
    {
        public int Passenger_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Passport_Number { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_Email { get; set; }

        public List<Flight> Flights { get; set; }
        public List<Baggage> Baggages { get; set; }

        public Passenger(string first_Name, string last_Name, DateTime date_Of_Birth,
            string gender, string nationality, string passport_Number, string contact_Phone
            , string contact_Email)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Date_Of_Birth = date_Of_Birth;
            Gender = gender;
            Nationality = nationality;
            Passport_Number = passport_Number;
            Contact_Phone = contact_Phone;
            Contact_Email = contact_Email;
        }

    }
}
