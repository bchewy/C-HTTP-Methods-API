using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Class
{
    public class Class2
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Class1> data { get; set; }
    }
}