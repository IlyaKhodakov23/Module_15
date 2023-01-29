using static System.Net.Mime.MediaTypeNames;

namespace Lesson_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 15.1.4
            //Напишите метод для поиска общих букв в двух словах.
            string firstword = "FirstWord";
            string secondword = "SecondWord";
            var unionword = firstword.Intersect(secondword);
            //foreach (var word in unionword)
            //    Console.WriteLine(word);
            //Задание 15.1.5
            //Напишите недостающий код так, чтобы на выходе мы получили список всех IT - компаний без повторений.
            var softwareManufacturers = new List<string>()
                {
                   "Microsoft", "Apple", "Oracle"
                };

            var hardwareManufacturers = new List<string>()
                {
                   "Apple", "Samsung", "Intel"
                };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            //Задание 15.1.6
            //Напишите программу, которая будет принимать на вход строку текста с консоли(конструкция Console.Readline()) и
            //выводить в ответ список содержащихся в строке уникальных символов без пробелов и следующих знаков препинания: , . ; :  ? !.
            var text = Console.ReadLine();
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            var nodublicate = noPunctuationText.Distinct();
            foreach (var c in nodublicate)
                Console.WriteLine(c);
        }
    }
}