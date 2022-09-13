using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Departments
{
    public interface ILibrary
    {
        void ManageBook();
    }
    public class Library : ILibrary, IResignationObserver
    {
        public Library(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void ManageBook()
        {
            throw new NotImplementedException();
        }

        public void Notify(string employeeId)
        {
            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("Library", employeeId);

        }
    }
}
