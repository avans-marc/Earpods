using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.Services
{
    public interface IPhoneService
    {
        public void AnswerCall();

        public void RejectCall();

        public void SubscribeToIncomingCalls(Action callback);
    }
}
