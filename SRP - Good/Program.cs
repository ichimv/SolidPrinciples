using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartPhone = new SRPSmartPhone();
            do
            {
                Console.WriteLine("Enter a phone number to call");
                smartPhone.MakePhoneCall();
                Console.WriteLine("Press Escape if yu do not want to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
