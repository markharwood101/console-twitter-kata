using Application.Model;

namespace Console_UI.Presenters
{
    public interface IReadPresenter
    {
        string Render(IUser_DTO input);
    }
}
