using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class SmartPhone
    {
        public string Phone { get; set; }
        public string Camera { get; set; }

        public SmartPhone()
        {
            Phone = "Original Phone";
            Camera = "Original Camera";
        }

        public void MakePhoneCall()
        {
        }

        public void TakePhoto(bool enableFlash)
        {
        }

        public void EncriptOutgoingSound()
        {
        }

        public void DecriptOutgoingSound()
        {
        }

        public void SavePhoto()
        {
        }

        public void Flash(bool enable)
        {
        }
    }
}
