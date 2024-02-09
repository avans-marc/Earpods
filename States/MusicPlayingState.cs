using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.States
{
    public readonly struct MusicPlayingState : IEarpodsState
    {
        private readonly IEarpods context;
        public bool RememberAsPreviousState => true;

        public MusicPlayingState(IEarpods context)
        {
            this.context = context;
     
        }

        public void DoubleTapLeft() => context.VolumeDown();
 

        public void DoubleTapRight() => context.VolumeUp();
       
        public void SingleTapLeft()
        {
            
        }

        public void SingleTapRight() => this.context.SetState(new IdleState(this.context));


        public void Enter()
        {
            this.context.Music.Play();
        }

        public void Exit()
        {
            this.context.Music.Stop();
        }
    }
}
