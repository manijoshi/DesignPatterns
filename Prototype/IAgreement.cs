using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IAgreement
    {
        IAgreement ShallowCopy();
        IAgreement DeepCopy();
        void Print(string message);
    }
}
