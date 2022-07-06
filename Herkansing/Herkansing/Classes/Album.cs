using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class Album : SongCollection
    {
        public List<Artist> Artists;

        public Album(List<Artist> listArtists, string albumName, List<Song> songNames) :base(albumName)
        {
            Artists = listArtists;
        }

        public override string ToString()
        {
            return ("Song Names: " + base.ShowPlayables());
        }
    }
}
