namespace StrategyDesignPattern.Before;

public class NavigationContext
{
    private INavigationStrategy _navigationStrategy;

    public NavigationContext(INavigationStrategy navigationStrategy)
    {
        _navigationStrategy = navigationStrategy;
    }

    public void SwitchNavigationStrategy(INavigationStrategy navigationStrategy)
    {
        _navigationStrategy = navigationStrategy;
    }

    public Route Navigate(string origin, string destination)
    {
        return _navigationStrategy.Navigate(origin, destination);
    }
}
