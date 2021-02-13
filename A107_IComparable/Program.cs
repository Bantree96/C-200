using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Artists객체의 배열 famousArtists를 생성합니다. 생성자 메소드사용
            Artists[] famousArtists =
            {
                new Artists("레오나르도 다빈치","이탈리아",1452, 1519),
                new Artists("빈센트 반 고흐","네덜란드",1853, 1890),
                new Artists("클로드 모네","프랑스",1840, 1926),
                new Artists("파블로 피카소","스페인",1881, 1973),
                new Artists("베르메르","네덜란드",1632, 1675),
                new Artists("르노아르","프랑스",1841, 1919)
            };

            // Artists객체의 리스트 artists19C를 생성합니다.
            List<Artists> artists19C = new List<Artists>();

            // Birth가 1800보다 크고 1900이해인 객체를 artists19C에 추가
            foreach(var artist in famousArtists)
            {
                if (artist.Birth > 1800 && artist.Birth <= 1900)
                    artists19C.Add(artist);
            }

            // IComparable를 사용하여 정렬
            artists19C.Sort();
            Console.WriteLine("19세기 미술가를 탄생 순 정렬 : IComparable");
            foreach (var a in artists19C)
                Console.WriteLine(a.ToString());
        }
    }

    // 
    class Artists : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth { get; set; }
        public int Die { get; set; }

        // Artists클래스 정의
        public Artists(string name, string country, int birth, int die)
        {
            Name = name;
            Country = country;
            Birth = birth;
            Die = die;
        }

        // obj를 Artists로 캐스팅하고 Birth를 비교하여 return
        public int CompareTo(object obj)
        {
            Artists a = (Artists)obj;
            return this.Birth.CompareTo(a.Birth);
        }

        // ToString 메소드 재정의
        public override string ToString()
        {
            return string.Format($" {Name}, {Country}, {Birth}, {Die} ");
        }
    }
}
