using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string Price { get; set; }
        public string EstimatedTime { get; set; }
    }
}