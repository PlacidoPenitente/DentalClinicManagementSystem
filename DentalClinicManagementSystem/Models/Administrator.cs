using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DentalClinicManagementSystem.Models
{
    public class Administrator : IModel, IUser
    {
        public int Id { get; set; }

        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

        [DisplayName("Date Modified")]
        public DateTime DateModified { get; set; }

        [DisplayName("Status")]
        public Status Status { get; set; }

        [DisplayName("Username")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Invalid username length.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        [Index(IsUnique=true)]
        public string Username { get; set; }

        [DisplayName("Password")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Invalid password length.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [DisplayName("Security Question No. 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public int SecurityQuestion1 { get; set; }

        [DisplayName("Security Question No. 2")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public int SecurityQuestion2 { get; set; }

        [DisplayName("Security Question No. 3")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Security Question is required.")]
        public int SecurityQuestion3 { get; set; }

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