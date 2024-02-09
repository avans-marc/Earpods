using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.Services
{
    public interface IMusicService
    {
        public void Play();

        public void Stop();

        public void Pause();

        public void Next();

        public void Previous();
    }
}
