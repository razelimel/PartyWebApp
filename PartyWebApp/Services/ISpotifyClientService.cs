using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using PartyWebApp.Models;

namespace PartyWebApp.Services
{
    public interface ISpotifyClientService
    {
        Task<List<Performer>> GetArtists(List<Performer> performers);

        Task<Performer> GetArtist(Performer performer);

    }
}
