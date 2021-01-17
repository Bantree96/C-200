using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A007_ConsoleWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m;    // m은 decimal형의 접미사
            double e = 1.23456789;
            float f = 1.23456789f; // f는 float형의 접미사
            int i = 1234;
            string s = "Hello";

            Console.WriteLine("bool : " + b);
            Console.WriteLine("char : " + c);
            Console.WriteLine("decimal : " + d);
            Console.WriteLine("double : " + e);
            Console.WriteLine("float : " + f);
            Console.WriteLine("int : " + i);
            Console.WriteLine("string : " + s);


        }
    }
}
