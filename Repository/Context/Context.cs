using System.Collections.Generic;
using Repository.Model;

namespace Repository.Contexts
{
    public class Context : IContext
    {
        // PRIVATE FIELDS:
        private static IList<IPost> posts;
        private static IList<IUser> users;
        private static IList<ISubscription> subscriptions;

        // CONSTRUCTOR:
        public Context()
        {
            if (posts == null) { posts = new List<IPost>(); }
            if (users == null) { users = new List<IUser>(); }
            if (subscriptions == null) { subscriptions = new List<ISubscription>(); }
        }

        // PUBLIC PROPERTIES:
        public IList<IPost> Posts { get { return posts; } }
        public IList<IUser> Users { get { return users; } }
        public IList<ISubscription> Subscriptions { get { return subscriptions; } }

    }
}
