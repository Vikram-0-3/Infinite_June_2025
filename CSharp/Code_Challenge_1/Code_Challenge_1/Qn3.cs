using System;

namespace Code_Challenge_1
{
    class Code3
    {
        static void LargestNum(int a, int b, int c) {

            if (a > b && a > c) {
                Console.WriteLine($"The Largest number is {a} ");
            }
            else if (b > c)
            {
                Console.WriteLine($"The Largest number is {b} ");
            }
            else
            {
                Console.WriteLine($"The Largest number is {c} ");
            }

        }

        static void Main() {

            Console.WriteLine("Enter the First Number :");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number :");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third Number :");
            int n3 = int.Parse(Console.ReadLine());

            LargestNum(n1, n2, n3);
            Console.Read();

        }
    }
}
