using System.Collections.Generic;

namespace Application.Model
{
    public interface IUser_DTO
    {
        string Name { get; set; }
        IList<IPost_DTO> Posts { get; }
        IList<ISubscription_DTO> Subscriptions { get; }
    }
}
