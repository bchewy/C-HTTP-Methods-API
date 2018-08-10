using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Class
{
    public class CarparkData
    {
        public List<CarparkInfo> carpark_info { get; set; }
        public string carpark_number { get; set; }
        public DateTime update_datetime { get; set; }
    }
}