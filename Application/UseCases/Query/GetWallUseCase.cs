using System.Collections.Generic;
using Application.Model;
using Application.Ports;

namespace Application.UseCases.Query
{
    public class GetWallUseCase : IGetWallUseCase
    {
        // PRIVATE FIELDS:
        private readonly IUserRepository _userRepository;

        // CONSTRUCTOR:
        public GetWallUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // PUBLIC METHODS:
        /// <summary>
        /// I made the choice not to add a subscription for any user to themselves
        /// as it seemed incorect but it would have made this method cleaner but could have caused problems later.
        /// So this method first gets posts for the user and then for the users they follow to construct the posts needed for a wall
        /// </summary>
        public IEnumerable<IPost_DTO> Execute(string subscriber)
        {
            IList<IUser_DTO> _usersFollowed = new List<IUser_DTO>();
            var _subscriber = _userRepository.Get(subscriber);

            // We add the subscribers User_DTO object to the list of Users we want to take posts from.
            _usersFollowed.Add(_subscriber);

            // Finish constructing the list of Users
            foreach (var _item in _subscriber.Subscriptions)
            {
                _usersFollowed.Add(_userRepository.Get(_item.Follows));
            }

            // Now we have the list of users followed we can construct our rtn list of Posts
            IList<IPost_DTO> posts = new List<IPost_DTO>();
            foreach (var _user in _usersFollowed)
            {
                foreach (var _post in _user.Posts)
                {
                    posts.Add(_post);
                }
            }

            // DEFAULT RETURN:
            return posts;
        }
    }
}
