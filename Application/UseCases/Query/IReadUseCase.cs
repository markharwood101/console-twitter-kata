using Application.Model;

namespace Application.UseCases.Query
{
    public interface IReadUseCase
    {
        IUser_DTO Execute(string user);
    }
}
