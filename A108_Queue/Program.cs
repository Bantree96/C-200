using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A108_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Cow");
            que.Enqueue("Rabbit");
            
            PrintQueue("que : ", que);

            Console.WriteLine(" Dequeuing '{0}'", que.Dequeue()); // 맨 앞 출력 후 사라짐
            Console.WriteLine(" Peek : '{0}'", que.Peek()); // 맨 앞 출력 후 사라지지않음

            Queue<string> que2 = new Queue<string>(que.ToArray()); // que를 que2에 복사
            PrintQueue("que2 : ", que2);

            string[] array = new string[que.Count]; // que의 크기로 배열을 만들고 
            que.CopyTo(array,0); // que의 값을 array에 복사

            Queue<string> que3 = new Queue<string>(array); // 배열을 가지고 que3를 만듬
            PrintQueue("que3 : ", que3);

            Console.WriteLine("que.Contains(Lion) = {0}", que.Contains("Lion")); // que에 Lion이 있는지 확인
            que3.Clear(); // que3 비움
            Console.WriteLine($"Count = {que.Count}, {que2.Count}, {que3.Count}");

        }

        private static void PrintQueue(string s, Queue<string> q)
        {
            Console.Write("{0,-8}", s);
            foreach(var item in q)
                Console.Write("{0,-8}", item);
            Console.WriteLine();
        }
    }
}
