using System;

namespace Code_Challenge_2

{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool IsPassed(double Grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double Grade)
        {
            return Grade >= 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double Grade)
        {
            return Grade >= 80.0;
        }
    }

    class Qn1
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter U for Undergraduate or G for Graduate:");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "U")
                {
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Student ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Grade:");
                    double grade = Convert.ToDouble(Console.ReadLine());

                    Undergraduate student = new Undergraduate();
                    student.Name = name;
                    student.StudentId = id;
                    student.Grade = grade;

                    Console.WriteLine(student.Name + " Passed: " + student.IsPassed(student.Grade));
                    Console.WriteLine("===========================================================");
                }
                else if (choice == "G")
                {
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Student ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Grade:");
                    double grade = Convert.ToDouble(Console.ReadLine());

                    Graduate student = new Graduate();
                    student.Name = name;
                    student.StudentId = id;
                    student.Grade = grade;

                    Console.WriteLine(student.Name + " Passed: " + student.IsPassed(student.Grade));
                    Console.WriteLine("===========================================================");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}