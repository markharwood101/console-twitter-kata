using System.Collections.Generic;
using Application.Model;

namespace Application.UseCases.Query
{
    public interface IGetWallUseCase
    {
        IEnumerable<IPost_DTO> Execute(string subscriber);
    }
}
