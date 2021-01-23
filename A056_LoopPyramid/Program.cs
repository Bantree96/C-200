using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A056_LoopPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) 별찍기 - 별이 1개씩 늘어남
            for(int i =1; i<=5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("---------------");

            // (2) 별찍기 - 별이 2개씩 늘어남
            for (int i=1; i<=5; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();

            }
            Console.WriteLine("---------------");

            // (3) 별찍기 - 별이 1개씩 줄어듬
            for(int i =5; i>=1; i--) {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();

            }
            Console.WriteLine("---------------");

            // (4) 별찍기 - 4,3,2,1
            for(int i=1; i<=5; i++)
            {
                for(int j = 1; j<=5-i; j++) 
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("---------------");

            // (5) 별찍기 - 진짜 피라미드
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("---------------");

            // (6) 별찍기 - 역피라미드
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
        }
    }
}
