using Observer.Subject;

namespace Observer.Departments
{
    public interface IAsset
    {
        void AllocateAsset();
    }
    public class IT : IAsset,IResignationObserver
    {
        public IT(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void AllocateAsset()
        {

        }

        public void Notify(string employeeId)
        {
            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("IT", employeeId);
        }
    }
}
