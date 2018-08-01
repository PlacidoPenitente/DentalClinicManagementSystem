namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SecurityQuestion : Model, ISecurityQuestion
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Question is required.")]
        [MaxLength(255, ErrorMessage = "Question is too long.")]
        [Index(IsUnique = true)]
        public string Question { get; set; }
    }
}