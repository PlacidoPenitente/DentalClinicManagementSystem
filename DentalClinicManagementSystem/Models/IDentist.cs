using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagementSystem.Models
{
    public interface IDentist
    {
        float CommissionRate { get; set; }
        string Specialization { get; set; }
    }
}
