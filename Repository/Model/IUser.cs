using System.Collections.Generic;

namespace Repository.Model
{
    public interface IUser
    {
        string Name { get; set; }
        IList<IPost> Posts { get; set; }
        IList<ISubscription> Subscriptions { get; set; }
    }
}
