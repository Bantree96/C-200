using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A114_AnonymousDelegate
{
    class Program
    {
        delegate bool MemberTest(int x);
        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            // 델리게이트 메소드를 이름없이 인라인으로 직접 정의함.
            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine("짝수의 개수 : {0}", n);
            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine("홀수의 개수 : {0}", n);

        }

        private static int Count(int[] arr, MemberTest testMethod)
        {
            int cnt = 0;
            foreach(var n in arr)
            {
                if (testMethod(n))
                    cnt++;

            }
            return cnt;
        }
    }
}
