using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herkansing;

namespace Herkansing.Classes
{
    internal class Client
    {
        public IPlayable CurrentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool Shuffle;
        public bool Repeat;
        private Person ActiveUser;
        private List<Person> persons;
        private List<Album> albums;
        private List<Song> songs;
        private List<Playlist> playlists;
        private List<Person> friends;

        public Client(List<Person> PersonName, List<Album> AlbumTitle, List<Song> SongTitle, List<Playlist> PlaylistName, List<Person> FriendList)
        {
            persons = PersonName;
            albums = AlbumTitle;
            songs = SongTitle;
            playlists = PlaylistName;
            friends = FriendList;
        }

        public void SetActiveUser(Person person)
        {
            if (person != null)
            {
                ActiveUser = person;
                Console.WriteLine(person.Name + " is now the Active User!");
            }
        }

        public void ShowAllAlbums()
        {
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine(i + ". " + albums[i].Title);
            }
        }

        public void SelectAlbum(int album)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                if (i == album)
                {
                    Console.WriteLine("You have selected: " + albums[album].Title);
                }
            }
        }

        public void ShowAllSongs()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(i + ". " + songs[i]);
            }
        }

        public void SelectSong(int song)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (i == song)
                {
                    Console.WriteLine("You have selected: " + songs[song].Title);
                }
            }
        }

        public void ShowAllUsers()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(i + ". " + persons[i].Name);
            }
        }

        public void SelectUser(int user)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (i == user)
                {
                    Console.WriteLine("You have selected: " + persons[user - 1]);
                }
            }
        }

        public void ShowUserPlaylists()
        {
            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine(playlist);
            }
        }

        public void SelectUserPlaylist(int playlist)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (i == playlist)
                {
                    Console.WriteLine("You have selected: " + playlists[playlist - 1]);
                }
            }
        }

        //Play songs & albums
        public void Play()
        {
            Console.WriteLine("Now playing: " + CurrentlyPlaying);
        }

        public void Pause()
        {
            Console.WriteLine("Paused playing: " + CurrentlyPlaying);
        }

        public void Stop()
        {
            Console.WriteLine("Stopped playing: " + CurrentlyPlaying);
        }

        public void NextSong()
        {

        }

        public void SetShuffle(bool Shuffle)
        {
            if (Shuffle == true)
            {
                Console.WriteLine("Shuffle is activated.");
            } else
            {
                Console.WriteLine("Shuffle is deactivated.");
            }
        }

        public void SetRepeat(bool Repeat)
        {
            if (Repeat == true)
            {
                Console.WriteLine("Repeat is activated.");
            }
            else
            {
                Console.WriteLine("Repeat is deactivated.");
            }
        }

        //Person create and show
        public void CreatePlaylist(string playlistName)
        {
            var playlist = new Playlist(null, playlistName);
            playlists.Add(playlist);
            Console.WriteLine("Created new playlist called: " + playlistName);
        }

        public void ShowPlaylists()
        {
            if (playlists.Count <= 0)
            {
                Console.WriteLine("There are currently no playlists!");
            } else
            {
                for (int i = 0; i < playlists.Count; i++)
                {
                    Console.WriteLine(i + ". " + playlists[i].Title);
                }
            }
        }

        public void SelectPlaylist(int playlist)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (i == playlist)
                {
                    Console.WriteLine("You have selected: " + playlists[playlist]);
                }
            }
        }

        public void RemovePlaylist(int playlist)
        {
            ActiveUser.RemovePlaylist(playlists[playlist]);
            Console.WriteLine("Removed " + playlist + " from playlists.");
        }

        public void AddToPlaylists(int playlist)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (i == playlist)
                {
                    Console.WriteLine("Added the song into the playlist.");
                }
            }
        }

        public void ShowSongsInPlaylist()
        {
            foreach (IPlayable iPlayable in ActiveUser.ShowPlaylists())
            {
                Console.WriteLine(iPlayable);
            }
        }

        public void RemoveFromPlaylist(int song)
        {

        }

        //Friends
        public void ShowFriends()
        {
            if (friends.Count <= 0)
            {
                Console.WriteLine("Your friendlist is empty!");
            } else
            {
                for (int i = 0; i < friends.Count; i++)
                {
                    Console.WriteLine(i + ". " + friends[i].Name);
                }
            }
        }

        public void SelectFriend()
        {

        }

        public void AddFriend(int friend)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (i == friend)
                {
                    friends.Add(persons[i]);
                    Console.WriteLine(persons[i].Name + " has been added to your friendlist!");
                }
            }
        }

        public void RemoveFriend(int friendRemove)
        {
            for (int i = 0; i < friends.Count; i++)
            {
                if (i == friendRemove)
                {
                    friends.Remove(friends[friendRemove]);
                }
            }
        }
    }
}
