using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(Person playlistOwner, string playlistName) :base(playlistName)
        {
            Owner = playlistOwner;
        }

        public override string ToString()
        {
            return ("Owner: " + this.Owner + "| Playlist Name: " + this.Title);
        }
    }
}
