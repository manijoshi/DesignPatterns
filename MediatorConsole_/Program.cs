using MediatorConsole_.Mediator;
using MediatorConsole_.Subscribers;
using System;

namespace MediatorConsole_
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();
            var subscriber1 = new Subscriber1(mediator);
            var subscriber2 = new Subscriber2(mediator);
            var subscriber3 = new Subscriber3(mediator);
            subscriber3.PublishMessage("message from subscriber 3");
            Console.ReadKey();
        }
    }
}
