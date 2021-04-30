using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using PartyWebApp.Models;

namespace PartyWebApp.Services
{
    public class SpotifyClientService : ISpotifyClientService
    {
        private static readonly string SPOTIFY_CLIENT_ID = "3914517ae1724e64975d9ed0f7f08bfc";
        private static readonly string SPOTIFY_CLIENT_SECRET = "6dc9817349fa4c51961d2689e6f7c3bf";
        private readonly SpotifyClient _spotify;

        public SpotifyClientService()
        {
            var config = SpotifyClientConfig.CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator(SPOTIFY_CLIENT_ID, SPOTIFY_CLIENT_SECRET));

            _spotify = new SpotifyClient(config);
        }

        public async Task<Performer> GetArtist(Performer performer)
        {
            var artist = await _spotify.Artists.Get(performer.SpotifyId);
            var artistTracks = await _spotify.Artists.GetTopTracks(performer.SpotifyId, new ArtistsTopTracksRequest("US"));
            return new Performer {
                SpotifyId = artist.Id,
                SpotifyArtistObj = artist,
                ArtistTracks = artistTracks.Tracks
            };
        }

        public async Task<List<Performer>> GetArtists(List<Performer> performers)
        {
            List<string> artistsSpotifyIds = new List<string>();
            foreach (Performer performer in performers) artistsSpotifyIds.Add(performer.SpotifyId);
            var artists = await _spotify.Artists.GetSeveral(new ArtistsRequest(artistsSpotifyIds));
            return artists.Artists.ConvertAll(new Converter<FullArtist, Performer>(ConvertArtistToPerfomer));
        }

        private Performer ConvertArtistToPerfomer(FullArtist artist)
        {
            return new Performer
            {
                SpotifyId = artist.Id,
                SpotifyArtistObj = artist,
            };
        }
    }
}
