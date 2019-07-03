using System.Collections.Generic;
using Repository.Model;

namespace Repository.Contexts
{
    public interface IContext
    {
        IList<Post> Posts { get; }
        IList<User> Users { get; }
        IList<Subscription> Subscriptions { get; }
    }
}
