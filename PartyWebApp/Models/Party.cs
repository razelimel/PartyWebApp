using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Party
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        [DataType(DataType.Date)]
        public DateTime eventDate { get; set; }
        public Genre genre { get; set; }
        public int minimalAge { get; set; }
        public Performer[] performers { get; set; }
        public Attendee[] attendees { get; set; }
        public Club club { get; set; }
    }
}
