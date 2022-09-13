
using System;
using System.Collections.Generic;

namespace WPF_Mediator
{
    public interface IMediator
    {
        void Publish(IMessage message);
        void Subscribe(object subscriber);
    }
}
