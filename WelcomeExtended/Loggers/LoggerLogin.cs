using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    internal class LoggerLogin
    {
        private readonly string _logPath;

        public LoggerLogin(string logPath)
        {
            _logPath = logPath;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(_logPath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
