using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndRefernce
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);                // Test 메소드 안에서의 s가 변경된거기 때문에 Main은 바뀌지 않음
            Console.WriteLine(s);
            Test(ref s);            // ref키워드에의해 s가 바뀌게 되면 그 주소안에 값이 변경되기 때문에 Main도 바뀜
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after passing";

        }
        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}
