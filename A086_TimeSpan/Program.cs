using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A086_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime christmas = new DateTime(2021, 12, 25);
            DateTime newYearsDay = new DateTime(2022, 1, 1);

            TimeSpan span = newYearsDay - christmas;
            // TimeSpan span = newYearsDay.Subtract(christmas);

            Console.WriteLine("크리스마스와 1월1일의 시간 간격");
            Console.WriteLine("{0,14} 일", span.Days);
            Console.WriteLine("{0,14} 시간", span.Hours);
            Console.WriteLine("{0,14} 분", span.Minutes);
            Console.WriteLine("{0,14} 초", span.Seconds);
            Console.WriteLine("{0,14} 밀리세컨드", span.Milliseconds);

            Console.WriteLine("또는");
            Console.WriteLine("{0,14} 일", span.TotalDays);
            Console.WriteLine("{0,14} 시간", span.TotalHours);
            Console.WriteLine("{0,14} 분", span.TotalMinutes);
            Console.WriteLine("{0,14} 초", span.TotalSeconds);
            Console.WriteLine("{0,14} 밀리세컨드", span.TotalMilliseconds);
            Console.WriteLine("{0,14} 틱", span.Ticks);


        }
    }
}
