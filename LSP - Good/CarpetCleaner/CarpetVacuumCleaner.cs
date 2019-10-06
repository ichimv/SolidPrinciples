using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.CarpetCleaner
{
    class CarpetVacuumCleaner : ICarpetCleaner
    {
        private bool isTurnedOn = false;

        public void Clean()
        {
            if (!isTurnedOn) {
                TurnOn();
            }

            Console.WriteLine("Is cleaning by vacuuming the dust...");
        }

        private void TurnOn()
        {
            isTurnedOn = true;
        }

    }
}
