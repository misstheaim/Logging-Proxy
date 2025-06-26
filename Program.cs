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

            animal.Name = "Well fed Charlie";

            animal.Eat(null);
        }
    }
}
