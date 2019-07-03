using System.Collections.Generic;
using Repository.Model;

namespace Repository.Contexts
{
    public class Context : IContext
    {
        // PRIVATE FIELDS:
        private static IList<Post> _posts;
        private static IList<User> _users;
        private static IList<Subscription> _subscriptions;

        // CONSTRUCTOR:
        public Context()
        {
            if (_posts == null) { _posts = new List<Post>(); }
            if (_users == null) { _users = new List<User>(); }
            if (_subscriptions == null) { _subscriptions = new List<Subscription>(); }
        }

        // PUBLIC PROPERTIES:
        public IList<Post> Posts { get { return _posts; } }
        public IList<User> Users { get { return _users; } }
        public IList<Subscription> Subscriptions { get { return _subscriptions; } }

    }
}
