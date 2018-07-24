using System.Collections;
using System.Collections.Generic;

namespace DentalClinicManagementSystem.Models
{
    public interface IBranch : IModel
    {
        Manager Manager { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }
}