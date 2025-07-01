using Logging_Proxy.Implementations;
using Logging_Proxy.Interfaces;

namespace Logging_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingProxy<IAnimal> proxyAnimal = new LoggingProxy<IAnimal>();

            IAnimal animal = proxyAnimal.CreateInstance(new Tiger() { Name = "Charlie" });

            LoggingProxy<IFood> proxyFood = new LoggingProxy<IFood>();

            IFood food = proxyFood.CreateInstance(new Bread() { Name = "Rye bread" });

            animal.Eat(food);

            food = proxyFood.CreateInstance(new Chicken() { Name = "Bob" });

            animal.Eat(food);

            animal.Eat();

            animal.Eat(5);

            animal.Name = "Well fed Charlie";

            int time = animal.Run(100, 5);

            Console.WriteLine("Animal {0} run the distance of 100m for {1} sec", animal.Name, time);

            double distance = animal.Run(50, 3.4);

            Console.WriteLine("Animal {0} run the distance of {1} for 50 sec", animal.Name, distance);

            animal.MakeNoise();

            animal.Eat(null);
        }
    }
}
