using StrategyDesignPattern.Before;

while (true)
{
    string origin = "Montreal";
    string destination = "New York";
    Console.WriteLine($"{origin} → {destination}");
    Console.Write("Route preference [1] walking, [2] cycling, [3] driving, [4] transit, [5] flights): ");
    if (Enum.TryParse(Console.ReadLine(), out RoutePreference routePreference))
    {

        NavigationContext navigationContext = new NavigationContext(new DrivingNavigationStrategy());

        switch (routePreference)
        {
            case RoutePreference.Walking:

                FindFastestRoute(origin, destination, RoutePreference.Walking);
                navigationContext.SwitchNavigationStrategy(new WalkingNavigationStrategy());
                break;

            case RoutePreference.Cycling:

                FindFastestRoute(origin, destination, RoutePreference.Cycling);
                navigationContext.SwitchNavigationStrategy(new CyclingNavigationStrategy());

                break;

            case RoutePreference.Driving:

                FindFastestRoute(origin, destination, RoutePreference.Driving);
                navigationContext.SwitchNavigationStrategy(new DrivingNavigationStrategy());

                break;

            case RoutePreference.Transit:

                FindFastestRoute(origin, destination, RoutePreference.Transit);
                navigationContext.SwitchNavigationStrategy(new TransitNavigationStrategy());
                break;

            case RoutePreference.Flight:

                FindFastestRoute(origin, destination, RoutePreference.Flight);
                navigationContext.SwitchNavigationStrategy(new FlightNavigationStrategy());
                break;

            default:
                break;
        }

        var route = navigationContext.Navigate(origin, destination);

        Console.WriteLine(route);
    }
    else
    {
        Console.WriteLine("INVALID CHOICE!!! Press any key to continue");
        Console.ReadKey();
    }
}

static void FindFastestRoute(string origin, string destination, RoutePreference routePreference)
{
    // Complex Logic to get route . calculations, we fake it :) 
    Console.Clear();
    Console.WriteLine($"'{routePreference}' route [{origin} → {destination}]");
    Console.Write($"Finding fastest route considering distance, weather, and safety");
    Thread.Sleep(750);
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(350);
        Console.Write(".");
    }
    Console.Clear();
}
