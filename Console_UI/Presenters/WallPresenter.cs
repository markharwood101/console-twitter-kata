using System.Collections.Generic;
using System.Linq;
using System.Text;

using Application.Model;

using Console_UI.Services;

namespace Console_UI.Presenters
{
    public class WallPresenter : IWallPresenter
    {
        public string Render(IEnumerable<Post_DTO> input)
        {
            var _output = new StringBuilder();

            if (input != null)
            {
                IEnumerable<Post_DTO> orderedList = input.OrderByDescending(cd => cd.CreatedDateStamp);

                foreach (var _item in orderedList)
                {
                    _output.Append(_item.CreatedBy + " - " + _item.Detail + " (" + PresenterService.GetElapsedTime(_item.CreatedDateStamp));
                    _output.AppendLine();
                }
            }

            // DEFAULT RETURN:
            return _output.ToString();
        }
    }
}
