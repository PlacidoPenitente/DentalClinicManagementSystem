using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalClinicManagementSystem.Models
{
    public class Model : IModel
    {
        public int Id { get; set; }

        [DisplayName("Date Added")]
        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

        [DisplayName("Date Modified")]
        [DataType(DataType.DateTime)]
        public DateTime DateModified { get; set; }

        [DisplayName("Status")]
        public Status Status { get; set; }
    }
}