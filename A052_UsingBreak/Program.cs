using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A052_UsingBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = default;

            // (1) 
            for (int i = 1; ; i++)
            {
                sum += i;
                if(sum >= 10000)
                {
                    Console.WriteLine("1~{0}의 합은 = {1}", i, sum);
                    break;
                }

            }

            // (2)
            sum = 0;
            int index = 1; // 반복문이 끝났을때 출력하기 위해 index를 밖에다 선언함
            for (; sum < 10000; index++)
            {
                sum += index;
            }
            Console.WriteLine("1~{0}의 합은 = {1}", index - 1, sum); // index값이 sum에 더해진 값보다 하나 큰값이기 때문에 -1 해줌
        }
    }
}
