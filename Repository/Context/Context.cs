using System.Collections.Generic;
using Repository.Model;

namespace Repository.Contexts
{
    public class Context : IContext
    {
        // CONSTRUCTOR:
        public Context()
        {
            if (Posts == null) { Posts = new List<Post>(); }
            if (Users == null) { Users = new List<User>(); }
            if (Subscriptions == null) { Subscriptions = new List<Subscription>(); }
        }

        public IList<Post> Posts { get; set; }
        public IList<User> Users { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
    }
}
