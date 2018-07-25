using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        int SecurityQuestion1 { get; set; }
        int SecurityQuestion2 { get; set; }
        int SecurityQuestion3 { get; set; }
        string Answer1 { get; set; }
        string Answer2 { get; set; }
        string Answer3 { get; set; }
    }
}