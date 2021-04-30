using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyWebApp.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Event Date")]
        public DateTime eventDate { get; set; }
        
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Open Doors")]
        public DateTime startTime { get; set;}
        public Genre genre { get; set; }
        [Display(Name = "Minimal Age")]
        public int minimalAge { get; set; }
        public List<Performer> performers { get; set; }
        public int ticketsCounter { get; set; }
        public Club club { get; set; }
        [Display(Name = "Image")]
        public string imageUrl { get; set; }
    }
}
