using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DentalClinicManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Staff> Staves { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public ApplicationDbContext() : base("dcmsdb")
        {
            
        }
    }
}