namespace InterfaceSegregationPrinciple.Services;

public class Car : ICar, INavigation
{
    public void CheckSpeed()
    {
        Console.WriteLine("Speed checked.");
    }

    public void CheckFuelLevel()
    {
        Console.WriteLine("Fuel level checked.");
    }

    public void Navigate()
    {
        Console.WriteLine("Navigation started.");
    }
}