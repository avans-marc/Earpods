using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.States
{
    public readonly struct AnsweringCallState : IEarpodsState
    {
        private readonly IEarpods _context;

        public bool RememberAsPreviousState => false;

        public AnsweringCallState(IEarpods context)
        {
            _context = context;
        }

        public void DoubleTapLeft() => _context.VolumeDown();


        public void DoubleTapRight() => _context.VolumeUp();
    

        public void SingleTapLeft() => this._context.PreviousState();

        public void SingleTapRight()
        {
            /* Do nothing */
        }
        

        public void Enter() => _context.Phone.AnswerCall();


        public void Exit() => _context.Phone.RejectCall();

 
    }
}
