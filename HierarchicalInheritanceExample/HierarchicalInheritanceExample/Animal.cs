using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritanceExample
{
    public class Animal
    {
        public void AnimalInfo()
        {
            Console.WriteLine("Animal Information");
        }
    }
    public class Elephant
    {
        public void Barking()
        {
            Console.WriteLine("Elephant is Barking");
        }
    }
    public class bird
    {
        public void craw()
        {
            Console.WriteLine(" Bird is Crawing");
        }
    }
    public class bird2 
    {
        public void meewing()
        {
            Console.WriteLine("Bird2  is meewing");
        }
            

            
    }
}
