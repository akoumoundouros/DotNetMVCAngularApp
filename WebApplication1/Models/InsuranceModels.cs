using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InsuranceModels
    {
        public class Insurance
        {
            public int mortgage { get; set; }
            public int rent { get; set; }
            public int children { get; set; }
            public int debt { get; set; }
        }
    }
}