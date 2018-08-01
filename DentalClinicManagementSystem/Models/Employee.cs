namespace DentalClinicManagementSystem.Models
{
    using System.ComponentModel;

    public class Employee : User, IEmployee
    {
        [DisplayName("Branch")]
        public Branch Branch { get; set; }
    }
}