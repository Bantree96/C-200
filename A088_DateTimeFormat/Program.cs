using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // CultureInfo

namespace A088_DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy년 MM월 dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 MM월 dd일}", today));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine("d (축약된 날짜 형식) : " + today.ToString("d"));
            Console.WriteLine("D (긴 날짜 형식) : " + string.Format("{0:D}", today));
            Console.WriteLine("t (축약된 시간 형식) : " + string.Format("{0:t}", today));
            Console.WriteLine("T (긴 시간 형식) : " + string.Format("{0:T}", today));
            Console.WriteLine("g (일반 날짜 및 시간-초생략) : " + string.Format("{0:g}", today));
            Console.WriteLine("G (일반 날짜 및 시간) : " + string.Format("{0:G}", today));
            Console.WriteLine("f (Full 날짜 및 시간-초생략) : " + string.Format("{0:f}", today));
            Console.WriteLine("F (Full 날짜 및 시간) : " + string.Format("{0:F}", today));
            Console.WriteLine("s (ISO 8601 표준-밀리초 생략) : " + string.Format("{0:s}", today));
            Console.WriteLine("o (ISO 8601 표준) : " + string.Format("{0:o}", today));
            Console.WriteLine("r (UTC로 표시) : " + string.Format("{0:r}", today));
            Console.WriteLine("u (UTC로 출력) : " + string.Format("{0:u}", today));
        }
    }
}
