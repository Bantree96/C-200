using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A055_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int primes = 0;

            // 바깥 for문 2~1000까지 반복
            for(int i=2; i<1000; i++)
            {
                // 안쪽 for문 index가 2~(i-1)개 까지 반복한다
                for(index = 2; index<i; index++)
                {
                    if (i % index == 0)
                        break;
                }
                if (index == i) // i가 소수라면
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n" : ""); // 조건연산자를 사용해 15개마다 \n으로 한줄을 만듬
                }
            }
            Console.WriteLine("\n2부터 1000사이의 소수의 개수 : {0}개", primes);
        }
    }
}
