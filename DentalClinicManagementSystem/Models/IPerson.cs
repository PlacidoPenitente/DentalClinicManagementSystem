using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DentalClinicManagementSystem.Models
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
        DateTime Birthdate { get; set; }
        string Nationality { get; set; }
        string Religion { get; set; }
        string Address { get; set; }
        string TelephoneNo { get; set; }
        string MobileNo { get; set; }
        string Nickname { get; set; }
    }
}
