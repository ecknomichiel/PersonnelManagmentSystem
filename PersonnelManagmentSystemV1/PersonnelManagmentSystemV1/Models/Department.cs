using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelManagmentSystemV1.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        [Display(Name = "Department Name")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompName { get; set; }

        public virtual ICollection<ApplicationUser> Departments { get; set; }
    }
}