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
            TimeSpan _elapsedTime;
            int _seconds = 0;
            int _minutes = 0;
            string _output;

            _elapsedTime = DateTime.Now - createdDateStamp;
            _seconds = (int)_elapsedTime.TotalSeconds;

            // Split out minutes and seconds...
            if (_seconds >= 60)
                _minutes = _seconds / 60;

            if (_minutes > 0)
                _seconds -= _minutes * 60;

            // Format output...
            if (_minutes > 0)
            {
                _output = "(" + _minutes.ToString() + " minutes and " + _seconds.ToString() + " seconds ago.)";
            }
            else
            {
                _output = "(" + _seconds.ToString() + " seconds ago.)";
            }

            // DEFAULT RETURN:
            return _output;
        }

    }
}
