using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A065_ClassAndStruct
{
    struct DateStruct
    {
        public int year, month, day;
    }

    class DateClass
    {
        public int year, month, day;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 구조체
            DateStruct sDay;
            sDay.year = 2021;
            sDay.month = 1;
            sDay.day = 30;
            Console.WriteLine("구조체와 클래스 사용");
            Console.WriteLine("sday: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);

            // 클래스
            DateClass cDay = new DateClass();
            cDay.year = 2021;
            cDay.month = 1;
            cDay.day = 30;
            Console.WriteLine("cday: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);
            Console.WriteLine();



            Console.WriteLine("구조체와 클래스를 초기화");
            // 구조체, 클래스 초기화 값
            DateStruct sDay2 = new DateStruct();
            Console.WriteLine("sDay2: {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day);
            
            DateClass cDay2 = new DateClass();
            Console.WriteLine("cDay2: {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day);
            Console.WriteLine();

            // 구조체, 클래스를 복사하면?
            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("구조체와 클래스를 복사하면?");
            Console.WriteLine("s: {0}/{1}/{2}", s.year, s.month, s.day);
            Console.WriteLine("c: {0}/{1}/{2}", c.year, c.month, c.day);
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);



        }
    }
}
