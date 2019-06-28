using System.Collections.Generic;

namespace Application.Model
{
    public class User_DTO : IUser_DTO
    {
        // CONSTUCTOR:
        public User_DTO()
        {
            if (Posts == null) { Posts = new List<IPost_DTO>(); }
            if (Subscriptions == null) { Subscriptions = new List<ISubscription_DTO>(); }
        }

        // PUBLIC PROPERTIES:
        public string Name { get; set; }
        public IList<IPost_DTO> Posts { get; set; }
        public IList<ISubscription_DTO> Subscriptions { get; set; }

    }
}
