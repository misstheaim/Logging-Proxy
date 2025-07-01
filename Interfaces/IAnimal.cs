namespace Logging_Proxy.Interfaces;

public interface IAnimal
{
    string Name { get; set; }

    bool IsPredator { get; }

    bool IsHerbivore { get; }

    bool Eat(IFood food);

    void Eat(int count);

    void Eat();

    int Run(int distance, int speed);

    double Run(int time, double speed);

    void MakeNoise();
}
