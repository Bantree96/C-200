using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A070_StaticMethods
{
    class Methods
    {
        private int Larger(int x, int y)
        {
            return (x >= y) ? x : y;
        }

        private static int Larger2(int x, int y)
        {
            return (x >= y) ? x : y;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Methods x = new Methods();  // Methods 클래스의 객체를 x로 생성합니다.
            Console.WriteLine("가장 큰 수는 {0}", x.Larger(x.Larger(a,b),c));

            // Larger2는 스태틱으로 선언해 객체 없이 사용가능
            Console.WriteLine("가장 큰 수는 {0}", Larger2(Larger2(a, b), c));
        }
    }
}
