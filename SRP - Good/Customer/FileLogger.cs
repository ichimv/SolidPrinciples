using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class FileLogger
    {
        public void Handle(Exception ex)
        {
            System.IO.File.WriteAllText(@"c:\LogFile.log", ex.ToString());
        }

    }
}
