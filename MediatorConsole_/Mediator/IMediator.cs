using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole_.Mediator
{
    public interface IMediator
    {
        void Publish(string message);
        void Subscribe(ISubscriber subscriber);
    }
}
