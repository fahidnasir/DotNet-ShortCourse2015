using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class NokiaMobile : Mobile
    {
        public NokiaMobile(string serialNumber):base(serialNumber)
        {
        }

        public override bool MakeCall(string phoneNumber)
        {
            Console.WriteLine("Nokia Calling to: " + phoneNumber);
            return true;
        }

        public override bool SendSMS(string phoneNumber, string smsText)
        {
            Console.WriteLine("Nokia sending " + smsText + " SMS to: " + phoneNumber);
            return true;
        }
    }
}
