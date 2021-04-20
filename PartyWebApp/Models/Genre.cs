using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyWebApp.Models
{
    public enum Genre
    {
        [Display(Name = "Hip Hop")]
        hipHop = 1,
        [Display(Name = "Rock")]
        rock = 2,
        [Display(Name = "Techno")]
        techno = 3,
        [Display(Name = "House")]
        house = 4,
        [Display(Name = "Pop")]
        pop = 5,
    }
}
