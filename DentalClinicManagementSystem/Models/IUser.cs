namespace DentalClinicManagementSystem.Models
{
    public interface IUser
    {
        string Username { get; set; }

        string Password { get; set; }

        SecurityQuestion SecurityQuestion1 { get; set; }

        SecurityQuestion SecurityQuestion2 { get; set; }

        SecurityQuestion SecurityQuestion3 { get; set; }

        string Answer1 { get; set; }

        string Answer2 { get; set; }

        string Answer3 { get; set; }
    }
}