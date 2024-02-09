using Earpods.Services;
using Earpods.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods
{
    public class Earpods : IEarpods
    {
        private IEarpodsState _previousState;
        private IEarpodsState _currentState;

        public Earpods(IMusicService musicService, IPhoneService phoneService)
        {
            this.Music = musicService;
            this.Phone = phoneService;

            this.Phone.SubscribeToIncomingCalls(this.IncomingCall);

            //_previousState = new IdleState(this);
            //_currentState = new IdleState(this);
            this.SetState(new IdleState(this));
        }

        public IMusicService Music { get; }
        public IPhoneService Phone { get; }

        public void SetState(IEarpodsState newState)
        {
            if (this._currentState != null)
            {
                this._currentState.Exit();

                if (this._currentState.RememberAsPreviousState)
                    this._previousState = this._currentState;
            }

            this._currentState = newState;
            Console.WriteLine($"Earpods state: {newState.GetType().Name}");

            this._currentState.Enter();
        }

        public void PreviousState()
        {
            this.SetState(this._previousState);
        }

        public void DoubleTapLeft()
        {
            this._currentState.DoubleTapLeft();
        }

        public void DoubleTapRight()
        {
            this._currentState.DoubleTapRight();
        }

        public void SingleTapLeft()
        {
            this._currentState.SingleTapLeft();
        }

        public void SingleTapRight()
        {
            this._currentState.SingleTapRight();
        }

        public void IncomingCall()
        {
            this.SetState(new IncomingCallState(this));
        }

        public void VolumeUp() => Console.WriteLine("Volume up");
       
        public void VolumeDown() => Console.WriteLine("Volume down");

    }
}
