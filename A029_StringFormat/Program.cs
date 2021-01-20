using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A029_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0}입니다", exchangeRate);
            Console.WriteLine(s);

            // C는 통화방식으로 3자리마다 ,를 넣어줌
            s = String.Format("현재 원달려 환율은 {0:C2}입니다", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t}입니다.", DateTime.Now);
            Console.WriteLine(s);

            // duration은 TimeSpan의 구조체 변수.
            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("소요 시간 : {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}
