internal class Lesson_15
{
    private static void Main()
    {
        // Distinct -- start --
        var numbers = new[] { 1, 2, 3, 2, 4, 4, 5 };

        var distinctNumbers = numbers.Distinct();

        foreach (var number in distinctNumbers)
        {
            Console.WriteLine(number);
        }

        //output: 
        // 1
        // 2
        // 3
        // 4
        // 5


        // Distinct -- end --

        // GroupBy -- start --

        var employees = new[]
        {
            new { Name = "John", Department = "HR" },
            new { Name = "Jane", Department = "Finance" },
            new { Name = "Mike", Department = "IT" },
            new { Name = "Sara", Department = "HR" }
        };

        var grouped = employees.GroupBy(e => e.Department);

        foreach (var group in grouped)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var employee in group)
            {
                Console.WriteLine($"- {employee.Name}");
            }
        }

        // GroupBy -- end --

        // SelectMany -- start --

        var managers = new[]

        {
            new { ManagerName = "John", Employees = new[] { "Mike", "Jane" } },
            new { ManagerName = "Sara", Employees = new[] { "Peter", "Chris" } }
        };

        var allEmployees = managers.SelectMany(m => m.Employees);

        foreach (var employee in allEmployees)
        {
            Console.WriteLine(employee);
        }

        // SelectMany -- end --

        // Join -- start --

        {
            // new { EmployeeId = 1, Name = "John", DepartmentId = 1 },
            // new { EmployeeId = 2, Name = "Jane", DepartmentId = 2 },
            // new { EmployeeId = 3, Name = "Mike", DepartmentId = 3 }
        };

        var departments = new[]
        {
            new { EmployeeId = 1, Department = "HR" },
            new { EmployeeId = 2, Department = "Finance" },
            new { EmployeeId = 3, Department = "IT" }
        };

        //query syntax
        // var result = from e in employees
        //              join d in departments on e.DepartmentId equals d.DepartmentId
        //              select new { e.Name, d.Department };

        // foreach (var item in result)
        // {
        //     Console.WriteLine($"{item.Name} works in {item.Department}");
        // }

        // //lambda syntax
        // var result = employees.Join(departments,
        //                             e => e.DepartmentId,
        //                             d => d.DepartmentId,
        //                             (e, d) => new { e.Name, d.Department });

        // foreach (var item in result)
        // {
        //     Console.WriteLine($"{item.Name} works in {item.Department}");
        // }

        // Join -- end --

    }
}