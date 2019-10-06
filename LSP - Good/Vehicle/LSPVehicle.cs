using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class LSPVehicle
    {
        public string Brand { get; set; }
        public double Speed { get; set; }
    }

    abstract class VehicleWithEngine : LSPVehicle
    {
        abstract public void StartEngine();
    }

    class LSPCar : VehicleWithEngine
    {
        override public void StartEngine() {}
    }

    abstract class VehicleWithoutEngine : LSPVehicle
    {
        abstract public void StartMoving();
    }

    class LSPBicycle : VehicleWithoutEngine
    {
        override public void StartMoving() {}
    }
}
