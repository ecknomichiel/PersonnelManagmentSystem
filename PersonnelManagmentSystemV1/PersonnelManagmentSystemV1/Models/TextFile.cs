using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelManagmentSystemV1.Models
{
    public class TextFile
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "The description cannot be more than 100 characters")]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Category type of document")]
        public DocType Type { get; set; }

        public enum DocType
        { 
            CV,
            General
        }
    }
}