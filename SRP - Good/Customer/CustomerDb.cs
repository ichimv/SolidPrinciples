using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class CustomerDb
    {
        private FileLogger _logger = new FileLogger();
        public void Add(string name)
        {
            try
            {
                // data base code
            }
            catch (Exception ex)
            {
                _logger.Handle(ex);
            }
        }
    }
}
