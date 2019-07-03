using Application.Model;
using Application.Ports;

namespace Application.UseCases.Query
{
    public class ReadUseCase : IReadUseCase
    {
        // PRIVATE FIELDS:
        private readonly IUserRepository _userRepository;

        // CONSTRUCTOR:
        public ReadUseCase(IUserRepository userRepository = null)
        {
            _userRepository = userRepository;
        }

        // PUBLIC METHODS:
        public User_DTO Execute(string user)
        {
            return _userRepository.Get(user);
        }

    }
}
