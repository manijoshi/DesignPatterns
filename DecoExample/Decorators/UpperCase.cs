using DecoExample.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoExample.Decorators
{
    public class UpperCase:BaseDecorator
    {
        public UpperCase(IMessage msg):base(msg)
        {

        }
        public override string Message()
        {
            return base.Message().ToUpper();
        }
    }
}
