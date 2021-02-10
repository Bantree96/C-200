using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A094_GenericClass
{
    class MyClass<T>
    {
        private T[] arr;
        private int count = 0;

        // 생성자 메소드
        public MyClass(int length)
        {
            arr = new T[length];
            count = length;
        }

        // 매개변수로 받은 값들을 배열로 저장
        public void Insert(params T[] args)
        {
            for (int i = 0; i < args.Length; i++)
                arr[i] = args[i];
        }

        // 객체 arr배열의 요소를 출력
        public void Print()
        {
            foreach (T i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // 
        public T AddAll()
        {
            T sum = default(T); // sum을 default(T)로 초기화
            foreach (T item in arr)
                sum = sum + (dynamic)item; // dynamic변수는 컴파일 시에 형을 체크하지 않아 에러가 나지않는다.
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> a = new MyClass<int>(10);
            MyClass<string> s = new MyClass<string>(5);

            a.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            s.Insert("Tiger", "Lion", "Zebra", "Monkey", "Cow");

            a.Print();
            s.Print();

            Console.WriteLine("a.AddAll() :" + a.AddAll());
            Console.WriteLine("s.AddAll() :" + s.AddAll());
        }
    }
}
