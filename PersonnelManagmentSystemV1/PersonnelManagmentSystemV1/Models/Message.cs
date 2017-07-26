using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonnelSystem.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public virtual JobOpening JobOpening { get; set; }
        public virtual ApplicationUser Sender { get; set; }
        public virtual ApplicationUser Recipient { get; set; }
    }
}