using Application.Model;

namespace Application.UseCases.Command
{
    public interface ISubscribeUseCase
    {
        void Execute(Subscription_DTO subscription);
    }
}
