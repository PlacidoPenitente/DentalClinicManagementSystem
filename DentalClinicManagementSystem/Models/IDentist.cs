namespace DentalClinicManagementSystem.Models
{
    public interface IDentist
    {
        int CommissionRate { get; set; }

        string Specialization { get; set; }
    }
}
