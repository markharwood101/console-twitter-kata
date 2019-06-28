using Application.Model;

namespace Application.Ports
{
    public interface IUserRepository
    {
        void Add(IUser_DTO post);
        IUser_DTO Get(string userName);
    }
}
