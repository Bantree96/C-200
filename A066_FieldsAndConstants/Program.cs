using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A066_FieldsAndConstants
{
    class Product
    {
        public string name;
        public int price;
    }
    class MyMath
    {
        public static double PI = 3.14;
    }
    // MyCalendar class에 대한 정의 ( 상수는 만들고 반드시 초기화를 해줘야함 )
    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price);
            Console.WriteLine("원주율: {0}", MyMath.PI); // PI는 static이므로 객체를 생성하지 않고 바로사용함
            Console.WriteLine("한 달은 평균{0:F3}일", MyCalendar.daysPerMonth); // 상수는 static 키워드가 없지만 객체를 생성하지 않고 클래스 이름으로 바로 사용가능
            
        }
    }
}
