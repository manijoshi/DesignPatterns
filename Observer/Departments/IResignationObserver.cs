using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Departments
{
    public interface IResignationObserver
    {
        void Notify(string employeeId);
    }
}
