using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A112_Indexer
{
    class MyCollection<T>
    {
        private T[] array = new T[100];

        // 인덱서 정의 -> 배열이 아닌데 배열처럼 쓸수있게만들어준다
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myString = new MyCollection<string>();
            myString[0] = "Hello, World!";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexer";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(myString[i]);

        }
    }
}
