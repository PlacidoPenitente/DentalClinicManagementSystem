namespace DentalClinicManagementSystem.Models
{
    public interface IBranch : IModel
    {
        string Name { get; set; }

        string Address { get; set; }
    }
}