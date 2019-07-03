using Application.Model;

namespace Console_UI.Presenters
{
    public interface IReadPresenter
    {
        string Render(User_DTO input);
    }
}
