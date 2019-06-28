using System.Linq;
using AutoMapper;
using Application.Model;
using Application.Ports;
using Repository.Contexts;
using Repository.Model;

namespace Repository.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        // PRIVATE FIELDS:
        private readonly IContext _context;
        private readonly IMapper _mapper;

        // CONSTRUCTOR:
        public SubscriptionRepository(IContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // PUBLIC METHODS:
        public void Add(ISubscription_DTO subscription)
        {
            _context.Subscriptions.Add(_mapper.Map<Subscription>(subscription));
        }

        public ISubscription_DTO Get(string subscriber, string follows)
        {
            return _mapper.Map<Subscription_DTO>(_context.Subscriptions
                .Where(u => u.Subscriber == subscriber & u.Follows == follows)
                .FirstOrDefault());
        }

    }
}
