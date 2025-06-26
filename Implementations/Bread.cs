using Logging_Proxy.Interfaces;

namespace Logging_Proxy.Implementations;

internal class Bread : IFood
{
    public string Name { get; set; } = String.Empty;

    public bool IsVegetarian { get; } = true;

    public bool IsMeat { get; } = false;

    public bool Eaten()
    {
        Console.WriteLine("Food {0} is eaten", Name);
        return true;
    }
}
