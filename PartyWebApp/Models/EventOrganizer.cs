using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class EventOrganizer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; } 
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
