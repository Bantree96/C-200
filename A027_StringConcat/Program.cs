using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            // 1. +를 사용한 문자열 처리
            string strPlus = "Hello " + userName + " .Today is " + date + ".";
            Console.WriteLine(strPlus);

            // 2. Format을 사용한 문자열 처리
            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            // 3. 보간을 사용한 문자열 처리
            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);

            // 4. Concat, Join을 사용한 문자열 처리
            string strConcat = String.Concat("Hello ", userName, ". Today is ", date);
            Console.WriteLine(strConcat);

            string[] animal = { "mouser", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animal);
            Console.WriteLine(s);

            s = String.Join(", ", animal);
            Console.WriteLine(s);


        }
    }
}
