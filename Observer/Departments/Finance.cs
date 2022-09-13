using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Departments
{
    public interface IFinance
    {
        void CalculateSalary();
    }
    public class Finance : IFinance,IResignationObserver
    {
        public Finance(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalculateSalary()
        {
            
        }

        public void Notify(string employeeId)
        {
            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("Finance", employeeId);
        }
    }
}
