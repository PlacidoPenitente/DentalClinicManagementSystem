using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentalClinicManagementSystem.Models;

namespace DentalClinicManagementSystem.ViewModels
{
    public class CreateDentistViewModel
    {
        private readonly ApplicationDbContext dbContext;

        public CreateDentistViewModel()
        {
            dbContext = new ApplicationDbContext();    
        }

        public int SelectedBranchId { get; set; }

        public Dentist Dentist { get; set; }

        public IEnumerable<SelectListItem> Branches => new SelectList(dbContext.Branches, "Id", "Name");
    }
}