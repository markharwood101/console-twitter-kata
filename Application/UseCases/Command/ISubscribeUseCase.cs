using Application.Model;

namespace Application.UseCases.Command
{
    public interface ISubscribeUseCase
    {
        void Execute(ISubscription_DTO subscription);
    }
}
