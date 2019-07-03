using Application.Model;

namespace Application.Ports
{
    public interface IUserRepository
    {
        void Add(User_DTO post);
        User_DTO Get(string userName);
    }
}
