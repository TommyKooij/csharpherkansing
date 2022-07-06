using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal class SongCollection : IPlayable
    {
        public string Title;
        private List<IPlayable> playables;
        private int currentlyPlaying = 0;

        public SongCollection(string songCollectionTitle) 
        {
            Title = songCollectionTitle;
        }

        public int Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IPlayable iPlayable)
        {
            if (iPlayable != null)
            {
                playables.Add(iPlayable);
            }
        }

        public void Next()
        {
            currentlyPlaying++;
            if (currentlyPlaying > playables.Count)
            {
                currentlyPlaying = 0;
            }
            Console.WriteLine("Currently playing: " + playables[currentlyPlaying]);
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

        public void Remove(IPlayable iPlayable)
        {
            if (iPlayable != null)
            {
                playables.Remove(iPlayable);
            }
        }

        public List<IPlayable> ShowPlayables()
        {
            foreach (IPlayable iPlayable in playables)
            {
                Console.WriteLine(iPlayable);
            }
            return playables;
        }

        public override string ToString()
        {
            return ("Collection Title: " + this.Title);
        }
            
    }
}
