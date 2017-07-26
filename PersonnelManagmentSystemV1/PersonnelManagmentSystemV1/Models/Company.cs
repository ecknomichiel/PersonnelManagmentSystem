using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonnelSystem.Models;

namespace PersonnelSystem.Models
{
    public class Company
    {
        private ICompanyContext context;

        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<ApplicationUser> Employees { get; set; }

        public Company(ICompanyContext externalContext)
        {
            context = externalContext;
        }

        public Company(): this(new PersonnelSystem.DataAccess.ApplicationDbContext())
        {}
    }

    public interface ICompanyContext
    {
        Company GetCompanyById(int id);
    }
}