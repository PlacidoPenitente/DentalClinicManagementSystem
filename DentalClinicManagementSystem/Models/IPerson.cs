namespace DentalClinicManagementSystem.Models
{
    using System;

    public interface IPerson
    {
        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        Gender Gender { get; set; }

        DateTime Birthdate { get; set; }

        string Nationality { get; set; }

        string Religion { get; set; }

        string Address { get; set; }

        string TelephoneNo { get; set; }

        string MobileNo { get; set; }

        string Nickname { get; set; }
    }
}
