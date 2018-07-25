using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Model : IModel
    {
        public int Id { get; set; }

        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

        [DisplayName("Date Modified")]
        public DateTime DateModified { get; set; }

        [DisplayName("Status")]
        public Status Status { get; set; }
    }
}