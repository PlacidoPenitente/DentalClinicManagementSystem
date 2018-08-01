namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : Person, IUser
    {
        [DisplayName("Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        [MaxLength(255, ErrorMessage = "Username is too long.")]
        [MinLength(8, ErrorMessage = "Username is too short.")]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        [MaxLength(255, ErrorMessage = "Password is too long.")]
        [MinLength(8, ErrorMessage = "Password is too short.")]
        public string Password { get; set; }

        [DisplayName("Security Question No. 1")]
        public SecurityQuestion SecurityQuestion1 { get; set; }

        [DisplayName("Security Question No. 2")]
        public SecurityQuestion SecurityQuestion2 { get; set; }

        [DisplayName("Security Question No. 3")]
        public SecurityQuestion SecurityQuestion3 { get; set; }

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