namespace DentalClinicManagementSystem.Models
{
    public interface IEmployee : IUser
    {
        Branch Branch { get; set; }
    }
}