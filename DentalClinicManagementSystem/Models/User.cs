using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Threading;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class User : Person, IUser
    {
        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Passowrd")]
        public string Password { get; set; }

        [DisplayName("Security Question No. 1")]
        public int SecurityQuestion1 { get; set; }

        [DisplayName("Security Question No. 2")]
        public int SecurityQuestion2 { get; set; }

        [DisplayName("Security Question No. 3")]
        public int SecurityQuestion3 { get; set; }

        [DisplayName("Answer")]
        public string Answer1 { get; set; }

        [DisplayName("Answer")]
        public string Answer2 { get; set; }

        [DisplayName("Answer")]
        public string Answer3 { get; set; }
    }
}