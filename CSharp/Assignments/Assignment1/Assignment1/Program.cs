using System;

namespace Q1
{
    class Assignment1
    {
        static void Main()
        {

            Console.WriteLine("Enter the question number 1 to 5 to check in assignment 1 :");
            char d = Convert.ToChar(Console.ReadLine());

            switch (d)
            {

                case '1':
                    Assignment1 q1 = new Assignment1();
                    q1.EqualCheck();
                    break;

                case '2':
                    Assignment1 q2 = new Assignment1();
                    q2.SignCheck();
                    break;

                case '3':
                    Assignment1 q3 = new Assignment1();
                    q3.MathOperations();
                    break;

                case '4':
                    Assignment1 q4 = new Assignment1();
                    q4.Multiplication();
                    break;

                case '5':
                    Assignment1 q5 = new Assignment1();
                    q5.TripleSum();
                    break;
            }

        }

        public void EqualCheck()
        {

            Console.WriteLine("Enter the first Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine($"{x} and {y} are Equal");
            }
            else
                Console.WriteLine($"{x} and {y} are not Equal");

            Console.Read();

        }

        public void SignCheck()
        {

            Console.WriteLine("Enter the Number");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine($"{x} is a Positive Number");
            }
            else if (x < 0)
            {
                Console.WriteLine($"{x} is a Negative Number");
            }
            else if (x == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else
                Console.WriteLine("Invalid input");

            Console.Read();
        }

        public void MathOperations()
        {

            Console.WriteLine("Enter the first Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Operation to be preformed");
            char y = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (y)
            {

                case '+':
                    Console.WriteLine($"The addition of the two numbers is {x + z}");
                    break;

                case '-':
                    Console.WriteLine($"The Subtraction of the two numbers is {x - z}");
                    break;

                case '*':
                    Console.WriteLine($"The Multiplication of the two numbers is {x * z}");
                    break;

                case '/':
                    Console.WriteLine($"The Division of the first number by second number is {x / z}");
                    break;

                default:
                    Console.WriteLine("Enter Valid Input");
                    break;

            }

            Console.Read();
        }



        public void Multiplication()
        {

            Console.WriteLine("Enter the Number");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                for (int i = 0; i <= 10; i++)
                {

                    Console.WriteLine(x + "*" + i + "=" + x * i);

                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Number");
            }

            Console.Read();
        }

        public void TripleSum()
        {

            Console.WriteLine("Enter the First Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && y >= 0)
            {
                if (x == y)
                {

                    Console.WriteLine($"The triple of their sum is {3 * (x + y)}");

                }

                else
                    Console.WriteLine($"The addition of the two numbers is {x + y}");
            }
            else
            {
                Console.WriteLine("Enter a Valid Number");
            }

            Console.Read();
        }

    }
}
