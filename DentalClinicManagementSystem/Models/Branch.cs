namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public sealed class Branch : Model, IBranch
    {
        [DisplayName("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required.")]
        [MaxLength(255, ErrorMessage = "Name is too long.")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [DisplayName("Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required.")]
        [MaxLength(255, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }
    }
}