using System.Collections.Generic;
using Application.Model;

namespace Console_UI.Controllers
{
    public interface IInputsController
    {
        void Post(string input);
        void Subscribe(string input);
        User_DTO GetPostsForUser(string user);
        IEnumerable<Post_DTO> GetWallForUser(string input);
    }
}
