using System;
using System.IO;

namespace File
{
    class Code3
    {
        static void Main()
        {
            Console.WriteLine("Enter the File name - ");
            string File = Console.ReadLine();
            Console.Write("Enter text - ");
            string s = Console.ReadLine();

            StreamWriter Writer = new StreamWriter(File, true);
            Writer.WriteLine(s);
            Writer.Close();
            
            Console.WriteLine("Text added to the file.");
            Console.Read();
        }
    }
}
