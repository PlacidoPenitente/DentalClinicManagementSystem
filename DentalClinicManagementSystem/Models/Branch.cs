namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public sealed class Branch : Model, IBranch
    {
        [DisplayName("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Branch Name is required.")]
        [MaxLength(255, ErrorMessage = "Branch Name is too long.")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [DisplayName("Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Branch Address is required.")]
        [MaxLength(255, ErrorMessage = "Branch Address is too long.")]
        public string Address { get; set; }
    }
}