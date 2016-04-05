using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class Content
    {
        public int Id { get; set; }
        public int NavigationLinkId { get; set; }
        public string NavLinkDescription { get; set; }
        public string ContentDetails { get; set; }
    }
}