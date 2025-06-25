using System;
using System.Linq;

namespace Q1
{
    class Assignment2
    {
        static void Main()
        {

            Console.WriteLine("Which category in the assigment do you want  to check");
            Console.WriteLine("1. First 3 questions  2. Arrays  3. Strings, Enter the category number 1/2/3");
            char option = Convert.ToChar(Console.ReadLine());


            switch (option)
            {

                case '1':
                    Console.WriteLine("Which question do you want to check in the first 3 questions ?");
                    int qn = Convert.ToInt32(Console.ReadLine());

                    if (qn == 1)
                    {
                        SwapNumbers();
                    }
                    else if (qn == 2)
                    {
                        FourtimesRow();
                    }
                    else if (qn == 3)
                    {
                        FindDay();
                    }
                    break;


                case '2':
                    Console.WriteLine("Which question do you want to check in the Array Please enter the option 1/2/3 ?");
                    int op = Convert.ToInt32(Console.ReadLine());

                    if (op == 1)
                    {
                        BasicArray();
                    }
                    else if (op == 2)
                    {
                        Marks();
                    }
                    else if (op == 3)
                    {
                        CopyArray();
                    }
                    Console.Read();
                    break;



                case '3':
                    Console.WriteLine("Which question do you want to check in the Strings Please enter the option 1/2/3 ?");
                    int opn = Convert.ToInt32(Console.ReadLine());

                    if (opn == 1)
                    {
                        WordLength();
                    }
                    else if (opn == 2)
                    {
                        WordReverse();
                    }
                    else if (opn == 3)
                    {
                        StringMatch();
                    }
                    Console.Read();
                    break;


                default:
                    Console.WriteLine("Enter a Valid Category Number, Please");
                    break;
            }
            Console.Read();

        }

        public static void SwapNumbers()
        {

            Console.WriteLine("Enter the first Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping x = {x} and y = {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After swapping x = {x} and y = {y}");

            Console.Read();
        }

        public static void FourtimesRow()
        {

            Console.WriteLine("Enter the Number");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                for (int i = 0; i <= 1; i++)
                {

                    Console.WriteLine("{0} {0} {0} {0}", x);
                    Console.WriteLine("{0}{0}{0}{0}", x);

                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Number");
            }
            Console.Read();
        }

        public static void FindDay()
        {

            Console.WriteLine("Enter the Number to find day");
            char x = Convert.ToChar(Console.ReadLine());


            switch (x)
            {

                case '1':
                    Console.WriteLine("Monday");
                    break;

                case '2':
                    Console.WriteLine("Tuesday");
                    break;

                case '3':
                    Console.WriteLine("Wednesday");
                    break;

                case '4':
                    Console.WriteLine("Thursday");
                    break;

                case '5':
                    Console.WriteLine("Friday");
                    break;

                case '6':
                    Console.WriteLine("Saturday");
                    break;

                case '7':
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Enter a Valid number");
                    break;


            }

            Console.Read();
        }


        public static void BasicArray()
        {

            Console.Write("Enter the no. of elements in array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"number {i + 1}: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = num.Average();
            Console.WriteLine($"The average of array is {average}");

            int min = num.Min();
            int max = num.Max();
            Console.WriteLine($"The minimum and maximum of array is {min} and {max} respetively");


            Console.Read();
        }

        public static void Marks()
        {

            Console.Write("Enter the Number of students : ");
            int size = Convert.ToInt32(Console.ReadLine());

            float[] marks = new float[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            float sum = marks.Sum();
            Console.WriteLine($"The sum of marks is {sum}");

            double average = marks.Average();
            Console.WriteLine($"The average of marks is {average}");

            var min = marks.Min();
            var max = marks.Max();
            Console.WriteLine($"The minimum mark and maximum mark is {min} and {max} respetively");



            Console.WriteLine("Marks in ascending order :");
            Array.Sort(marks);
            foreach (int num in marks)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("Marks in descending order :");
            Array.Sort(marks);
            Array.Reverse(marks);
            foreach (int num in marks)
            {
                Console.Write(num + " ");
            }

            Console.Read();
        }

        public static void CopyArray()
        {

            int[] num = new int[5] { 1, 6, 5, 4, 3 };
            int size = num.Length;
            int[] num1 = new int[size-1];

            for (int i = 0; i < num.Length; i++)
            {
                num1.Append(num[i]);
            }

            Console.WriteLine("Copying array...");
            foreach (int n in num)
            {
                Console.Write(n + " ");
            }


            Console.Read();
        }

        public static void WordLength()
        {

            Console.WriteLine("Enter the word :");
            string s = Console.ReadLine();

            Console.WriteLine("The length of your word is " + s.Length);


            Console.Read();
        }

        public static void WordReverse()
        {

            Console.WriteLine("Enter the word :");
            string s1 = Console.ReadLine();
            string s2 = new string(s1.Reverse().ToArray());

            Console.WriteLine("The reversed string is " + s2);


            Console.Read();
        }

        public static void StringMatch()
        {

            Console.WriteLine("Enter the First word :");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the Second word :");
            string s2 = Console.ReadLine();

            if (s1 == s2)
            {

                Console.WriteLine("Both the strings are same");
            }
            else
                Console.WriteLine("Both the strings are not same");

            Console.Read();
        }
    }
}