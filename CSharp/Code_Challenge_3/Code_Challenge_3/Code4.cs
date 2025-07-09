using System;

namespace delegation
{
    delegate int CalciDelegate(int Number1, int Number2);
    class Calculator
    {
        public int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        public int Subtract(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        public int Multiply(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        public void PerformOperation(int Number1, int Number2, CalciDelegate Operation)
        {
            int Result = Operation(Number1, Number2);
            Console.WriteLine("Result: " + Result);
        }
    }

    class Code4
    {
        static void Main()
        {
            Calculator c = new Calculator();

            Console.Write("Enter the first number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition:");
            c.PerformOperation(Number1, Number2, c.Add);

            Console.WriteLine("Subtraction:");
            c.PerformOperation(Number1, Number2, c.Subtract);

            Console.WriteLine("Multiplication:");
            c.PerformOperation(Number1, Number2, c.Multiply);

            Console.Read();
        }
    }
}