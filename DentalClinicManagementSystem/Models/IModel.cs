using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagementSystem.Models
{
    public interface IModel
    {
        int Id { get; set; }
        DateTime DateAdded { get; set; }
        DateTime DateModified { get; set; }
        Status Status { get; set; }
    }
}
