using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Branch : Model, IBranch
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Branch name is required.")]
        [StringLength(32)]
        [Index(IsUnique=true)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Branch Address is required.")]
        public string Address { get; set; }
    }
}