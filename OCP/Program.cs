using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartPhone = new OCPSmartPhone();
            do
            {
                Console.WriteLine("Enter a phone number to call");
                smartPhone.UsePhone();
                Console.WriteLine("Press Escape if yu do not want to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
