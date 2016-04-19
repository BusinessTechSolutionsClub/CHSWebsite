using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CHS.Models
{
    public class HoursOfOperation
    {
        public int id { get; set; }
        [DisplayName("Day of Week")]
        public string dayOfWeek { get; set; }
        [DisplayName("Open Time")]
        public string openTime { get; set; }
        [DisplayName("Close Time")]
        public string closeTime { get; set; }
        [DisplayName("Status")]
        public string status { get; set; }
    }
}