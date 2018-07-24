using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Branch : IBranch
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}