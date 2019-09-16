using System;
using System.Collections.Generic;

namespace OCP
{
    interface IPoneNumberValidator
    {
        bool IsValid(int phoneNumber);
    }

    class UrgencyNumberValidator : IPoneNumberValidator
    {
        public bool IsValid(int phoneNumber)
        {
            return phoneNumber == 112;
        }
    }

    class DigitsNumerValidator : IPoneNumberValidator
    {
        private const int expectedNumberOfDigits = 10;

        public bool IsValid(int phoneNumber)
        {
            return NumberOfDigits(phoneNumber) == expectedNumberOfDigits;
        }

        static private int NumberOfDigits(int n)
        {
            if (n <= 9)
                return 1;
            return 1 + NumberOfDigits(n / 10);
        }
    }


    class Phone
    {
        public string Manufacturer { get; set; }

        private List<IPoneNumberValidator> phoneNumberValidators;

        public Phone()
        {
            phoneNumberValidators = new List<IPoneNumberValidator>();
            phoneNumberValidators.Add(new UrgencyNumberValidator());
            phoneNumberValidators.Add(new DigitsNumerValidator());
        }

        public bool MakePhoneCall()
        {
            string phoneNumberString = Console.ReadLine();
            if (!IsValidNumber(phoneNumberString))
            {
                FileLogger.Instance().HandleError($"Invalid phone number {phoneNumberString}");
                return false;
            }

            EncriptOutgoingSound();
            return true;
        }

        private void EncriptOutgoingSound()
        {
        }

        private void DecriptOutgoingSound()
        {
        }

        public bool IsValidNumber(string phoneNumberString)
        {
            int phoneNumber = 0;
            Int32.TryParse(phoneNumberString, out phoneNumber);

            foreach (var validator in phoneNumberValidators)
            {
                if (validator.IsValid(phoneNumber))
                    return true;
            }

            return false;
        }
    }

    public class OCPSmartPhone
    {
        private Phone phone;

        public OCPSmartPhone()
        {
            phone = new Phone();
        }

        public void UsePhone()
        {
            phone.MakePhoneCall();
        }
    }
}
