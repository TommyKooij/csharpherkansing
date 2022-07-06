using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class Song : IPlayable
    {
        public string Title;
        public List<Artist> Artists;
        public Genre SongGenre;
        public int SongLength;

        public Song(string songTitle, List<Artist> songArtists, Genre songGenre)
        {
            Title = songTitle;
            Artists = songArtists;
            SongGenre = songGenre;
        }

        public int Length { get => SongLength; set => throw new NotImplementedException(); }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            Console.WriteLine("Paused playing: " + Title);
        }

        public void Play()
        {
            Console.WriteLine("Now playing: " + Title);
        }

        public void Stop()
        {
            Console.WriteLine("Stopped playing: " + Title);
        }

        public override string ToString()
        {
            return ("Song Title: " + this.Title + "| Artists: " + this.Artists + "| Genre: " + this.SongGenre + "| Length: " + this.SongLength).ToString();
        }
    }
}
