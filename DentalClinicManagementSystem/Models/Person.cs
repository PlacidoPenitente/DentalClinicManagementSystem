using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalClinicManagementSystem.Models
{
    public class Person : Model, IPerson
    {
        [DisplayName("First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required.")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        public Gender Gender { get; set; }

        [DisplayName("Birthdate")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }

        [DisplayName("Nationality")]
        public string Nationality { get; set; }

        [DisplayName("Religion")]
        public string Religion { get; set; }

        [DisplayName("Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [DisplayName("Telephone No.")]
        [Phone]
        public string TelephoneNo { get; set; }

        [DisplayName("Mobile No.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile No. is required.")]
        [Phone]
        [StringLength(11,MinimumLength = 11, ErrorMessage = "Please enter your 11-digit number.")]
        public string MobileNo { get; set; }

        [DisplayName("Nickname")]
        public string Nickname { get; set; }
    }
}