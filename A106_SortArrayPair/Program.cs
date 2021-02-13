using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A106_SortArrayPair
{
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse" };
            string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐" };
            Display("정렬 전", animalsEn, animalsKo);

            Array.Sort(animalsEn, animalsKo);
            Display("정렬 후", animalsEn, animalsKo);

            IComparer revCom = new ReverseComparer();
            Array.Sort(animalsEn, animalsKo, revCom);
            Display("내림차순 정렬 후", animalsEn, animalsKo);
        }

        static void Display(string cmt, string[] a1, string[] a2)
        {
            Console.WriteLine(cmt);
            for(int i=0; i<a1.Length; i++)
            {
                Console.WriteLine(" [{0}]: {1,-8} {2,-8}", i, a1[i], a2[i]);
            }
            Console.WriteLine();
        }
    }
}
