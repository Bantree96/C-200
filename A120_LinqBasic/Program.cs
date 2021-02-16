using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120_LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 }; // 정수 리스트 data를 정의하고 초기화한다.
            List<int> lstSortedEven = new List<int>(); // 정렬된 짝수의 리스트를 정의한다.

            foreach(var item in data)
            {
                // data의 요소 item이 짝수이면 짝수리스트에 추가
                if (item % 2 == 0)
                    lstSortedEven.Add(item); 
            }
            lstSortedEven.Sort(); // 추가 마무리 후 정렬함

            // foreach문을 사용한 리스트 추가 정렬 출력
            Console.WriteLine("Using foreach: ");
            foreach (var item in lstSortedEven)
                Console.Write(item + " ");
            Console.WriteLine();

            // sortedEven형은 이때 IEnumerabe<int>형이 됨.
            var sortedEven = from item in data
                             where item % 2 == 0
                             orderby item
                             select item;

            Console.WriteLine("\nUsing Linq : ");
            foreach (var item in sortedEven)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
