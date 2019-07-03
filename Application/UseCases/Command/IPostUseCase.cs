using Application.Model;

namespace Application.UseCases.Command
{
    public interface IPostUseCase
    {
        void Execute(Post_DTO post);
    }
}
