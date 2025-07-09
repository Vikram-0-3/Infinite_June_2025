using System;

namespace Cricket
{
    class CricketTeam
    {
        public void PointsCalculation(int NoOfMatches)
        {
            int Total = 0;
            for (int Match = 1; Match <= NoOfMatches; Match++)
            {
                Console.Write($"Enter score for match {Match}: ");
                int Score = Convert.ToInt32(Console.ReadLine());
                Total = Total + Score;
            }
            double Average = (double)Total / NoOfMatches;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total Matches: " + NoOfMatches);
            Console.WriteLine("Sum of Scores: " + Total);
            Console.WriteLine("Average Score: " + Average);
            Console.WriteLine("-----------------------------------");
        }
    }

    class Code1
    {
        static void Main()
        {
            CricketTeam c = new CricketTeam();
            Console.Write("Enter number of matches: ");
            int NoOfMatches = Convert.ToInt32(Console.ReadLine());
            c.PointsCalculation(NoOfMatches);
            Console.Read();
        }
    }

}