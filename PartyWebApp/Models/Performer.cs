using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyWebApp.Models
{
    public class Performer
    {
        public int Id { get; set; }
        public string SpotifyId { get; set; }
        [NotMapped]
        public FullArtist SpotifyArtistObj { get; set; }
        [NotMapped]
        public List<FullTrack> ArtistTracks { get; set; }
    }
}
