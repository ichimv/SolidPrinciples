using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.CarpetCleaner
{
    class CarpetHitter : ICarpetCleaner
    {
        public void Clean()
        {
            Console.WriteLine("Is cleaning by hitting...");
        }
    }
}
