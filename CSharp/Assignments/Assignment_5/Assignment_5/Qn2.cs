using System;

namespace Scholarship
{
    class ScholarshipException : Exception
    {
        public ScholarshipException(string message) : base(message) { }
    }

    class Scholarship
    {
        public void Merit(int Marks, double Fees)
        {
            double ScholarshipAmount = 0;

            if (Marks >= 70 && Marks <= 80)
            {
                ScholarshipAmount = Fees * 0.2;
            }
            else if (Marks > 80 && Marks <= 90)
            {
                ScholarshipAmount = Fees * 0.3;
            }
            else if (Marks > 90)
            {
                ScholarshipAmount = Fees * 0.5;
            }
            else
            {
                throw new ScholarshipException("Not eligible for scholarship");
            }
            Console.WriteLine("Scholarship Amount is " + ScholarshipAmount);
        }
    }

    class Qn2
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Marks: ");
                int Marks = int.Parse(Console.ReadLine());

                Console.Write("Enter Fees: ");
                double Fees = double.Parse(Console.ReadLine());

                Scholarship s = new Scholarship();
                s.Merit(Marks, Fees);
            }
            catch (ScholarshipException Ex)
            {
                Console.WriteLine("Error: " + Ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            Console.Read();
        }
    }
}
