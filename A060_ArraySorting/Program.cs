using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A060_ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort : ", name);
            Console.WriteLine();
            
            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
            Console.WriteLine();

            Array.Sort(name);
            PrintArray("After Sort: ", name);
            Console.WriteLine();

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
            Console.WriteLine();

        }

        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name)
                Console.Write("{0} ", n);
            Console.WriteLine();
        }
    }
}
