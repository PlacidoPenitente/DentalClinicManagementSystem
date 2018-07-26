using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public sealed class Dentist : Employee, IDentist
    {
        [DisplayName("Commission Rate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Commission Rate is Required.")]
        public float CommissionRate { get; set; }

        [DisplayName("Specialization")]
        public string Specialization { get; set; }
    }
}