using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class HoursOfOperation
    {
        public int id { get; set; }
        public string dayOfWeek { get; set; }
        public string openTime { get; set; }
        public string closeTime { get; set; }
        public string status { get; set; }
    }
}