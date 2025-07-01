using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class Program
{
    static List<Employee> Employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("===== Employee Management Menu =====");
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee Details");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");
            Console.WriteLine("====================================");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1) AddEmployee();
                else if (choice == 2) ViewEmployees();
                else if (choice == 3) SearchEmployee();
                else if (choice == 4) UpdateEmployee();
                else if (choice == 5) DeleteEmployee();
                else if (choice == 6) break;
                else Console.WriteLine("Invalid option");
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }

    static void AddEmployee()
    {
        Employee emp = new Employee();

        Console.Write("Enter ID: ");
        emp.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Department: ");
        emp.Department = Console.ReadLine();

        Console.Write("Enter Salary: ");
        emp.Salary = Convert.ToDouble(Console.ReadLine());

        Employees.Add(emp);
        Console.WriteLine("Employee added");
    }

    static void ViewEmployees()
    {
        foreach (Employee emp in Employees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
        }
    }

    static void SearchEmployee()
    {
        Console.Write("Enter ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Employee emp = Employees.Find(e => e.Id == id);

        if (emp != null)
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
        else
            Console.WriteLine("Employee not found");
    }

    static void UpdateEmployee()
    {
        Console.Write("Enter ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Employee emp = Employees.Find(e => e.Id == id);

        if (emp != null)
        {
            Console.Write("Enter New Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter New Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employee updated");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }

    static void DeleteEmployee()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Employee emp = Employees.Find(e => e.Id == id);

        if (emp != null)
        {
            Employees.Remove(emp);
            Console.WriteLine("Employee deleted");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}
