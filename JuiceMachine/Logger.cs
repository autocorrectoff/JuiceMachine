using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine
{
    public class Logger
    {
        private static Logger instance = null;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void Log(string action)
        {
            // Logging will not work on your machine unless you specify an absolute path valid for your environment.
            // Example: C:\Users\<Your Username for your PC>\Desktop
            // This program was made with .net standard, so it can run on Windows only

            var myLocalPath =
                @"C:\Users\Aladeen\Documents\Visual Studio 2017\Projects\JuiceMachine\JuiceMachine\Logs\logs.txt";
            var log = $"[{DateTime.Now}] " + action + Environment.NewLine;
            File.AppendAllText(myLocalPath, log);
            Console.WriteLine(log);
        }
    }
}
