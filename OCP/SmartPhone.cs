using System;
using System.IO;

namespace OCP
{
    class SmartPhone
    {
        private const int expectedNumberOfDigits = 10;
        public string Phone { get; set; }

        public SmartPhone()
        {
            Phone = "Original Phone";
        }

        public bool MakePhoneCall()
        {
            string phoneNumberString = Console.ReadLine();
            if (!IsValidNumber(phoneNumberString))
            {
                File.WriteAllText(@"D:\Error.txt", $"Invalid phone number {phoneNumberString}");
                return false;
            }

            EncriptOutgoingSound();
            return true;
        }

        public void EncriptOutgoingSound() { }
        public void DecriptOutgoingSound() { }
        public int NumberOfDigits(int n)
        {
            if (n <= 9)
                return 1;
            return 1 + NumberOfDigits(n / 10);
        }

        public bool IsValidNumber(string phoneNumberString)
        {
            int phoneNumber = 0;
            Int32.TryParse(phoneNumberString, out phoneNumber);

            if (phoneNumber == 112)
                return true;

            if (NumberOfDigits(phoneNumber) == expectedNumberOfDigits)
                return true;

            return false;
        }
    }
}
