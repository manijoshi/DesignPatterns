using MediatorConsole_.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole_.Subscribers
{
    public class Subscriber2 : ISubscriber
    {
        public Subscriber2(IMediator mediator)
        {
            mediator.Subscribe(this);
        }
        public void Handle(string message)
        {
            Console.WriteLine("Message received by subscriber 2 "+message);
        }
    }
}
