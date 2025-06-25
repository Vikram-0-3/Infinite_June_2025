using System;
using System.Linq;

namespace School
{
    class Student
    {
        public int Rollno;
        public string Name;
        public string Class;
        public int Semester;
        public string Branch;
        public string Result;
        public double Average;
        int[] Marks = new int[5];

        public Student(int Rno, string Name, string Cls, int Sem, string Branch)
        {
            this.Rollno = Rno;
            this.Name = Name;
            this.Class = Cls;
            this.Semester = Sem;
            this.Branch = Branch;
        }

        public void GetMarks()
        {
            for (int I = 0; I < 5; I++)
            {
                Console.WriteLine($"Enter the mark {I + 1}");
                Marks[I] = int.Parse(Console.ReadLine());
            }
        }

        public void AverageMarks()
        {
            Average = Marks.Average();

            Result = "Passed";

            for (int I = 0; I < Marks.Length; I++)
            {
                if (Marks[I] < 35 || Average < 50)
                {
                    Result = "Failed";
                    break;
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Student RollNo : {Rollno}");
            Console.WriteLine($"Student Class : {Class}");
            Console.WriteLine($"Student Branch : {Branch}");
            Console.WriteLine($"Student Average Marks : {Average}");
            Console.WriteLine($"Student Result : {Result}");
            Console.WriteLine("*****************************");
        }
    }

    class program2 {

        public static void Main()
        {
            Console.WriteLine("Enter Student Name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Student Roll Number :");
            int Rno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Class :");
            string Cls = Console.ReadLine();
            Console.WriteLine("Enter Student Semester :");
            int Sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Branch :");
            string Branch = Console.ReadLine();

            Student S = new Student(Rno, Name, Cls, Sem, Branch);
            S.GetMarks();
            S.AverageMarks();
            S.DisplayData();

            Console.ReadLine();
        }


    }
}
