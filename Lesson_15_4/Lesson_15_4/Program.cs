namespace Lesson_15_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 15.4.1
            //Есть база данных с двумя коллекциями, одна содержит список отделов:
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };
            //Другая — список работающих в них людей:
            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };
            //Соедините данные и выведите на экран, кто работает в каком отделе.

            var reslts = from employee in employees
                         join department in departments
                         on employee.DepartmentId equals department.Id
                         select new
                         {
                             Name = employee.Name,
                             DepName = department.Name
                         };
            //foreach (var department in reslts)
            //{
            //    Console.WriteLine($"{department.Name} - {department.DepName}");
            //}

            //Задание 15.4.2
            //Теперь сгруппируйте сотрудников по отделам, выведя на экран последовательно сначала название отдела, а затем список его сотрудников:

            var results2 = departments.GroupJoin(employees,
                d => d.Id,
                emp => emp.DepartmentId,
                (d, emp) => new
                {
                    NameDep = d.Name,
                    NameEmp = emp.Select(emp => emp.Name)
                });
            foreach(var result in results2)
            {
                Console.WriteLine($"{result.NameDep}" + ":");
                foreach (var e in result.NameEmp)
                {
                    Console.WriteLine(e);
                }
            }
        }

        class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Employee
        {
            public int DepartmentId { get; set; }
            public string Name { get; set; }
            public int Id { get; set; }
        }


    }
}