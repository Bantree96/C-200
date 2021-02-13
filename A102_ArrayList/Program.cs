using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Random r = new Random();

            PrintValues(a);
            
            for(int i=0; i<10; i++)
            {
                a.Add(r.Next(100)); // 1부터 100까지 랜덤 숫자를 저장
            }
            PrintValues(a);
            
            // ArrayList를 정렬한 후 출력
            a.Sort();
            PrintValues(a);

            // ArrayList에서 3번째 인덱스에 있는것을 삭제 후 출력
            a.RemoveAt(3);
            PrintValues(a);

        }

        static void PrintValues(ArrayList a)
        {
            Console.WriteLine("Print Values in ArrayList");
            Console.WriteLine("Count = {0}", a.Count);
            //Capacity : 용량
            Console.WriteLine("Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
