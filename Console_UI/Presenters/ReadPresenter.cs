using System.Linq;
using System.Text;
using Application.Model;
using Console_UI.Services;

namespace Console_UI.Presenters
{
    public class ReadPresenter : IReadPresenter
    {
        public string Render(User_DTO user)
        {
            var _output = new StringBuilder();
            var posts = user.Posts.ToList();
            posts.Reverse();

            foreach (var _item in posts)
            {
                _output.Append(_item.Detail + PresenterService.GetElapsedTime(_item.CreatedDateStamp));
                _output.AppendLine();
            }

            // DEFAULT RETURN:
            return _output.ToString();
        }
    }
}
