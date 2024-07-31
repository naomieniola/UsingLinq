using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int total = Enumerable.Range(1, 10).Sum(); // sum the range of numbers

        // result
        Console.WriteLine($"The sum of numbers from 1 to 10 is: {total}");
 

/* var squares = from num in Enumerable.Range(1, 5)
               select num * num;

 //foreach (var square in squares)
 //{
 //    Console.WriteLine(square);
 //}

 for (int i = 0; i < squares.Count(); i++)
 {
     Console.WriteLine($"{}");
 }
*/


var employees = new[] { new { Id = 1, Name = "Alice" }, new { Id = 2, Name = "Bob" }};

        var departments = new[] { new { Id = 1, Name = "HR" }, new { Id = 2, Name = "IT" }};

        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.Name}");
        }

        foreach (var department in departments)
        {
            Console.WriteLine($"Department ID: {department.Id}, Name: {department.Name}");
        }

        var employeeDepts = from e in employees
                            join d in departments on e.Id equals d.Id
                            select new {e.Name, Department = d.Name};
        /*
        
        //var number = new[] { 1, 2, 3, 4 , 5, 6,
        var number = Enumerable.Range(1, 23).ToArray();

        // Group numbers by their parity (even or odd)
        var groupByParity = from num in number
                            group num by num % 2 into g
                            select new { Key = g.Key, Numbers = g };

        // Print the grouped numbers
        foreach (var group in groupByParity)
        {
            Console.WriteLine(group.Key == 0 ? "Even numbers:" : "Odd numbers:");
            foreach (var num in group.Numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    


var orderedNames = from name in new[] { "Naomi", "Joseph", "Pai", "Ameer", "George", "Sam" }
                           orderby name
                           select name;


        foreach (var name in orderedNames)
        {
            Console.WriteLine($"{name}");
        }

        List<string> l = new List<string> { "Naomi", "Joseph", "Pai", "Ameer", "George", "Sam" };
        l.Sort();
    }
}
       /* public static void Main(string[] args)
        {
            var evenNumbers = from num in Enumerable.Range(1, 10)
                              where num % 2 == 0
                              select num;

            foreach (var evenNumber in evenNumbers)
            {
                // Print each number followed by a comma and space
                Console.Write($"{evenNumber}, ");
            }
         */
    }
}
      

/*public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}
*/