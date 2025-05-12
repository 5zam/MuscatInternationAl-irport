using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class Airline
    {
        public int AirlineID { get; set; }
        public string Name { get; set; }
        public int Contact_Number { get; set; }
        public string Contact_Email { get; set; }
        public string Representative { get; set; }

        public Airline(string name,int contactNumber, string contactEmail,string representative)
        {
            Name = name;
            Contact_Number = contactNumber;
            Contact_Email = contactEmail;
            Representative = representative;
        }
    }
}
