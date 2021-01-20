using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A028_StringContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow"; // s2 = "cow" (2가지로 해볼 수 있음)
            bool b = s1.Contains(s2); // s1에 s2가 있는지 판단.(대소문자 구분)
            Console.WriteLine($"{s2} is in the string '{s1}':{b}");

            // 문자열 찾아 index return, 없으면 -1 return
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine($"{s2} begins at index {index}");

            }

            // s1에 s2가 있는지 판단. (대소문자 구분없음)
            if(s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine($"{s2} is in the string '{s1}'");
            }
        }
    }
}
