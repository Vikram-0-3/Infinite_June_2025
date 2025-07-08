using System;
using System.Linq;

namespace Queries
{
    class Qn2
    {
        static void Main()
        {
            string[] words = { "mum", "amsterdam", "attitude", "algorithm", "bloom", "aim", "anion", "atom" };

            var resultwords = words.Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase));

            foreach (string word in resultwords)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}