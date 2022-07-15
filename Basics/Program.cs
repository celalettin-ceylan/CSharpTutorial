
using Basics.Vehicles;

namespace Basics; // Note: actual namespace depends on the project name.

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        IVehicle mercedes = new Car("Mercedes");
        mercedes.launch();
        mercedes.stop();

        Car renault = new Car("Renault");
        renault.launch();
        renault.speedUp();
        
        for (int i = 0; i < 10; i = i + 2) { 
            renault.speedUp(i);
        }

        for (int i = renault.currentSpeed; i > 0; i--)
        {
            renault.speedDown();
        }
        
        renault.stop();

        Car.printTotalCarNumber();
        Console.WriteLine("System Car Code {0}", Car.CarCode);

    }
}
