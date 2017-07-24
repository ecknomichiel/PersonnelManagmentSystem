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
        public string Name { get; set; }
        public ApplicationUser Manager { get; set; }

        public virtual ICollection<ApplicationUser> Employees { get; set; }
        public virtual ICollection<JobOpening> JobOpenings { get; set; }
        public virtual ICollection<Information> Informations { get; set; }
    }


}