using Application.Model;
using Application.Ports;

namespace Application.UseCases.Command
{
    public class SubscribeUseCase : ISubscribeUseCase
    {
        // PRIVATE FIELDS:
        private readonly ISubscriptionRepository _subscriptionRepository;

        // CONSTRUCTOR:
        public SubscribeUseCase(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        // PUBLIC METHODS:
        public void Execute(ISubscription_DTO subscription)
        {
            var _subscription = _subscriptionRepository.Get(subscription.Subscriber, subscription.Follows);

            if (_subscription == null)
            {
                _subscriptionRepository.Add(subscription);
            }
        }
    }
}
