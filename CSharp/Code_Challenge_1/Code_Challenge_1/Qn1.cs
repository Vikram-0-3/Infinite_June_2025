using System;

namespace Code_Challenge_1
{
    class Code1
    {
        static void RemoveChar(int P , string Word)
        {
            if (P >= 0 && P < Word.Length)
            {
                string Result = Word.Remove(P, 1);
                Console.WriteLine($"The resultant string is {Result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid position within your string length!");
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter the String:");
            string Str = Console.ReadLine();

            Console.WriteLine("Enter the position of character to remove in the above string:");
            int Pos = int.Parse(Console.ReadLine());

            RemoveChar(Pos, Str);
            Console.ReadLine();
        }
    }
}
