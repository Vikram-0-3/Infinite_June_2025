namespace TravelLibrary
{
    public class TravelConcession
    {
        public string CalculateConcession(string name, int age, int totalFare)
        {
            if (age <= 5)
            {
                return $"{name} - Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double concessionFare = totalFare * 0.7;
                return $"{name} - Senior Citizen - Fare: {concessionFare}";
            }
            else
            {
                return $"{name} - Ticket Booked - Fare: {totalFare}";
            }
        }
    }
}
