


using ClassLibrary1;
using System;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student1 = new (){ Id=123,Name="yael",age=15 };
            Student student2 = new() { Id = 124, Name = "chaya", age = 20 };
            if (student1.CompareTo(student2) == 0)
            {
                Console.WriteLine("תלמיד זהה");
            }
            else {

                Console.WriteLine("תלמיד לא זהה");
            }
            if (student1.Equals(student2))
            {
                Console.WriteLine("התלמידים זהים");
            }
            if (!student1.Equals(student2))
            {
                Console.WriteLine("התלמידים לא זהים");
            }
            List<Student> list = new List<Student>() { student1, student2 };
            Group<Student,Student> gr = new();
            gr.Add(student1);
            gr.Add(student2);
            foreach (Student student in list) {Console.WriteLine(student.Name); }
            Console.WriteLine("count of this group" + gr.Count());
            Console.WriteLine("the first student" + gr[1]);
            gr.RemoveAt(1);
            gr.Clear();
           
            Console.WriteLine("התלמידים נמחקו");
            Console.ReadLine();
        
          
        }
    }
}
