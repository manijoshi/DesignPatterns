using DecoExample.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoExample
{
    public class MessageConveyor
    {
        public string GetMessage()
        {
            IMessage msg = new MessageFactory().GetDecoMessage(new Message());
            return msg.Message();
        }
    }
}
