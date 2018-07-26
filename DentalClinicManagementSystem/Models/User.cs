using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Threading;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class User : Person, IUser
    {
        [DisplayName("Username")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Invalid username length.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Invalid password length.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [DisplayName("Security Question No. 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public string SecurityQuestion1 { get; set; }

        [DisplayName("Security Question No. 2")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public string SecurityQuestion2 { get; set; }

        [DisplayName("Security Question No. 3")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public string SecurityQuestion3 { get; set; }

        [DisplayName("Answer")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide an answer to question.")]
        public string Answer1 { get; set; }

        [DisplayName("Answer")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide an answer to question.")]
        public string Answer2 { get; set; }

        [DisplayName("Answer")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide an answer to question.")]
        public string Answer3 { get; set; }
    }
}