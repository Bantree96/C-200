using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A072_IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2001년~2100년 사이의 윤년을 찾는 프로그램
            for(int i=2001; i<=2100; i++)
                if (IsLeapYear(i))
                    Console.Write("{0} ", i);
            Console.WriteLine();
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0) || (year % 400 == 0);
        }
    }
}
