using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A063_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[30];

            for(int i=0; i<30; i++)
                v[i] = r.Next(1000);
            PrintArray("정렬 전", v);

            // (1) 정렬
            Array.Sort(v);
            PrintArray("정렬 후", v);

            Console.Write("=> 검색할 숫자를 입럭하세요: ");
            int key = int.Parse(Console.ReadLine());
            int count = 0; // 비교횟수

            // (2) 선형 탐색
            for(int i = 0; i<v.Length -1; i++)
            {
                count++;
                if(v[i] == key)
                {
                    Console.WriteLine("v[{0}] = {1}", i, key);
                    Console.WriteLine("선형탐색의 비교횟수는 {0}회 입니다.", count);
                    break;

                }
            }

            // (3) 이진 탐색
            count = 0;
            int low = 0;
            int high = v.Length - 1;
            while(low <= high)
            {
                count++;
                int mid = (low + high) / 2;
                if(key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                    Console.WriteLine("이진탐색의 비교횟수는 {0}회 입니다.", count);
                    break;

                } else if(key > v[mid]) // 만약 v[mid]값이 키값보다 작으면 찾고자 하는 값은 mid위쪽에 있으므로 low를 mid+1로 바꾸고 반복문을 다시 실행
                {
                    low = mid + 1;
                } else // 그렇지 않다면 v[mid]값이 키값보다 크다는 뜻이고, 찾고자 하는 값은 mid아래쪽에 있으므로 high를 mid-1로 바꾸고 반복문을 다시 실행
                {
                    high = mid - 1;
                }
            }
        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for(int i = 0; i< v.Length; i++)
            {
                Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
            }
        }
    }
}
