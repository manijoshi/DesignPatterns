using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole_.Mediator
{
    public interface ISubscriber
    {
        void Handle(string message);
    }
}
