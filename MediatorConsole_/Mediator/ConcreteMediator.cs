using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole_.Mediator
{
    public class ConcreteMediator : IMediator
    {
        List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Publish(string message)
        {
            foreach(var subscriber in subscribers)
            {
                subscriber.Handle(message);
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
    }
}
