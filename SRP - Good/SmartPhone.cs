using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Camera
    {
        public string Manufacturer { get; set; }

        public void TakePhoto(bool enableFlash) { }
        private void SavePhoto() { }
        private void Flash(bool enable) { }
    }
    class Phone
    {
        public string Manufacturer { get; set; }

        public void MakePhoneCall() { }
        private void EncriptOutgoingSound() { }
        private void DecriptOutgoingSound() { }
    }

    class SRPSmartPhone
    {
        private Camera camera;
        private Phone phone;

        public SRPSmartPhone() {
            camera = new Camera();
            phone = new Phone();
        }
        public void UseCamera(bool enableFlash) {
            camera.TakePhoto(enableFlash);
        }
        public void MakePhoneCall() {
            phone.MakePhoneCall();
        }
    }

}
