using System;
using System.Collections.Generic;
using Application.Model;
using Application.UseCases.Command;
using Application.UseCases.Query;

namespace Console_UI.Controllers
{
    public class InputsController : IInputsController
    {
        // PRIVATE FIELDS:
        private readonly IPostUseCase _postUseCase;
        private readonly ISubscribeUseCase _subscribeUseCase;
        private readonly IReadUseCase _readUseCase;
        private readonly IGetWallUseCase _getWallUseCase;
        private readonly IPost_DTO _post;
        private readonly ISubscription_DTO _subscription;

        // CONSTRUCTOR:
        public InputsController(
            IPostUseCase postUseCase,
            ISubscribeUseCase subscribeUseCase,
            IReadUseCase readUseCase,
            IGetWallUseCase getWallUseCase,
            IPost_DTO post,
            ISubscription_DTO subscription
            )
        {
            _postUseCase = postUseCase;
            _subscribeUseCase = subscribeUseCase;
            _readUseCase = readUseCase;
            _getWallUseCase = getWallUseCase;
            _post = post;
            _subscription = subscription;
        }

        // COMMAND ACTIONS:
        /// <summary>
        /// Executes the PostUseCase
        /// There is no Output to the Console from this action
        /// </summary>
        public void Post(string input)
        {
            // split input string by ->
            string[] _input = input.Split(" -> ");

            _post.CreatedBy = _input[0];
            _post.Detail = _input[1];
            _post.CreatedDateStamp = DateTime.Now;

            _postUseCase.Execute(_post);
        }

        /// <summary>
        /// Executes the SubscribeUseCase
        /// There is no Output to the Console from this action
        /// </summary>
        public void Subscribe(string input)
        {
            // split string by follows command
            string[] _input = input.Split(" follows ");

            _subscription.Subscriber = _input[0];
            _subscription.Follows = _input[1];

            _subscribeUseCase.Execute(_subscription);
        }


        // QUERY ACTIONS:
        /// <summary>
        /// Executes the GetWallUseCase
        /// Output is a IUser_DTO whose Posts collection is read in the ReadPresenter
        /// </summary>
        public IUser_DTO GetPostsForUser(string user)
        {
            return _readUseCase.Execute(user);
        }

        /// <summary>
        /// Executes the ReadUseCase
        /// Output is an IEnumerable of IUser_DTO whose Posts collections are read in the WallPresenter
        /// </summary>
        public IEnumerable<IPost_DTO> GetWallForUser(string input)
        {
            // split string by wall command
            string[] _input = input.Split(" wall");

            return _getWallUseCase.Execute(_input[0]);
        }

    }
}
