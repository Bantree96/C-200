using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A030_GroupSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("표시할 숫자를 입력하세요(종료 : -1) : ");
                string s = Console.ReadLine();
                double v = double.Parse(s);

                if(v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));
            }
        }

        // 숫자를 그룹 분리자가 포함된 문자열로 return
        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0; // 아래자리수를 의미하는 변수
            double v = Double.Parse(s);

            // 소숫점이 있는지 검사해 있다면 
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');             // 소숫점 앞자리 까지의 index ex) 12.345 -> index : 4
                string formatStr = "{0:N" + (pos - 1) + "}"; // 소숫점 끝까지 format
                s = string.Format(formatStr, v);
            } else
            {
                s = string.Format("{0:N0}", v);
            }
            return s;
        }
    }
}
