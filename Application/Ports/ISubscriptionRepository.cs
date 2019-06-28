using Application.Model;

namespace Application.Ports
{
    public interface ISubscriptionRepository
    {
        void Add(ISubscription_DTO subscription);
        ISubscription_DTO Get(string subscriber, string follows);
    }
}
