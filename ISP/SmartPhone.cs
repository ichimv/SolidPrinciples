using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface ISmartPhone
    {
        string CameraDeviceManufacturer { get; set; }
        void TakePhoto(bool enableFlash);
        void SavePhoto();

        string PhoneDeviceManufacturer { get; set; }
        void MakePhoneCall();
        void EncriptOutgoingSound();
        void DecriptOutgoingSound();
    }

    class SmartPhone : ISmartPhone
    {
        public string CameraDeviceManufacturer { get; set; }
        public string PhoneDeviceManufacturer { get; set; }

        public void DecriptOutgoingSound() {}
        public void EncriptOutgoingSound() {}
        public void MakePhoneCall() {}

        public void SavePhoto(){}
        public void TakePhoto(bool enableFlash){}
    }
}
