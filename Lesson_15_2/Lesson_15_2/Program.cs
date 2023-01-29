namespace Lesson_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Запишите число, факториал которого хотите найти");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Factorial(number));
            //Lesson2();
            List<int> input = new List<int>();
            while(true)
            {
                Console.WriteLine("Введите число");
                var inputVal = Console.ReadLine();
                Console.WriteLine("");
                //Проверка на число
                var isInteger = Int32.TryParse(inputVal, out var value);
                if (!isInteger)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ввели не число");
                }
                else
                {
                    input.Add(value);
                }
                Lesson15_2_8(input);
                Console.WriteLine("");
            }
        }

        //Задание 15.2.1
        //Факториал натурального числа n — это произведение всех натуральных целых чисел от 1 до n включительно
        static long Factorial(int number)
        {
            List<int> list = new List<int>();
            // Ваш код здесь
            for (int i = 0; i < number; i++)
            {
                list.Add(i+1);
            }
            long result = list.Aggregate((x,y) => x * y);
            return result;
        }

        //Задание 15.2.2
        //Посчитайте, у скольких из них неверные номера телефонов (верный телефон содержит 11 цифр и начинается с семёрки).
        static void Lesson2 ()
        {
            var contacts = new List<Contact>()
                {
                   new Contact() { Name = "Андрей", Phone = 79994500508 },
                   new Contact() { Name = "Сергей", Phone = 799990455 },
                   new Contact() { Name = "Иван", Phone = 79999675334 },
                   new Contact() { Name = "Игорь", Phone = 8884994 },
                   new Contact() { Name = "Анна", Phone = 665565656 },
                   new Contact() { Name = "Василий", Phone = 3434 }
                };
            var numinvalid = (from c in contacts
                              let phonestring = c.Phone.ToString()
                              where !phonestring.StartsWith("7") || phonestring.Length != 11
                              select c).Count();
            Console.WriteLine(numinvalid);
        }
        
        class Contact
        {
            public string Name { get; set; }
            public long Phone { get; set; }
        }

        //Задание 15.2.8
        //Напишите программу с бесконечным циклом, как в предыдущем юните, которая будет:

        //ожидать ввода числа с клавиатуры(используйте Console.ReadLine());
        //добавлять число в список, хранящийся в памяти;
        //выводить после добавления следующую информацию: количество чисел в списке, сумму всех чисел списка,
        //наибольшее и наименьшее числа, а также их среднее значение.

        static void Lesson15_2_8(List<int> input)
        {
            int lenth = input.Count();
            int sum = input.Sum();
            int max = input.Max();
            int min = input.Min();
            Console.WriteLine("Количество чисел :" + lenth);
            Console.WriteLine("Сумма чисел :" + sum);
            Console.WriteLine("Максимальное число :" + max);
            Console.WriteLine("Минимальное число :" + min);
        }
    }
}