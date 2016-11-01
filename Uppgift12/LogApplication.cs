using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    class LogApplication
    {
        private ILogger _ILogger;
        public LogApplication(ILogger iLogger)
        {
            _ILogger = iLogger;
        }
        public void Run()
        {
            
             
            Console.WriteLine("1. Add message to log \n2. Print log\n\nChoice:");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Type your message: ");
                    string message = Console.ReadLine();
                    _ILogger.Log(message);
                    break;
                case 2:
                    foreach(string l in _ILogger.LogPosts)
                    {
                        Console.WriteLine(l);
                    }
                    break;
            }

            return;
        
      }
    }
}
