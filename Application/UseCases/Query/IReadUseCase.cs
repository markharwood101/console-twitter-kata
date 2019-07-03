using Application.Model;

namespace Application.UseCases.Query
{
    public interface IReadUseCase
    {
        User_DTO Execute(string user);
    }
}
