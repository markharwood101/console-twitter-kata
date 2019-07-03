using Application.Model;

namespace Application.Ports
{
    public interface IPostRepository
    {
        void Add(Post_DTO post);
    }
}
