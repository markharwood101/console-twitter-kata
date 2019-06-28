using Autofac;
using Console_UI.Configuration;

namespace Console_UI
{
    class Program
    {
        // PRIVATE FIELDS:
        private static IContainer CompositionRoot;

        static void Main(string[] args)
        {
            // Configure
            CompositionRoot = ProgramConfig.Configure();

            // Resolve dependencies and run the ConsoleTwitterApp
            CompositionRoot.Resolve<ConsoleTwitterApp>().Run();
        }
    }
}
