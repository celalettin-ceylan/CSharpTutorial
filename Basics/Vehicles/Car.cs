using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Vehicles
{
    internal class Car : IVehicle
    {
        // instance level
        public string name { get; set; }
        public int currentSpeed { get; set; }

        // class level  
        public static int totalCarNumber = 0;

        public static readonly int CarCode = 2131;

        public Car(string name)
        {
            this.name = name;
            currentSpeed = 0;
            totalCarNumber++;
        }

        public void launch()
        {
            Console.WriteLine("{0} is launched" , name);
        }

        public void stop()
        {
            Console.WriteLine("{0} is stoppped", name);
        }

        public void printState() {
            Console.WriteLine("{0} is going {1} MPH.", name, currentSpeed);
        }

        public void speedUp()
        {
            currentSpeed++;
            printState();
        }

        public void speedUp(int diff) {
            currentSpeed += diff;
            printState();
        }

        public void speedDown()
        {
            currentSpeed--;
            printState();
        }

        public static void printTotalCarNumber() {
            Console.WriteLine("Total Car Number is: {0}", totalCarNumber);
        }
    }
}
