using System.Collections.Generic;
using Application.Model;

namespace Application.UseCases.Query
{
    public interface IGetWallUseCase
    {
        IEnumerable<Post_DTO> Execute(string subscriber);
    }
}
