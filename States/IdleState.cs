using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.States
{
    public readonly struct IdleState : IEarpodsState
    {
        public bool RememberAsPreviousState => true;

        private readonly IEarpods _context;
        public IdleState(IEarpods context)
        {
            this._context = context;
        }
        public void DoubleTapLeft() => this._context.VolumeDown();
        

        public void DoubleTapRight() => this._context.VolumeUp();
        

        public void SingleTapLeft()
        {
        }

        public void SingleTapRight()
        {
            _context.SetState(new MusicPlayingState(_context));
        }

        public void Enter()
        {
           
        }

        public void Exit()
        {
            /* Do nothing */
        }
    }
}
