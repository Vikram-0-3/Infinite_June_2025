using System;
using System.IO;

namespace Files
{
    class Qn2
    {
        static void Main()
        {
            string[] lines = {
            "This is vikram",
            "This is rajan"   };

            string filePath = "MyName.txt";

            try
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine($"The file '{filePath}' has been created and written successfully");
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