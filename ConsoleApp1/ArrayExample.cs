using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayExample
    {

        public void ArrayExp()
        {
            int[] employeeIds = new int[] { 1, 2, 3 };

            foreach(var item in employeeIds)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Array length : {employeeIds.Length} {Environment.NewLine}  First Employee : {employeeIds.ElementAt(0)}");
        }
    }
}
