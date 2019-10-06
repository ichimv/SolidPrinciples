using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Worker
{
    public class SuperWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Is working more...");
        }
    }
}
