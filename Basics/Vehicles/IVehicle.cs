using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Vehicles;

internal interface IVehicle
{
    void launch();
    void stop();
    void speedUp();
    void speedDown();

}
