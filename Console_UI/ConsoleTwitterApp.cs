using System;
using Console_UI.Controllers;
using Console_UI.Presenters;
using Console_UI.Services;

namespace Console_UI
{
    public class ConsoleTwitterApp : IApp
    {
        private readonly IInputsController _inputsController;
        private readonly IReadPresenter _readPresenter;
        private readonly IWallPresenter _wallPresenter;

        public ConsoleTwitterApp(
            IInputsController inputsController,
            IReadPresenter readPresenter,
            IWallPresenter wallPresenter
            )
        {
            _inputsController = inputsController;
            _readPresenter = readPresenter;
            _wallPresenter = wallPresenter;
        }

        public void Run()
        {
            // MAIN LOOP:
            while (true)
            {
                // DECLARATIONS:
                var input = Console.ReadLine();
                var output = "";

                // PROCESS COMMAND:
                switch (InputService.GetCommand(input))
                {
                    case "read":
                        output = _readPresenter.Render(_inputsController.GetPostsForUser(input));
                        break;
                    case "post":
                        _inputsController.Post(input);
                        break;
                    case "follows":
                        _inputsController.Subscribe(input);
                        break;
                    case "wall":
                        output = _wallPresenter.Render(_inputsController.GetWallForUser(input));
                        break;
                }

                // OUTPUT:
                if (output != "") { Console.WriteLine(output); }
            }
        }
    }
}
