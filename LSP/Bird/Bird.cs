using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    abstract class Bird
    {
        public string Kind { get; set; }
        public abstract void Fly();
    }

    class Duck : Bird
    {
        public override void Fly() {}
    }

    class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new Exception("Ostrich can't fly");
        }
    }
}
