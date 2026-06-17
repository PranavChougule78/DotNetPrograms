using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstNew
{
    public class Model
    {
        public Model(int id)
        {
            Console.WriteLine("A");
        }
        public Model(string id)
        { Console.WriteLine("B"); }
    }
    }
