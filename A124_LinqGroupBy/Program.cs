using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124_LinqGroupBy
{
    // Student 클래스의 정의
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }
    class Program
    {
        static List<Student> students;
        static void Main(string[] args)
        {
            students = new List<Student>
            {
            new Student { Name="PjKim", Id = 190001001, Scores=new List<int>{86,90,76 } },
            new Student { Name="BsKim", Id = 190001002, Scores=new List<int>{56,92,93 } },
            new Student { Name="YsCho", Id = 190001003, Scores=new List<int>{69,85,75 } },
            new Student { Name="BiKang", Id = 190001004, Scores=new List<int>{88,80,57 } }
            };

            var result = from student in students
                         group student by student.Scores.Average() >= 80 into g
                         select new
                         {
                             key = g.Key == true ? "80점 이상" : "80점 미만",
                             count = g.Count(),
                             avr = g.Average(student => student.Scores.Average()),
                             max = g.Max(Student => Student.Scores.Average())
                         };

            foreach(var item in result) 
            {
                Console.WriteLine("{0} : 학생수 = {1}", item.key, item.count);
                Console.WriteLine("{0} : 평균 점수 = {1:F2}", item.key, item.avr);
                Console.WriteLine("{0} : 최고 점수 = {1:F2}", item.key, item.max);
                Console.WriteLine();
            }
        }
        private static void HighScore(int exam, int cut)
        {
            var highScores = from student in students
                             where student.Scores[exam] >= cut
                             select new { Name = student.Name, Score = student.Scores[exam] };
            Console.WriteLine($"{exam + 1}번째 시험에서 {cut} 이상의 점수를 받은 학생");
            foreach (var item in highScores)
                Console.WriteLine($"\t{item.Name,-10}{item.Score}");
        }
        private static void Print(List<Student> data)
        {
            foreach (var item in data)
            {
                Console.Write($"{item.Id,-10}{item.Name,-10}");
                foreach (var score in item.Scores)
                    Console.Write($"{score,-5}");
                Console.WriteLine(item.Scores.Average().ToString("F2"));
            }
        }
    }
}
