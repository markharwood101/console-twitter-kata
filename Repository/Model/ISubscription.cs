namespace Repository.Model
{
    public interface ISubscription
    {
        string Subscriber { get; set; }
        string Follows { get; set; }
    }
}
