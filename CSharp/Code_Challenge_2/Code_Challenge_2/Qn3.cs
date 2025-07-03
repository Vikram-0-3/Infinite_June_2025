using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    using System;

    class Qn3
    {
        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("Negative number not allowed");
            }
            Console.WriteLine("You entered: " + number);
            Console.Read();
        }

        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int no = Convert.ToInt32(Console.ReadLine());

                try
                {
                    CheckNumber(no);
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: " + error.Message);
                }
                Console.Read();
            }
        }
    }

}
