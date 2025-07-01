using Logging_Proxy.Interfaces;

namespace Logging_Proxy.Implementations;

internal class Chicken : IFood
{
    public string Name { get; set; } = String.Empty;

    public bool IsVegetarian { get; } = false;

    public bool IsMeat { get; } = true;

    public bool Eaten()
    {
        Console.WriteLine("Food {0} is eaten", Name);
        return true;
    }
}
