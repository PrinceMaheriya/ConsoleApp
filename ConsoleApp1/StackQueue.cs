using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StackQueue
    {
         //stack example
        public static void LastInFirstOut()
        {
            Stack st1 = new Stack();
            st1.Push(1);
            st1.Push(2);

            foreach(object item in st1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After removing a element from stack:");

            st1.Pop();

            foreach(object item in st1)
            {
                Console.WriteLine(item);
            }

        }

        public static void LastInLastOut()
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            foreach (object item in qu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After removing a element from queue:");

            qu.Dequeue();

            foreach (object item in qu)
            {
                Console.WriteLine(item);
            }

        }

        //queue example
    }
}
