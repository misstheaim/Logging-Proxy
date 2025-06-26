namespace Logging_Proxy.Interfaces;

public interface IAnimal
{
    string Name { get; set; }

    bool IsPredator { get; }

    bool IsHerbivore { get; }

    bool Eat(IFood food);
}
