using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IAdministrativeMashine
    {
        void Print(string PrintContent);
        void Staple(string StapleContent);
        void Scan(string ScanContent);
        void PhotoCopy(string photoCopyContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }

    public class HPLaserJetPrinter : IAdministrativeMashine
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }

        public void Staple(string StapleContent)
        {
            throw new NotImplementedException();
        }

        public void PhotoCopy(string photoCopyContent)
        {
            Console.WriteLine("Photo copy content");
        }
    }

    class LiquidInkjetPrinter : IAdministrativeMashine
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }

        public void Staple(string StapleContent)
        {
            throw new NotImplementedException();
        }

        public void PhotoCopy(string photoCopyContent)
        {
            throw new NotImplementedException();
        }
    }
}
