using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A098_StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mystack<int> stack = new Mystack<int>();
            Random r = new Random();

            for(int i =0; i< 10; i++)
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.Write($"Push({val}) ");
            }
            Console.WriteLine();

            for(int i=0; i<10; i++)
            {
                Console.Write($"Pop()={stack.Pop()},");
            }
        }
    }
}
