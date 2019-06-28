using AutoMapper;
using Application.Ports;

namespace Repository.Model
{
    public class Subscription : ISubscription
    {
        // PUBLIC PROPERTIES:
        public string Subscriber { get; set; }
        public string Follows { get; set; }
    }
}
