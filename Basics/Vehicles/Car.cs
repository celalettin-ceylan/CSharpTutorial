using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Vehicles
{
    internal class Car : Vehicle
    {
        public void launch()
        {
            Console.WriteLine("Car is launched");
        }

        public void stop()
        {
            Console.WriteLine("Car is stopped");
        }
    }
}
