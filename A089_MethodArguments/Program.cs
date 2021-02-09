using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A089_MethodArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine("Value: {0}", a); // return 받은게 아니기때문에 기존의 3이 출력된다.

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref: {0}", b); // return 하지않아도 참조된 값이 변했기 때문에 9가 출력된다.

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out: {0} {1}", name, id);
        }

        private static void Sqr(int x)
        {
            x = x * x;
        }

        private static void Sqr(ref int x)
        {
            x = x * x;
        }
        

        private static void GetName(out string name, out int id)
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter id: ");
            id = int.Parse(Console.ReadLine());
        }
    }
}
