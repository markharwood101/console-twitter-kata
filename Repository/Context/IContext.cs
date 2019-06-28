using System.Collections.Generic;
using Repository.Model;

namespace Repository.Contexts
{
    public interface IContext
    {
        IList<IPost> Posts { get; }
        IList<IUser> Users { get; }
        IList<ISubscription> Subscriptions { get; }
    }
}
