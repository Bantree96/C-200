using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A082_HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            // 메르센 수는 하노이 탑의 원반을 이동하는 최소의 횟수, 메르센 수를 출력하고 원반 하나를 이동하는데 소요되는 시간을 1초라고 할 때 얼마나걸리는지 출력
            // 메르센 수 2^n - 1
            for(int i=1; i<=50; i++)
            {
                double m = Mersenne(i);
                Console.WriteLine("메르센수({0}) = {1:N0} = {2:N1}일 = {3:N1}년", i, m, m / 3600 / 24, m / 3600 / 24 / 365);
            }

            // 하노이탑 문제
            Console.WriteLine("\nHanoi Tower: {0}, {1}->{2}->{3}", 4, 'A', 'B', 'C');
            Hanoi(4, 'A', 'C', 'B'); // 4개의 원반을 A에서 C를 이용해 B로 이동
        }

        private static double Mersenne(int n)
        {
            return Math.Pow(2, n) - 1;
        }

        // n개의 원반을 from에서 by를 이용하여 to로 이동하는 알고리즘
        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1)
                Console.WriteLine("Move : {0} -> {1}", from, to);
            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine("Move : {0} -> {1}", from, to);
                Hanoi(n - 1, by, to, from);
            }
        }
    }
}
