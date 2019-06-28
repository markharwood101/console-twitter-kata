using System;
using System.Collections.Generic;
using System.Linq;
using Application.Model;
using Application.Ports;

namespace Application.UnitTests
{
    public class FakeUserRepository : IUserRepository
    {
        public IList<IUser_DTO> Users { get; set; }

        public FakeUserRepository()
        {
            Users = new List<IUser_DTO>();

            Users.Add(new User_DTO { Name = "Name 1", Posts = new List<IPost_DTO>(), Subscriptions = new List<ISubscription_DTO>() });
            Users.Add(new User_DTO { Name = "Name 2", Posts = new List<IPost_DTO>(), Subscriptions = new List<ISubscription_DTO>() });
            Users.Add(new User_DTO { Name = "Name 3", Posts = new List<IPost_DTO>(), Subscriptions = new List<ISubscription_DTO>() });

            Users[0].Posts.Add(new Post_DTO { Detail = "Detail 1", CreatedBy = "Name 1", CreatedDateStamp = DateTime.Now.AddSeconds(-61) });
            Users[0].Posts.Add(new Post_DTO { Detail = "Detail 2", CreatedBy = "Name 1", CreatedDateStamp = DateTime.Now.AddSeconds(-30) });
            Users[1].Posts.Add(new Post_DTO { Detail = "Detail 3", CreatedBy = "Name 2", CreatedDateStamp = DateTime.Now.AddSeconds(-40) });
            Users[1].Posts.Add(new Post_DTO { Detail = "Detail 4", CreatedBy = "Name 2", CreatedDateStamp = DateTime.Now.AddSeconds(-20) });
            Users[2].Posts.Add(new Post_DTO { Detail = "Detail 5", CreatedBy = "Name 3", CreatedDateStamp = DateTime.Now.AddSeconds(-20) });

            Users[0].Subscriptions.Add(new Subscription_DTO { Subscriber = "Name 1", Follows = "Name 2" });
            Users[1].Subscriptions.Add(new Subscription_DTO { Subscriber = "Name 2", Follows = "Name 3" });

        }

        public void Add(IUser_DTO user)
        {
            Users.Add(user);
        }

        public IUser_DTO Get(string userName)
        {
            return Users.Where(x => x.Name == userName).FirstOrDefault();
        }
    }
}
