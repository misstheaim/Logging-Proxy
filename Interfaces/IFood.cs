namespace Logging_Proxy.Interfaces;

public interface IFood
{
    string Name { get; set; }

    bool IsVegetarian { get; }

    bool IsMeat { get; }

    bool Eaten();
}
