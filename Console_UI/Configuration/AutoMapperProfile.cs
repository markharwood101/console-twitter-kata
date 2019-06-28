using AutoMapper;
using Application.Model;
using Repository.Model;

namespace Console_UI.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User_DTO, User>()
                .ForMember(t => t.Posts, opt => opt.Ignore())
                .ForMember(t => t.Subscriptions, opt => opt.Ignore());
            CreateMap<User, User_DTO>()
                .ForMember(t => t.Posts, opt => opt.Ignore())
                .ForMember(t => t.Subscriptions, opt => opt.Ignore());

            CreateMap<Post_DTO, Post>().ReverseMap();
            CreateMap<Subscription_DTO, Subscription>().ReverseMap();

        }
    }
}
