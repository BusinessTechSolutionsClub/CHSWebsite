using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// James Comment 1

namespace CHS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public virtual ApplicationUser Users { get; set; }
        public string ApplicationUserId { get; set; }
         

        public virtual ICollection<AboutUs> AboutUs { get; set; }
        public virtual ICollection<HomePage>Home { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<AboutUs> HoursOfOperation { get; set; }
    }
}

//Testing push, Matthew
//Testing, Vika comment
//Dasril Comment 1