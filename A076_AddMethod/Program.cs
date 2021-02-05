using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A076_AddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 100까지의 합 : {0}", Add(1, 100));
            Console.WriteLine("101부터 200까지의 합 : {0}", Add(101, 200));
        }
        private static int Add(int x, int y)
        {
            int sum = 0;
            for(int i=x; i<=y; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
