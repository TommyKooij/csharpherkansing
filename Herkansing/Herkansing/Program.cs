using Herkansing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class App
{
    public static void Main(string[] args)
    {
        var people = new List<Person>();
        var john = new Person("John");
        var robert = new Person("Robert");
        people.Add(john);
        people.Add(robert);

        var songs = new List<Song>();

        var artists = new List<Artist>();
        var albumsNCT = new List<Album>();
        var albumNCT = new Album(artists, "Astrophysical", null);
        albumsNCT.Add(albumNCT);
        var nct = new Artist("NCT", albumsNCT);
        artists.Add(nct);
        var afterlife = new Song("Afterlife", artists, Herkansing.Genre.Drum_And_Base);
        var ditr = new Song("Dancing in the Rain", artists, Herkansing.Genre.Drum_And_Base);
        var stm = new Song("Say To Me", artists, Herkansing.Genre.Drum_And_Base);
        var albumSongs = new List<Song>();
        albumSongs.Add(afterlife);
        albumSongs.Add(ditr);
        albumSongs.Add(stm);

        var albums = new List<Album>();
        albums.Add(albumNCT);

        songs.Add(afterlife);
        songs.Add(ditr);
        songs.Add(stm);

        var playlists = new List<Playlist>();
        var friendlist = new List<Person>();

        Client client = new Client(people, albums, songs, playlists, friendlist);
    form:
        Console.Write("\r\n");
        Console.WriteLine("Welcome to Music Player! To continue, press one of the following:");
        Console.WriteLine("1. Songs");
        Console.WriteLine("2. Albums");
        Console.WriteLine("3. Playlists");
        Console.WriteLine("4. User Settings");
        Console.WriteLine("5. Friends");
        Console.WriteLine("6. Exit");
        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Songs();
                goto form;
            case 2:
                Albums();
                goto form;
            case 3:
                Playlists();
                goto form;
            case 4:
                UserSettings();
                goto form;
            case 5:
                Friends();
                goto form;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\n\rThis isn't a valid input!\n\r");
                goto form;

                void Songs()
                {
                songs:
                    Console.WriteLine("\r\nWhat would you like to do:");
                    Console.WriteLine("1. View Songs");
                    Console.WriteLine("2. Select Song");
                    Console.WriteLine("3. Add Song To Playlist");
                    Console.WriteLine("4. Go back");
                    int songSelection = Convert.ToInt32(Console.ReadLine());

                    switch (songSelection)
                    {
                        case 1:
                            client.ShowAllSongs();
                            goto songs;
                        case 2:
                            Console.WriteLine("Which song would you like to selected:");
                            int songSelect = Convert.ToInt32(Console.ReadLine());
                            client.SelectSong(songSelect);
                            goto songs;
                        case 3:
                            //client.AddToPlaylist();
                            goto songs;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("\n\rThis isn't a valid input!\n\r");
                            goto songs;
                    }
                }

                void Albums()
                {
                    if (true)
                    {
                    albums:
                        Console.WriteLine("\r\nWhat would you like to do:");
                        Console.WriteLine("1. View Albums");
                        Console.WriteLine("2. Select Album");
                        Console.WriteLine("3. Go back");
                        int albumSelection = Convert.ToInt32(Console.ReadLine());

                        switch (albumSelection)
                        {
                            case 1:
                                client.ShowAllAlbums();
                                goto albums;
                            case 2:
                                Console.WriteLine("Which Album would you like to chose:");
                                int albumSelect = Convert.ToInt32(Console.ReadLine());
                                client.SelectAlbum(albumSelect);
                                goto albums;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("\n\rThis isn't a valid input!\n\r");
                                goto albums;
                        }
                    }
                }

                void Playlists()
                {
                    if (true)
                    {
                    playlists:
                        Console.WriteLine("\r\nWhat would you like to do:");
                        Console.WriteLine("1. View Playlists");
                        Console.WriteLine("2. Select Playlist");
                        Console.WriteLine("3. Create Playlist");
                        Console.WriteLine("4. Remove Playlist");
                        Console.WriteLine("5. Go back");
                        int playlistSelection = Convert.ToInt32(Console.ReadLine());

                        switch (playlistSelection)
                        {
                            case 1:
                                client.ShowPlaylists();
                                goto playlists;
                            case 2:
                                Console.WriteLine("What playlist would you like to select:");
                                int playlistSelect = Convert.ToInt32(Console.ReadLine());
                                client.SelectPlaylist(playlistSelect);
                                goto playlists;
                            case 3:
                                Console.WriteLine("What would the name of your playlist be:");
                                string playlistName = Convert.ToString(Console.ReadLine());
                                if (playlistName == "")
                                {
                                    Console.WriteLine("Invalid title!");
                                    goto playlists;
                                } else
                                {
                                    client.CreatePlaylist(playlistName);
                                    goto playlists;
                                }
                            case 4:
                                //client.RemovePlaylists();
                                goto playlists;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("\n\rThis isn't a valid input!\n\r");
                                goto playlists;
                        }
                    }
                }

                void UserSettings()
                {
                    if (true)
                    {
                    us:
                        Console.WriteLine("\r\nWhat would you like to do:");
                        Console.WriteLine("1. Show People");
                        Console.WriteLine("2. Change Active User");
                        Console.WriteLine("3. Go back");
                        int settingsSelection = Convert.ToInt32(Console.ReadLine());

                        switch (settingsSelection)
                        {
                            case 1:
                                client.ShowAllUsers();
                                goto us;
                            case 2:
                                Console.WriteLine("Which user would you like to become the Active User:");
                                string selectUser = Convert.ToString(Console.ReadLine());
                                if (selectUser == "john")
                                {
                                    client.SetActiveUser(john);
                                    goto us;
                                } else if (selectUser == "robert")
                                {
                                    client.SetActiveUser(robert);
                                    goto us;
                                } else
                                {
                                    Console.WriteLine("Invalid user!");
                                    goto us;
                                }
                            case 3:
                                break;
                        }
                    }
                }

                void Friends()
                {
                    if (true)
                    {
                    friends:
                        Console.WriteLine("\r\nWhat would you like to do:");
                        Console.WriteLine("1. View Friends");
                        Console.WriteLine("2. Select Friend");
                        Console.WriteLine("3. Add Friend");
                        Console.WriteLine("4. Remove Friend");
                        Console.WriteLine("5. Go back");
                        int friendSelection = Convert.ToInt32(Console.ReadLine());

                        switch (friendSelection)
                        {
                            case 1:
                                client.ShowFriends();
                                goto friends;
                            case 2:
                                //client.SelectFriend();
                                goto friends;
                            case 3:
                                client.ShowAllUsers();
                                Console.WriteLine("Which person would you like to add as your friend:");
                                int friendSelect = Convert.ToInt32(Console.ReadLine());
                                client.AddFriend(friendSelect);
                                goto friends;
                            case 4:
                                //client.RemoveFriend();
                                goto friends;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("\n\rThis isn't a valid input!\n\r");
                                goto friends;
                        }
                    }
                }
        }
    }
}


