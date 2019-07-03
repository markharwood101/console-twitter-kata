using System.Collections.Generic;

namespace Repository.Model
{
    public class User
    {
        // CONSTUCTOR:
        public User()
        {
            if (Posts == null) { Posts = new List<Post>(); }
            if (Subscriptions == null) { Subscriptions = new List<Subscription>(); }
        }

        // PUBLIC PROPERTIES:
        public string Name { get; set; }
        public IList<Post> Posts { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

    }
}
