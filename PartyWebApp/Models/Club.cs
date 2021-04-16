using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Club
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string maxCapacity { get; set; }
        public string[] imagesUrl { get; set; }
    }
}
