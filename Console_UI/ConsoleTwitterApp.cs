using System;
using Console_UI.Controllers;
using Console_UI.Presenters;
using Console_UI.Services;

namespace Console_UI
{
    public class ConsoleTwitterApp
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
            while (true)
            {
                var _input = Console.ReadLine();
                var _output = "";

                // PROCESS COMMAND:
                switch (InputService.GetCommand(_input))
                {
                    case "read":
                        _output = _readPresenter.Render(_inputsController.GetPostsForUser(_input));
                        break;
                    case "post":
                        _inputsController.Post(_input);
                        break;
                    case "follows":
                        _inputsController.Subscribe(_input);
                        break;
                    case "wall":
                        _output = _wallPresenter.Render(_inputsController.GetWallForUser(_input));
                        break;
                }

                // OUTPUT:
                if (_output != "") { Console.WriteLine(_output); }
            }
        }
    }
}
