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
        private int wage;
        private string ssn;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public int Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        public Employee(string firstName, string lastName, string ssn, int wage)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            Wage = wage;
        }
    }
}
