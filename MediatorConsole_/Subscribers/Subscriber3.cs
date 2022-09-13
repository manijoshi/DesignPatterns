using MediatorConsole_.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole_.Subscribers
{
    public class Subscriber3 : ISubscriber
    {
        private readonly IMediator _mediator;

        public Subscriber3(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Handle(string message)
        {
            Console.WriteLine("Message received by subscriber 3 "+message);
        }
        public void PublishMessage(string message)
        {
            _mediator.Publish(message);
        }
    }
}
