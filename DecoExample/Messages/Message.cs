using System;
using System.Collections.Generic;
using System.Text;

namespace DecoExample.Messages
{
    public class Message : IMessage
    {
        string IMessage.Message()
        {
            string message = "Hello World";
            return message;
        }
    }
}
