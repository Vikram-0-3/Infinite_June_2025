using System;
using TravelLibrary;

class Qn4
{
    const int TotalFare = 500;

    static void Main(string[] args)
    {
        Console.Write("Enter Name - ");
        string name = Console.ReadLine();

        Console.Write("Enter Age - ");
        int age = Convert.ToInt32(Console.ReadLine());

        TravelConcession concession = new TravelConcession();
        string result = concession.CalculateConcession(name, age, TotalFare);

        Console.WriteLine(result);
        Console.Read();
    }
}
