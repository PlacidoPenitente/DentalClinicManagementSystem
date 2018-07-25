using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Employee : User, IEmployee
    {
        [DisplayName("Branch")]
        public Branch Branch { get; set; }
    }
}