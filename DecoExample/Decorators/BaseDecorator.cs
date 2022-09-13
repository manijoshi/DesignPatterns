using DecoExample.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoExample.Decorators
{
    public abstract class BaseDecorator : IMessage
    {
        private readonly IMessage _msg;

        public BaseDecorator(IMessage msg)
        {
            _msg = msg;
        }
        public virtual string Message()
        {
            return _msg.Message();
        }
    }
}
