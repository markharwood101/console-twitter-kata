using System.Collections.Generic;
using Application.Model;

namespace Console_UI.Presenters
{
    public interface IWallPresenter
    {
        string Render(IEnumerable<Post_DTO> input);
    }
}
