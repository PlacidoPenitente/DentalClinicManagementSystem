namespace DentalClinicManagementSystem.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Person : Model, IPerson
    {
        [DisplayName("First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required.")]
        [MaxLength(255, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        [MaxLength(255, ErrorMessage = "Middle Name is too long.")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required.")]
        [MaxLength(255, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [DisplayName("Birthdate")]
        [DisplayFormat(DataFormatString = "{0:MMMM' 'd', 'yyyy}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter your birthdate.")]
        public DateTime Birthdate { get; set; }

        [DisplayName("Nationality")]
        [MaxLength(255, ErrorMessage = "Nationality is too long.")]
        public string Nationality { get; set; }

        [DisplayName("Religion")]
        [MaxLength(255, ErrorMessage = "Religion is too long.")]
        public string Religion { get; set; }

        [DisplayName("Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required.")]
        [MaxLength(255, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

        [DisplayName("Telephone No.")]
        [Phone(ErrorMessage = "Invalid Telephone No.")]
        public string TelephoneNo { get; set; }

        [DisplayName("Mobile No.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile No. is required.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Please enter your 11-digit number.")]
        public string MobileNo { get; set; }

        [DisplayName("Nickname")]
        [MaxLength(255, ErrorMessage = "Nickname is too long.")]
        public string Nickname { get; set; }
    }
}