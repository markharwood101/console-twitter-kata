using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_UI.Services
{
    public static class PresenterService
    {
        public static string GetElapsedTime(DateTime createdDateStamp)
        {
            // DECLARATIONS:
            TimeSpan elapsedTime;
            int seconds = 0;
            int minutes = 0;
            string output;

            elapsedTime = DateTime.Now - createdDateStamp;
            seconds = (int)elapsedTime.TotalSeconds;

            // Split out minutes and seconds...
            if (seconds >= 60)
                minutes = seconds / 60;

            if (minutes > 0)
                seconds -= minutes * 60;

            // Format output...
            if (minutes > 0)
            {
                output = "(" + minutes.ToString() + " minutes and " + seconds.ToString() + " seconds ago.)";
            }
            else
            {
                output = "(" + seconds.ToString() + " seconds ago.)";
            }

            // DEFAULT RETURN:
            return output;
        }

    }
}
