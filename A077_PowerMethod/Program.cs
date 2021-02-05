using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A077_PowerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));
        }
        private static int Power(int x, int y)
        {
            int p = 1;
            for (int i = 1; i<= y; i++)
                p *= x;
            return p;
        }
    }
}
