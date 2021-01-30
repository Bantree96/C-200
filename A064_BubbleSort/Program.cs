using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A064_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArray(v);

            for(int i=4; i>0; i--)
            {
                for(int j =0; j<i; j++)
                    // 앞쪽 값이 뒤쪽값보다 크면 두 요소를 교환함ㅞ
                    if(v[j] > v[j + 1])
                    {
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                    }
                PrintArray(v);
            }
        }

        private static void PrintArray(int[] v)
        {
            foreach (var i in v)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}
