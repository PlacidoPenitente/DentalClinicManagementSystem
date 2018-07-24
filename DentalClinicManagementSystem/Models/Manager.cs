using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public sealed class Manager : IUser
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Address { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Nickname { get; set; }
        public string Username { get; set; }
        public char[] Password { get; set; }
        public int SecurityQuestion1 { get; set; }
        public int SecurityQuestion2 { get; set; }
        public int SecurityQuestion3 { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
    }
}