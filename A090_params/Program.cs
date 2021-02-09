using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A090_params
{
    class Program
    {
        public static void PrintIntParams(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
        public static void PrintObjectParams(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintObjectParams();

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);

            object[] myObjArray = { 2, 2.345, 'b', "test", "again" };
            PrintObjectParams(myObjArray);

            PrintObjectParams(myIntArray); // 배열의 내용을 출력할 수는 없고 myIntArray자체를 object타입의 매개변수 하나로 간주해 출력
        }
    }
}
