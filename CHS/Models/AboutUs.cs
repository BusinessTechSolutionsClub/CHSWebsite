using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [DisplayName("Content short description")]
        public string ContentShortDescription { get; set; }
        public string Content { get; set; }
    }
}