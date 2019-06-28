using System.Collections.Generic;

namespace Repository.Model
{
    public class User : IUser
    {
        // CONSTUCTOR:
        public User()
        {
            if (Posts == null) { Posts = new List<IPost>(); }
            if (Subscriptions == null) { Subscriptions = new List<ISubscription>(); }
        }

        // PUBLIC PROPERTIES:
        public string Name { get; set; }
        public IList<IPost> Posts { get; set; }
        public IList<ISubscription> Subscriptions { get; set; }

    }
}
