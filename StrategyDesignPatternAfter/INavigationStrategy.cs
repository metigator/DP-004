namespace StrategyDesignPattern.Before;

public interface INavigationStrategy
{
    Route Navigate(string origin, string destination);
}
