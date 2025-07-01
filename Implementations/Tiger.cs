using Logging_Proxy.Interfaces;

namespace Logging_Proxy.Implementations;

internal class Tiger : IAnimal
{
    public string Name { get; set; } = String.Empty;

    public bool IsPredator { get; } = true;

    public bool IsHerbivore { get; } = false;

    public bool Eat(IFood food)
    {
        if (food == null) return false;

        if ((food.IsMeat && IsPredator) || (food.IsVegetarian && IsHerbivore))
        {
            if (food.Eaten())
            {
                Console.WriteLine("Animal {0} is full", Name);
                return true;
            }
            else
            {
                Console.WriteLine("Animal {0} is hungry", Name);
                return false;
            }
        }
        Console.WriteLine("Animal {0} doesn't like {1}", Name, food.Name);
        return false;
    }

    public void Eat()
    {
        Console.WriteLine("The {0} is eating!");
    }

    public void Eat(int count)
    {
        Console.WriteLine("The {0} has eaten {1} portion(s) of food.", Name, count);
    }

    public int Run(int distance, int speed)
    {
        return distance / speed;
    }

    public double Run(int time, double speed)
    {
        return time * speed;
    }

    public void MakeNoise()
    {
        Console.WriteLine("Rrrrrrr");
    }
}
