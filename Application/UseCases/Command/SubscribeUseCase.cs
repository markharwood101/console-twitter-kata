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
        public void Execute(Subscription_DTO post)
        {
            var _subscription = _subscriptionRepository.Get(post);

            if (_subscription == null)
            {
                _subscriptionRepository.Add(post);
            }
        }
    }
}
