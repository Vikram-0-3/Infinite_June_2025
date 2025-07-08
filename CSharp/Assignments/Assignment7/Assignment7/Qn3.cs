using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public int EmpSalary { get; set; }
    }

    class Qn3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Naveen", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Hari", EmpCity = "Chennai", EmpSalary = 42000 },
            new Employee { EmpId = 3, EmpName = "Vikram", EmpCity = "Bangalore", EmpSalary = 47000 },
            new Employee { EmpId = 4, EmpName = "Yogesh", EmpCity = "Mumbai", EmpSalary = 39000 },
            new Employee { EmpId = 5, EmpName = "Hema", EmpCity = "Bangalore", EmpSalary = 60000 } };

            Console.WriteLine("All Employees :");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.EmpName} - {emp.EmpCity} - {emp.EmpSalary}");
            }

            Console.WriteLine("\n Employees with Salary > 45000 :");
            foreach (var emp in employees.Where(e => e.EmpSalary > 45000))
            {
                Console.WriteLine($"{emp.EmpId} - {emp.EmpName} - {emp.EmpCity} - {emp.EmpSalary}");
            }

            Console.WriteLine("\n Employees from Bangalore :");
            foreach (var emp in employees.Where(e => e.EmpCity == "Bangalore"))
            {
                Console.WriteLine($"{emp.EmpId} - {emp.EmpName} - {emp.EmpCity} - {emp.EmpSalary}");
            }

            Console.WriteLine("\n Employees Sorted by Name :");
            foreach (var emp in employees.OrderBy(e => e.EmpName))
            {
                Console.WriteLine($"{emp.EmpId} - {emp.EmpName} - {emp.EmpCity} - {emp.EmpSalary}");
            }
            Console.Read();
        }
    }

}