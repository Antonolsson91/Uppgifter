using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift9
{
    class Employee
    {
        private string firstName;
        private int wage = 0;
        private string ssn;
        private string lastName;
        private static List<Employee> employeeList = new List<Employee>();
        public string FirstName
        {
            get { return firstName; }
           
        }

        public string LastName
        {
            get { return lastName; }
            
        }

        public string Ssn
        {
            get { return ssn; }
          
        }

        public int Wage
        {
            get { return wage; }
           
        }
        public Employee(string firstName, string lastName, string ssn, int wage)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.wage = wage;
        }
        public static void AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("Type first name: ");
            string fName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type last name: ");
            string lName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type social security number YYMMDD-XXXX: ");
            string eSsn = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type wage: ");
            int eWage = int.Parse(Console.ReadLine());
            while(true)
            if (eSsn.Count<char>() == 11 && eSsn[6] == '-')
            {
                break;
            }
            else
                {
                    Console.WriteLine("Wrong social security number format");
                    Console.WriteLine("Enter again YYMMDD-XXXX");
                    eSsn = Console.ReadLine();
                }

            Employee employee = new Employee(fName, lName, eSsn, eWage);
            employeeList.Add(employee);
        }
        public static void RemoveEmployee()
        {
            Console.Clear();
            Employee remove = null;
            Console.WriteLine("Enter employees social security number: ");
            string input = Console.ReadLine();
            foreach (Employee emp in employeeList)
            {
                if (input == emp.ssn)
                {
                    remove = emp;
                    employeeList.Remove(emp);
                }
            }
        }
            public static void PrintEmployeeReg()
        {
            Console.Clear();
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine("Full name: " + emp.firstName + " " + emp.lastName + "\nSocial security number: " + emp.ssn + "\nWage: " + emp.wage);
                Console.ReadKey();
            }
        }
        }
    }

