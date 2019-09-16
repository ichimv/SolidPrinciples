using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class LSPBird
    {
        public string Kind { get; set; }
    }

    abstract class FlyableBird : LSPBird
    {
        public abstract void Fly();
    }



    class LSPDuck : FlyableBird
    {
        public override void Fly() {}
    }

    class LSPOstrich : LSPBird
    {
    }
}
