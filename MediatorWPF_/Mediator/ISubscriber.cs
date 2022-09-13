
namespace WPF_Mediator
{
    public interface ISubscriber<T> where T : IMessage
    {
        void Handle(T message);
    }
}
