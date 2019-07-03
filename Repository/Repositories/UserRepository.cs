using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Application.Model;
using Application.Ports;
using Repository.Contexts;
using Repository.Model;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        // PRIVATE FIELDS:
        private readonly IContext _context;
        private IMapper _mapper;

        // CONSTRUCTOR:
        public UserRepository(IContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // PUBLIC METHODS:
        public void Add(User_DTO user)
        {
            _context.Users.Add(_mapper.Map<User>(user));
        }

        public User_DTO Get(string userName)
        {
            var user = _context.Users.Where(b => b.Name == userName).FirstOrDefault();
            if (user != null) { user = BuildUser(user); }

            var DTO = _mapper.Map<User_DTO>(user);

            // N.B. AutoMapper was failing when trying to map the collections.
            // I'm sure it works but couldn't see the problem
            // Ignoring them in the config and adding the collections manually for now as a workaround
            if (user != null)
            {
                foreach (var _item in user.Posts)
                {
                    DTO.Posts.Add(_mapper.Map<Post_DTO>(_item));
                }
                foreach (var _item in user.Subscriptions)
                {
                    DTO.Subscriptions.Add(_mapper.Map<Subscription_DTO>(_item));
                }
            }

            // DEFAULT RETURN:
            return DTO;
        }

        // PRIVATE METHODS:
        /// <summary>
        /// Takes the found User and adds Posts and any Subscriptions
        /// </summary>
        private User BuildUser(User user)
        {
            IList<Post> posts = new List<Post>();
            IList<Subscription> subscriptions = new List<Subscription>();

            foreach (var _item in GetPostsForUser(user.Name))
                posts.Add(_mapper.Map<Post>(_item));

            foreach (var _item in GetSubscriptionsForUser(user.Name))
                subscriptions.Add(_mapper.Map<Subscription>(_item));

            user.Posts = posts;
            user.Subscriptions = subscriptions;

            // DEFAULT RETURN:
            return user;
        }

        private IEnumerable<Post_DTO> GetPostsForUser(string user)
        {
            IList<Post_DTO> posts = new List<Post_DTO>();

            foreach (var _item in _context.Posts.Where(b => b.CreatedBy == user).ToList())
            {
                posts.Add(_mapper.Map<Post_DTO>(_item));
            }

            // DEFAULT RETURN:
            return posts;
        }

        private IEnumerable<Subscription_DTO> GetSubscriptionsForUser(string user)
        {
            IList<Subscription_DTO> subscriptions = new List<Subscription_DTO>();

            foreach (var _item in _context.Subscriptions.Where(b => b.Subscriber == user).ToList())
            {
                subscriptions.Add(_mapper.Map<Subscription_DTO>(_item));
            }

            // DEFAULT RETURN:
            return subscriptions;
        }
    }
}
