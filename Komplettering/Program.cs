using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplettering
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First Post");
            myLogger.Log("Second Post");
            myLogger.Log("Third Post");
            myLogger.Log("Fourth Post");
            myLogger.Log("Fifth Post");

            foreach(var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
        }      
    }
}
