namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;

    public sealed class Staff : Employee, IStaff
    {
        [DisplayName("Position")]
        public Position Position { get; set; }
    }
}