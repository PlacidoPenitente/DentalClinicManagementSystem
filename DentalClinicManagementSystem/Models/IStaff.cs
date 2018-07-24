using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public interface IStaff : IEmployee
    {
        Position Position { get; set; }
    }
}