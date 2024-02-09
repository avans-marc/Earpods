using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.Services
{
    public class MusicService : IMusicService
    {
        public void Next() => Console.WriteLine("Next song");
    

        public void Pause() => Console.WriteLine("Pause song");


        public void Play() => Console.WriteLine("Play music");


        public void Previous() => Console.WriteLine("Previous song");

        public void Stop() => Console.WriteLine("Stop song");

    }
}
