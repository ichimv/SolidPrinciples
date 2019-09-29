using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface ISmartMessage
    {
        bool Send(IList<String> toAddresses, string messageBody);
    }

    public interface ISmartEmailMessage : ISmartMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }

    public class SmtpSmartMessage : ISmartEmailMessage
    {
        public IList<String> BccAddresses { get; set; }
        public string Subject { get; set; }
        public bool Send(IList<String> toAddresses, string messageBody)
        {
            //Do the real work here
            return true;
        }
    }

    public class SmsSmartMessage : ISmartMessage
    {
        public bool Send(IList<String> toAddresses, string messageBody)
        {
            //Do the real work here
            return true;
        }
    }
}
