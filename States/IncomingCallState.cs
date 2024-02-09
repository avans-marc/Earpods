using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.States
{
    public readonly struct IncomingCallState : IEarpodsState
    {
        private readonly IEarpods _context;

        public bool RememberAsPreviousState => false;

        public IncomingCallState(IEarpods context)
        {
            _context = context;
        }

        public void DoubleTapLeft() => this._context.VolumeDown();


        public void DoubleTapRight() => this._context.VolumeUp();

        public void SingleTapLeft()
        {
            this._context.Phone.RejectCall();
            this._context.PreviousState();
        }

        public void SingleTapRight() => this._context.SetState(new AnsweringCallState(_context));
 

        public void Enter()
        {
            Console.WriteLine("Play ringtone");
        }

        public void Exit() { 
        }
    }
}
