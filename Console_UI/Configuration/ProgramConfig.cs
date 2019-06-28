using Autofac;
using AutoMapper;
using Application.Ports;
using Application.UseCases.Command;
using Application.UseCases.Query;
using Application.Model;
using Repository.Repositories;
using Repository.Contexts;
using Repository.Model;
using Console_UI.Presenters;
using Console_UI.Controllers;

namespace Console_UI.Configuration
{
    public static class ProgramConfig
    {
        /// <summary>
        /// Configures and returns an Autofac DI Container
        /// </summary>
        public static IContainer Configure()
        {
            // Build DI Container
            var builder = new ContainerBuilder();

            // Register Mapper
            builder.Register(m => GetMapper());

            // Register Main App
            builder.RegisterType<ConsoleTwitterApp>();

            // Register Controller and Presenters
            builder.RegisterType<InputsController>().As<IInputsController>();
            builder.RegisterType<ReadPresenter>().As<IReadPresenter>();
            builder.RegisterType<WallPresenter>().As<IWallPresenter>();

            // Register UseCases
            builder.RegisterType<PostUseCase>().As<IPostUseCase>();
            builder.RegisterType<SubscribeUseCase>().As<ISubscribeUseCase>();
            builder.RegisterType<ReadUseCase>().As<IReadUseCase>();
            builder.RegisterType<GetWallUseCase>().As<IGetWallUseCase>();

            // Register Repositories and Context
            builder.RegisterType<Context>().As<IContext>();
            builder.RegisterType<PostRepository>().As<IPostRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<SubscriptionRepository>().As<ISubscriptionRepository>();

            // Register POCO objects
            builder.RegisterType<User>().As<IUser>();
            builder.RegisterType<User_DTO>().As<IUser_DTO>();

            builder.RegisterType<Post>().As<IPost>();
            builder.RegisterType<Post_DTO>().As<IPost_DTO>();

            builder.RegisterType<Subscription>().As<ISubscription>();
            builder.RegisterType<Subscription_DTO>().As<ISubscription_DTO>();

            // Run Build...
            return builder.Build();
        }

        /// <summary>
        /// Configures and returns an IMapper instance for registration
        /// Config uses the AutoMapperProfile : Profile class
        /// </summary>
        /// <returns>IMapper</returns>
        private static IMapper GetMapper()
        {
            var config = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>()
                );

            IMapper mapper = new Mapper(config);

            return mapper;
        }
    }
}
