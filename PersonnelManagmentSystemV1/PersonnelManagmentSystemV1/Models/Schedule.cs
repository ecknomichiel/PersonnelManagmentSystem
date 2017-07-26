using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonnelSystem.Models
{
    public class Schedule
    {
        private ApplicationUser employee = new ApplicationUser();

        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual ApplicationUser Employee 
        {
            get { return employee; } 
            set {SetUser(value);}
        }
        private void SetUser(ApplicationUser value)
        {
            if (value != null && value.IsEmployee)
            {
                employee = value;
            }
        }
    }
}