using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagementSystem.Model
{
    public class AirportOfficer
    {
        public int Officer_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_Email { get; set; }

        public List<SecurityCheckpoint> SecurityCheckpoints { get; set; }

        public AirportOfficer(string first_Name, string last_Name, string position, string department, string contact_Phone,
           string contact_Email, List<SecurityCheckpoint> securityCheckpoints)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Position = position;
            Department = department;
            Contact_Phone = contact_Phone;
            Contact_Email = contact_Email;
            SecurityCheckpoints = securityCheckpoints;
        }

    }
}
