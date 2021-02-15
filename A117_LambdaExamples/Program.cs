using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A117_LambdaExamples
{
    class Program
    {
        delegate double CalcMethod(double a, double b);
        delegate bool IsTeenAger(Student student);
        delegate bool IsAdult(Student student);

        static void Main(string[] args)
        {
            // square는 하나의 정수를 매개변수로하고 return값이 정수인 Func 델리게이트
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            // 정수배열의 각 요소를 제곱해 할당한 후 합쳐서 출력
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            // Action 델리게이트로 line() = Console.WriteLine()은 같다.
            Action line = () => Console.WriteLine();
            line();

            CalcMethod add = (a, b) => a + b;
            CalcMethod subtract = (a, b) => a - b;

            Console.WriteLine(add(10, 20));
            Console.WriteLine(subtract(10.5, 20));

            IsTeenAger isTeen = delegate (Student s) { return s.Age > 12 && s.Age < 20; };
            Student s1 = new Student() { Name = " John", Age = 18 };

            Console.WriteLine("{0}은 {1}.", s1.Name, isTeen(s1) ? "청소년입니다" : "청소년이 아닙니다.");

            IsAdult isAdult = (s) =>
            {
                int adultAge = 18;
                return s.Age >= adultAge;
            };

            Student s2 = new Student() { Name = "Robin", Age = 20 };
            Console.WriteLine("{0}은 {1}.", s2.Name, isAdult(s2) ? "성인입니다" : "성인이 아닙니다.");

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
