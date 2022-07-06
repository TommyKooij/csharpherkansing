using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class Person
    {
        public string Name;
        public List<Person> Friends;
        public List<Playlist> Playlists;

        public Person(string personName)
        {
            Name = personName;
        }

        public List<Person> ShowFriends()
        {
            foreach (Person friend in Friends)
            {
                Console.WriteLine(friend);
            }
            return Friends;
        }

        public void AddFriends(Person friend)
        {
            Friends.Add(friend);
        }

        public void RemoveFriends(Person person)
        {
            Friends.Remove(person);
        }

        public List<Playlist> ShowPlaylists()
        {
            for (int i = 0; i < Playlists.Count; i++)
            {
                Console.WriteLine(Playlists[i]);
            }
            return Playlists;
        }

        public Playlist SelectPlaylist(int playlistNumber)
        {
            for (int i = 0; i < Playlists.Count; i++)
            {
                if (i == playlistNumber)
                {
                    return Playlists[playlistNumber];
                }
            }
            return null;
        }

        public Playlist CreatePlaylist(string playlistName)
        {
            return new Playlist(this, playlistName);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }

        public void AddToPlaylist(IPlayable iPlayable)
        {
            Playlists.Add((Playlist)iPlayable);
        }

        public void RemoveFromPlaylist(IPlayable iPlayable)
        {
            Playlists.Remove((Playlist)iPlayable);
        }

        public override string ToString()
        {
            return ("Name: " + this.Name + "| Friends: " + this.Friends + "| Playlists: " + this.Playlists);
        }
    }
}
