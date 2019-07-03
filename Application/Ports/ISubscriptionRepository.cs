using Application.Model;

namespace Application.Ports
{
    public interface ISubscriptionRepository
    {
        void Add(Subscription_DTO subscription);
        Subscription_DTO Get(string subscriber, string follows);
    }
}
