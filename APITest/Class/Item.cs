using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Class
{
    public class Item
    {
        public DateTime timestamp { get; set; }
        public List<CarparkData> carpark_data { get; set; }
    }
}