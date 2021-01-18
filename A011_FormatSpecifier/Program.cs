using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A011_FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine("{0:F3}", 1234.56);
            Console.WriteLine("{0:8}", 1234);
            Console.WriteLine("{0,-8}", 1234);

            Console.WriteLine("-------------------------");
            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);
            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);
            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s);

            Console.WriteLine("-------------------------");
            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("-------------------------");
            float num;
            num = 1234.5678f;
            Console.WriteLine("{0:#.##}", num);
            Console.WriteLine("{0:0,0.00}", num);
            Console.WriteLine("{0:#,#.##}", num);
            Console.WriteLine("{0:000000.00}", num);

            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);

        }
    }
}
