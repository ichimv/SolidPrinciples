using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IISPMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
        bool Send();
    }

    public interface IEmailMessage : IISPMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }

    public class ISPSmtpMessage : IEmailMessage
    {
        public IList<String> ToAddresses { get; set; }
        public IList<String> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public bool Send()
        {
            //Do the real work here
            return true;
        }
    }

    public class ISPSmsMessage : IISPMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public bool Send()
        {
            //Do the real work here
            return true;
        }
    }
}
