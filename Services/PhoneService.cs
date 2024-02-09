using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earpods.Services
{
    public class PhoneService : IPhoneService
    {
        private static List<Action> subscribers = new List<Action>();

        public void AnswerCall() => Console.WriteLine("Answer call");
 

        public void RejectCall() => Console.WriteLine("Reject call");

        public void SubscribeToIncomingCalls(Action callback)
        {
            if(!subscribers.Contains(callback))
                subscribers.Add(callback);
        }

        public void TriggerCall()
        {
            foreach (var subscriber in subscribers)
                subscriber.Invoke();
        }
    }
}
