using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public interface ILogger
    {
        void LogInfo(string message);
    }
    public sealed class Logger:ILogger
    {
        public Logger()
        {
            Console.WriteLine("Logger constructor executed....");
        }
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
