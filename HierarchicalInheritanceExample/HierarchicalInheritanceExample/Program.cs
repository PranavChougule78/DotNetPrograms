using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Elephant elephant = new Elephant();
            elephant.Barking();

            bird bird = new bird();
            bird.craw();

            Bird Bird2 = new bird();
            bird.meewing();


        }
    }
}
