using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryEncapsulation
{
    using System;

    class Employee
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;

            }
        }
    }

}
