using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A110_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            colorTable.Add("Red", "빨강색");
            colorTable.Add("Green", "초록색");
            colorTable.Add("Blue", "파랑색");

            foreach (var item in colorTable)
                Console.WriteLine("colorTable[{0}] = {1}", item.Key, item.Value);

            // 중복되는 키를 추가할 때 예외
            try
            {
                colorTable.Add("Red", "빨강");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            // 없는 키를 출력을 원할 때 예외
            try
            {
                Console.WriteLine("Yellow => {0}", colorTable["Yellow"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n" + colorTable["Red"]);
            Console.WriteLine(colorTable["Green"]);
            Console.WriteLine(colorTable["Blue"]);

        }
    }
}
