﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A121_LinqBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };

            Print("data : ", data);

            var lstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;

            Print("20보다 큰 짝수 검색결과 : ", lstEven);

            var lstSorted = from item in lstEven
                            orderby item ascending
                            select item * 2;

            Print("이 값을 2씩 곱해 오름차순 정렬결과 : ", lstSorted);
        }

       
        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var item in data)
                Console.Write(" " + item);
            Console.WriteLine();

        }
    }
}
