using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Performer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Genre genre { get; set; }
        public double rating { get; set; }
        public string imageUrl { get; set; }
    }
}
