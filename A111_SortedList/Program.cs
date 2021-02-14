using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A111_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(3, "Three");
            s1.Add(4, "Four");
            s1.Add(1, "One");
            s1.Add(2, "Two");

            for (int i = 0; i < s1.Count; i++)
                Console.WriteLine("k : {0}, v : {1}", s1.Keys[i], s1.Values[i]);

            foreach (var kvp in s1)
                Console.Write("{0, -10} ", kvp);
            Console.WriteLine();

            // 키가 string이고 값이 int인 s2 생성
            SortedList<string, int> s2 = new SortedList<string, int>();
            s2.Add("One", 1);
            s2.Add("Two", 2);
            s2.Add("Three", 3);
            s2.Add("Four", 4);

            Console.WriteLine(s2["Two"]);

            // 사전식으로 정렬되어 four, one, three, two순으로 출력됨.
            foreach (var kvp in s2)
                Console.Write("{0, -10}", kvp);
            Console.WriteLine();


            int val;
            // TryGetValue 메소드 : "Ten"을 키로하는 값이 있으면 변수 val에 값을 저장하고 true를 return
            if (s2.TryGetValue("Ten", out val))
                Console.WriteLine("key : Ten, value : {0}", val);
            else
                Console.WriteLine("[Ten] : key is not valid.");

            if (s2.TryGetValue("One", out val))
                Console.WriteLine("key : One, value : {0}", val);

            // 매개변수를 키로 하는 요소가 있다면
            Console.WriteLine(s2.ContainsKey("One"));
            Console.WriteLine(s2.ContainsKey("Ten"));
            // 매개변수를 값으로 하는 요소가 있다면
            Console.WriteLine(s2.ContainsValue(2));
            Console.WriteLine(s2.ContainsValue(6));

            s2.Remove("One"); // 키가 "one"인 요소 삭제
            s2.RemoveAt(0); // 첫번째 요소 삭제

            foreach (KeyValuePair<string, int> kvp in s2)
                Console.Write("{0, -10}", kvp);
            Console.WriteLine();
        }
    }
}
