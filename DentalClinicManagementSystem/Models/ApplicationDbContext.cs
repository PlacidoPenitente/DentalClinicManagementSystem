namespace DentalClinicManagementSystem.Models
{
    using System.Data.Entity;

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("dcmsdb")
        {
            
        }
    }
}