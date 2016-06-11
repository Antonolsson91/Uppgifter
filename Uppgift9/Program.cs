using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while(b)
            {
                Console.Clear();
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Print Employee Registry");
                Console.WriteLine("4. Exit");
                

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Employee.AddEmployee();
                        break;

                    case "2":
                        Employee.RemoveEmployee();
                        break;

                    case "3":
                        Employee.PrintEmployeeReg();
                        break;

                    case "4":
                         b = false;
                        break;
                }

                    
            }
        }
    }
}
