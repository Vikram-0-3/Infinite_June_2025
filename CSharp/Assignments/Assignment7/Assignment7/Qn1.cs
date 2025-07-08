using System;
using System.Linq;

namespace Queries
{
    class Qn1
    {
        static void Main()
        {
            int[] numbers = { 7, 2, 30, 22 };

            var result = numbers.Select(n =>new{ Number= n, Square= n * n }).Where(x=>x.Square > 20);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }
            Console.Read();
        }
    }

}
