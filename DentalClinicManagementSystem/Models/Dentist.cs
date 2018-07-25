using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public sealed class Dentist : Employee, IDentist
    {
        [DisplayName("Commission Rate")]
        public float CommissionRate { get; set; }

        [DisplayName("Specialization")]
        public string Specialization { get; set; }
    }
}