﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class Administrator : IModel, IUser
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int SecurityQuestion1 { get; set; }
        public int SecurityQuestion2 { get; set; }
        public int SecurityQuestion3 { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
    }
}