using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public double Speed { get; set; }

        abstract public void StartEngine();
    }

    class Car : Vehicle
    {
        override public void StartEngine()
        {
        }
    }

    class Bicycle : Vehicle
    {
        override public void StartEngine()
        {
            throw new Exception("Does not have an engine!");
        }
    }
}
