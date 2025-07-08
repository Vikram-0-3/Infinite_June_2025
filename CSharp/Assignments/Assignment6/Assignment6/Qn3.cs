using System;
using System.IO;

namespace Files
{
    class Qn3
    {
        static void Main()
        {
            string filePath = "MyName.txt";

            try
            {
                int lineCount = File.ReadAllLines(filePath).Length;
                Console.WriteLine($"The file '{filePath}' contains {lineCount} lines");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file '{filePath}' was not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong-");
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}