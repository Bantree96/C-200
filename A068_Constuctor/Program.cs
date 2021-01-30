using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A068_Constuctor
{
    class Date
    {
        private int year, month, day;

        // 매개변수 없는 Date() 생성자
        public Date()
        {
            year = 1;
            month = 1;
            day = 1;

        }

        // 매개변수 있는 Date생성자
        public Date (int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2000, 11, 22);
            Date christmas = new Date(2021, 12, 25);
            Date firstDay = new Date(); 

            birthday.PrintDate();
            christmas.PrintDate();
            firstDay.PrintDate();
        }
    }
}
