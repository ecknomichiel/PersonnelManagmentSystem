using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PersonnelSystem.Models;

namespace PersonnelSystem.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, ICompanyContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<PersonnelSystem.Models.Company> Companies { get; set; }

        public Company GetCompanyById(int id)
        {
            return Companies.SingleOrDefault(c => c.ID == id);
        }
    }
}