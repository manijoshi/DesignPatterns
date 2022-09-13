using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Mediator
{
    public sealed class SingletonMediator
    {
        private static IMediator _instance = null;

        private SingletonMediator()
        {

        }

        public static IMediator GetMediator
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ConcreteMediator();
                }

                return _instance;
            }
        }
    }
}
