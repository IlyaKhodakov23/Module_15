using System.Linq;

namespace Module_15_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Есть список учеников школы с разбивкой по классам:
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

        }
        //Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
        static List<string> GetAllStudents(Classroom[] classes)
        {
            List<string> students = new List<string> ();
            var result = from student in classes
                         select student.Students;

            foreach (var student in result)
            {
                foreach (var s in student)
                {
                    students.Add(s);
                }
            }
            return students;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}