using Application.Model;
using Application.Ports;

namespace Application.UseCases.Command
{
    public class PostUseCase : IPostUseCase
    {
        // PRIVATE FIELDS:
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;

        // CONSTRUCTOR:
        public PostUseCase(IPostRepository postRepository, IUserRepository userRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
        }

        // PUBLIC METHODS:
        public void Execute(Post_DTO post)
        {
            var _postedBy = _userRepository.Get(post.CreatedBy);

            if (_postedBy == null)
            {
                _userRepository.Add(new User_DTO { Name = post.CreatedBy });
            }

            _postRepository.Add(post);
        }

    }
}
