using System.Collections.Generic;

namespace Application.Model
{
    public class User_DTO
    {
        // CONSTUCTOR:
        public User_DTO()
        {
            if (Posts == null) { Posts = new List<Post_DTO>(); }
            if (Subscriptions == null) { Subscriptions = new List<Subscription_DTO>(); }
        }

        // PUBLIC PROPERTIES:
        public string Name { get; set; }
        public IList<Post_DTO> Posts { get; set; }
        public IList<Subscription_DTO> Subscriptions { get; set; }

    }
}
