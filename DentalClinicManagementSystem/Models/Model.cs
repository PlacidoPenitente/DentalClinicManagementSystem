namespace DentalClinicManagementSystem.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Model : IModel
    {
        public int Id { get; set; }

        [DisplayName("Date Added")]
        [HiddenInput]
        public DateTime DateAdded { get; set; }

        [DisplayName("Date Modified")]
        [HiddenInput]
        public DateTime DateModified { get; set; }

        [DisplayName("Status")]
        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }
    }
}