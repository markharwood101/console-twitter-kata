using Application.Model;

namespace Application.UseCases.Command
{
    public interface IPostUseCase
    {
        void Execute(IPost_DTO post);
    }
}
