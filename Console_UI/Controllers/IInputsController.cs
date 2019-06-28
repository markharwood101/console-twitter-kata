using System.Collections.Generic;
using Application.Model;

namespace Console_UI.Controllers
{
    public interface IInputsController
    {
        void Post(string input);
        void Subscribe(string input);
        IUser_DTO GetPostsForUser(string user);
        IEnumerable<IPost_DTO> GetWallForUser(string input);
    }
}
