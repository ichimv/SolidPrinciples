using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Worker
{
    public class Manager
    {
        private Worker _worker;
        public void SetWorker(Worker w)
        {
            _worker = w;
        }
        public void Manage()
        {
            _worker.Work();
        }
    }
}
