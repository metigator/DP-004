namespace StrategyDesignPattern.Before;

public class FlightNavigationStrategy : INavigationStrategy
{
    public Route Navigate(string origin, string destination)
    {
        // complex logic to find the shortest path for the selected mode
        return new Route
        {
            Title = "Montreal QC - NEW York, USA",
            DistanceInKM = 538,
            Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(20)),
            Directions = new()
            {
                origin,
                "Montréal-Pierre Elliott Trudeau International Airport (YUL)",
                "John F. Kennedy International Airport (JFK)",
                destination
            }
        };
    }
}