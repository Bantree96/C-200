using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A036_NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물이름 : ");
            } while ((animal = Console.ReadLine()) != "");
        }

        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4) // 이렇게 사용 하면 animal != null && animal.Length > 4 이것과 같다
                Console.WriteLine($"{animal} : {animal.Length}");
        }
    }
}
