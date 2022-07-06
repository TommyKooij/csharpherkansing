using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing.Classes
{
    internal interface IPlayable
    {
        public void Play();

        public void Pause();

        public void Next();

        public void Stop();

        public int Length { get; set; }
        
    }
}
