using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FunctionExample
    { 
        public void refExample(ref string name)
        {
            name = "Prince ref example";
        }

        public void outExample(out string name)
        {
            name = "Prince out example";
        }
    }
}
