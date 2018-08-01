namespace DentalClinicManagementSystem.Models
{
    using System.Data.Entity;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("dcmsdb")
        {
        }
        
        public DbSet<Branch> Branches { get; }

        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }

        public DbSet<Staff> Staves { get; set; }

        public DbSet<Dentist> Dentists { get; set; }
    }
}