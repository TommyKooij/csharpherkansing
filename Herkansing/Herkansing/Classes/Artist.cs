using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class Artist
    {
        public string Name;
        public List<Album> Albums;
        public List<Song> Songs;

        public Artist(string nameArtist, List<Album> albumsArtist)
        {
            Name = nameArtist;
            Albums = albumsArtist;
        }

        public void AddSong(Song songArtist)
        {
            if (songArtist != null)
            {
                Songs.Add(songArtist);
            }
        }

        public string ToString(string nameArtist, List<Album> albumsArtist, List<Song> songsArtist)
        {
            return ("Artist: " + nameArtist + "| Albums: " + albumsArtist + "| Songs: " + songsArtist);   
        }
    }
}
