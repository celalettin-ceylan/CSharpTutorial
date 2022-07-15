
using Basics.Vehicles;

namespace Basics; // Note: actual namespace depends on the project name.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Vehicle car = new Car();
        car.launch();
        car.stop();
    }
}
