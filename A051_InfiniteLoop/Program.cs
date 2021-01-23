using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A051_InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;  // 총 저금액
            int days = 1; // 몇일 째 인지를 의미
            int money = 1000; // 그 날의 저금액

            // while문으로 만듬
            while (true)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2, 11:C}", days, money, sum);
                if (sum >= 1000000)
                    break;
                days++;
                money *= 2;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);

            // for문으로 만듬(반복할때마다 days++, money*=2로 변경)
            for (sum = 0, days = 1, money = 1000; ; days++, money *= 2)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                    break;

            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
        }
    }
}
