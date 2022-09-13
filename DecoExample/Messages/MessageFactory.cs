using DecoExample.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoExample.Messages
{
    public class MessageFactory
    {
        public IMessage GetDecoMessage(IMessage msg)
        {
            msg = new UpperCase(msg);
            return msg;
        }
    }
}
