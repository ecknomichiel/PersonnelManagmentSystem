using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelManagmentSystemV1.Models
{
    public class Information
    {
        [Key]
        public int ID { get; set; }
        public string Contents { get; set; }
        public bool Public { get; set; }
    }
}