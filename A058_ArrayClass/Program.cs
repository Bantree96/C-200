using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A058_ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 }; // 배열을 선언하고 초기화 
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone();   // 배열 복사 방법 1 -> Clone() 메소드는 object를 return함으로 캐스팅해줘야함
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3); // 배열 복사 방법 2 -> a배열의 0번째 인덱스부터 3개의 요소를 c배열의 1번 인덱스 위치에 복사
            PrintArray(c);

            a.CopyTo(c, 3); // 배열 복사 방법 3 -> a배열의 내용을 c배열의 3번 인덱스에 복사함
            PrintArray(a);

            Array.Sort(a);  // 오른차순으로 정렬
            PrintArray(a);

            Array.Reverse(a);   // 내림차순으로 정렬
            PrintArray(a);

            Array.Clear(a, 0, a.Length);    // 배열을 초기화 -> a배열의 0번째 인덱스 부터 a의 길이만큼 0으로 초기화
            PrintArray(a);
        }

        private static void PrintArray(int[] a)
        {
            foreach (var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}
