using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Person : Model, IPerson
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        public Gender Gender { get; set; }

        [DisplayName("Birthdate")]
        public DateTime Birthdate { get; set; }

        [DisplayName("Nationality")]
        public string Nationality { get; set; }

        [DisplayName("Religion")]
        public string Religion { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Telephone No.")]
        public string TelephoneNo { get; set; }

        [DisplayName("Mobile No.")]
        public string MobileNo { get; set; }

        [DisplayName("Nickname")]
        public string Nickname { get; set; }
    }
}