using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.States
{
    public interface IEarpodsState
    {
        void Enter();

        void Exit();

        void SingleTapLeft();

        void SingleTapRight();

        void DoubleTapLeft();

        void DoubleTapRight();

        bool RememberAsPreviousState { get; }
    }
}
