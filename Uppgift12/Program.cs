using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var application = new LogApplication(logger);
            while (true) { 
            application.Run();           }
        }
    }
}
