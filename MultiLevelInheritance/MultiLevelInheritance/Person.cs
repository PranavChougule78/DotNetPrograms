
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor Called");
        }
        public void PersonInfo()
        {
            Console.WriteLine("This is person class");
        }
    }
    public class Employee : Person
    {
        public void EmployeeInfo()
        {
            Console.WriteLine("This is employee class");
        }
    }
    public class Manager : Employee
    {
        public void ManagerInfo()
        {
            Console.WriteLine("This is Manager Class");
        }
    }
}
