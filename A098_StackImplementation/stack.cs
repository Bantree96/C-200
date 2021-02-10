using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A098_StackImplementation
{
    class Mystack<T>
    {
        const int maxSize = 10;
        private T[] arr = new T[maxSize];
        private int top;

        public Mystack() // 생성자
        {
            top = 0; 
        }

        public void Push(T val)
        {
            if(top < maxSize)
            {
                arr[top] = val;     // 배열에 값 삽입
                ++top;              // 포인터 증가
            }else
            {
                Console.WriteLine("Stack Full");    // 가득차면 출력
                return;
            }
        }

        public T Pop()
        {
            // 포인터가 0보다 크면
            if(top > 0)
            {
                --top;              // 포인터 감소
                return arr[top];    // 배열값 return
            } else
            {
                Console.WriteLine("Stack Empty");
                return default(T);

            }
        }
    }
}
