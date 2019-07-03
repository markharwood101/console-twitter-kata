using System.Linq;

namespace Console_UI.Services
{
    public static class InputService
    {
        /// <summary>
        /// Takes a string and processes it to return the command used
        /// </summary>
        public static string GetCommand(string input)
        {
            string[] _inputs = input.Split(" ");

            // Is it a read command?
            if (_inputs.Count() == 1)
            {
                return "read";
            }

            // Is it a Post command?
            if (input.Contains("->"))
            {
                return "post";
            }

            if (_inputs.Count() > 1)
            {
                // Is it a follows or a wall command
                switch (_inputs[1])
                {
                    case "follows":
                        return "follows";

                    case "wall":
                        return "wall";
                }
            }

            // DEFAULT RETURN:
            return null;
        }
    }
}
