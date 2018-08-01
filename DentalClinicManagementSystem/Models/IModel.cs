namespace DentalClinicManagementSystem.Models
{
    using System;

    public interface IModel
    {
        int Id { get; set; }

        DateTime DateAdded { get; set; }

        DateTime DateModified { get; set; }

        Status Status { get; set; }
    }
}
