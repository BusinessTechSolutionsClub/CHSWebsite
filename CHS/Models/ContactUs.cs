using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string Address { get; set; }
        [DisplayName("Cell phone number")]
        public string CellPhoneNumber { get; set; }
    }
}