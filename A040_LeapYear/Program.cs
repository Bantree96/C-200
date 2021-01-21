using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A040_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // 윤년은 4로 나누어지고 100으로 나누어지지 않거나, 400으로 나누어지는 연도
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);

            if (DateTime.IsLeapYear(year))
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);
        }
    }
}
