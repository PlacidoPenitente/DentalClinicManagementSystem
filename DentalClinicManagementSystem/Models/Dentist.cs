namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public sealed class Dentist : Employee, IDentist
    {
        [DisplayName("Commission Rate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Commission Rate is Required.")]
        [Range(1, 100, ErrorMessage = "Invalid commission rate value.")]
        public int CommissionRate { get; set; }

        [DisplayName("Specialization")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialization is Required.")]
        [MaxLength(255, ErrorMessage = "Specialization is too long.")]
        public string Specialization { get; set; }
    }
}