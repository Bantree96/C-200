using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World! ";
            string t;

            Console.WriteLine("문자열의 길이 : " + s.Length);
            Console.WriteLine("8번째 index : " + s[8]);
            Console.WriteLine("insert : " + s.Insert(8, "C# "));    // 특정 위치에 문자열 삽입
            Console.WriteLine("PadLeft : " + s.PadLeft(20, '.'));   // 앞쪽에 특정문자를 넣어서 문자열의 길이를 맞춤
            Console.WriteLine("PadRight : " + s.PadRight(20, '.')); // 뒷쪽에 특정문자를 넣어서 문자열의 길이를 맞춤
            Console.WriteLine("Remove : " + s.Remove(6));           // n번째 인덱스부터 끝까지 지워줌
            Console.WriteLine("Remove : " + s.Remove(6, 7));        // n번째 인덱스부터 n개의 문자를 지워줌
            Console.WriteLine("Replace : " + s.Replace('l', 'm'));  // 'l'을 'm'으로 바꿔줌
            Console.WriteLine("ToLower : " + s.ToLower());          // 문자열을 대문자로 바꿔줌
            Console.WriteLine("ToUpper : " + s.ToUpper());          // 문자열을 소문자로 바꿔줌
            Console.WriteLine('/' + s.Trim() + '/');                // 앞뒤의 공백문자를 없앰
            Console.WriteLine('/' + s.TrimStart() + '/');           // 앞쪽의 공백문자를 없앰
            Console.WriteLine('/' + s.TrimEnd() + '/');             // 뒤쪽의 공백문자를 없앰

            string[] a = s.Split(',');                              // 문자열을 ,로 구분해 string 배열로만듬
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destinantion = new char[10];
            s.CopyTo(8, destinantion, 0, 6);                        // 문자열의 일부분을 문자배열로 저장 (문자열의 8번째 인덱스 부터, destiantion배열의, 0번쨰로, 6개의 문자를 복사
            Console.WriteLine("destination : " + destinantion);
            Console.WriteLine('/' + s.Substring(8) + '/');          // 문자열의 8번째 index부터 끝까지 return
            Console.WriteLine('/' + s.Substring(8, 5) + '/');       // 문자열의 8번째 index부터 5개의 문자열을 return

            Console.WriteLine(s.Contains("11"));                    // 문자열에 x가 있다면 true를 return
            Console.WriteLine(s.IndexOf('o'));                      // 처음나오는 x의 index번호를 return
            Console.WriteLine(s.LastIndexOf('o'));                  // 맨 마지막으로 나오는 x의 index번호를 return
            Console.WriteLine(s.CompareTo("abc"));                  // 

            Console.WriteLine(String.Concat("Hi~", s));             // 두 개의 문자열을 합쳐줌
            Console.WriteLine(String.Compare("abc", s));            // 
            Console.WriteLine(t = String.Copy(s));                  // 문자열을 복사함

            String[] val = { "apple", "orange", "grape", "pear" };  // 배열의 각 요소를 ','로 연결해 return
            String result = String.Join(", ", val);
            Console.WriteLine("과일 리스트 : " + result);



        }
    }
}
