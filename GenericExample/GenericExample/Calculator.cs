using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class Calculator
    {
        public T Add<T>(T firstNumber , T secondNumber)
        {
            dynamic dynamicfirstNumber = firstNumber;
            dynamic dynamicsecondNumber = secondNumber;
            return dynamicfirstNumber + dynamicsecondNumber;
        }
    }
}
