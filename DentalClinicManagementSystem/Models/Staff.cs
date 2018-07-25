using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public sealed class Staff : Employee, IStaff
    {
        [DisplayName("Position")]
        public Position Position { get; set; }
    }
}