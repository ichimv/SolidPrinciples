using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class CustomerDb
    {
        public void Add(string name)
        {
            try
            {
                // data base code
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\LogFile.log", ex.ToString());
            }
        }
    }
}
