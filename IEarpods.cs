using Earpods.Services;
using Earpods.States;

namespace Earpods
{
    public interface IEarpods
    {
        IMusicService Music { get; }
        IPhoneService Phone { get; }
        void PreviousState();
        void SetState(IEarpodsState newState);
        void VolumeDown();
        void VolumeUp();
    }
}