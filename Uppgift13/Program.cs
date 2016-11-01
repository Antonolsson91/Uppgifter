using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your birthdate: YYYY-MM-DD ");
            var userInput = Console.ReadLine();
            DateTime input = DateTime.Parse(userInput);
            DateTime birthDate = input.Date;
            var year = DateTime.Now.Year - input.Year;

            var nextBDay = birthDate.AddYears(year + 1) - DateTime.Now;
            Console.WriteLine("your name is {0} name and you are {1}s old. Your next birthday is in {2} days and you will turn 100 on a {3}.", name, year, nextBDay.Days, birthDate.AddYears(100).DayOfWeek );

        }
    }
}
