using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
