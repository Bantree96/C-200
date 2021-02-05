using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A074_PyramidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);

        }

        static void DrawPyramid(int num)
        {
            for(int i=1; i<=num; i++)
            {
                for (int j = i; j < num; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i -1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }   
        }
    }
}
