using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A083_RecursiveBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[30];

            for (int i = 0; i < 30; i++)
                v[i] = r.Next(1000);
            PrintArray("정렬 전", v);

            Array.Sort(v); // 정렬, 이진탐색은 배열이 정렬되어야 합니다.
            PrintArray("정렬 후", v);

            Console.WriteLine("=> 검색할 숫자를 입력하세요 : ");
            int key = int.Parse(Console.ReadLine());

            int index = RecBinarySearch(v, 0, v.Length - 1, key);
            if(index == -1)
            {
                Console.WriteLine("찾는 값이 배열에 없습니다.");
            } else
            {
                Console.WriteLine("v[{0}] = {1}", index, key);
            }
        }

        // 재귀선형탐색 메소드(low:배열의 하한, high:배열의 상한, key 찾고자하는 인덱스값
        private static int RecBinarySearch(int[] v, int low, int high, int key)
        {
            if(low <= high)
            {   
                int mid = (low + high) / 2; // mid : 중간인덱스
                if (key == v[mid])
                    return mid;
                else if (key > v[mid])
                    return RecBinarySearch(v, mid + 1, high, key);
                else
                    return RecBinarySearch(v, low, mid - 1, key);

            }
            return -1;
        }

        // 배열 출력하는 메소드
        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
        }
    }
}
