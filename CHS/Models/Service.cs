using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class Service
    {
        public int Id { get; set; }
        [DisplayName("Service Name")]
        public string ServiceName { get; set; }
        [DisplayName("Service Description")]
        public string ServiceDescription { get; set; }
        public string Price { get; set; }
        [DisplayName("Estimated Time")]
        public string EstimatedTime { get; set; }
    }
}