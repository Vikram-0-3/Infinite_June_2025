using System;

namespace Code_Challenge_1
{
    class Code2
    {
        static void ExchangeChar(string Word) {

            if (Word.Length == 1)
            {

                Console.WriteLine($"The Resultant String is {Word}");

            }
            else {

                string CharFirst = Word.Substring(0, 1);
                string CharLast = Word.Substring(Word.Length - 1, 1);
                string Middle = Word.Substring(1, Word.Length - 2);

                Console.WriteLine($"The Resultant String is {CharLast+Middle+CharFirst}");
            }

        }
        static void Main() {

            Console.WriteLine("Enter the String to exchange the first and last characters:");
            string str = Console.ReadLine();

            Console.WriteLine("Exchanging Characters.......");

            ExchangeChar(str);
            Console.Read();

        }

    }
}
