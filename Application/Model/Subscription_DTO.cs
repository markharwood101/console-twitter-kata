namespace Application.Model
{
    public class Subscription_DTO : ISubscription_DTO
    {
        // PUBLIC PROPERTIES:
        public string Subscriber { get; set; }
        public string Follows { get; set; }
    }
}
