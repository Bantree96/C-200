using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A069_Property
{
    class RectwithProp
    {
        // prop을 입력하고 tab두번 치면 자동완성됨
        public double Width { get; set; }
        public double Height { get; set; }
    }
    // 위보단 좀 길어지지만 if문등 다양한 세팅이 가능하다는 장점이있음
    class RectwithPropFull
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
    }
    class PropertyTest
    {
        static void Main(string[] args)
        {
            RectwithProp r = new RectwithProp();
            r.Width = 10.0;
            r.Height = 10.0;
            Console.WriteLine("r의 면적은{0}", r.Width * r.Height);

            RectwithPropFull r2 = new RectwithPropFull();
            r2.Width = 10.0;
            r2.Height = -10.0;
            Console.WriteLine("r의 면적은{0}", r.Width * r2.Height);
        }
    }
}
