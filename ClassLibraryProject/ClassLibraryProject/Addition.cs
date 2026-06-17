using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public class Addition
    {
        public int Add(int a, int b)
        {
            return a + b;

        }

        public int Add(int a, int b, int c)
        {
            return Add(a, b, c);
        }

    }
}
