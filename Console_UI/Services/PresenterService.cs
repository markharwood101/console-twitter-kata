using System;

namespace Console_UI.Services
{
    public static class PresenterService
    {
        public static string GetElapsedTime(DateTime createdDateStamp)
        {
            // DECLARATIONS:
            TimeSpan _elapsedTime;
            int _seconds;

            _elapsedTime = DateTime.Now - createdDateStamp;
            _seconds = (int)_elapsedTime.TotalSeconds;

            // Format output...
            if (_seconds >= 60)
            {
                return " (" + (_seconds / 60).ToString() + " minutes and " + (_seconds % 60).ToString() + " seconds ago.)";
            }
            else
            {
                return " (" + _seconds.ToString() + " seconds ago.)";
            }

        }
    }
}
