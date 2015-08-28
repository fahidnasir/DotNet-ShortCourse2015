using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class IphoneMobile : Mobile
    {
        public IphoneMobile(string serialNumber)
            : base(serialNumber)
        {
        }

        public override bool MakeCall(string phoneNumber)
        {
            Console.WriteLine("Iphone Calling to: " + phoneNumber);
            return true;
        }

        public override bool SendSMS(string phoneNumber, string smsText)
        {
            Console.WriteLine("Iphone sending " + smsText + " SMS to: " + phoneNumber);
            return true;
        }
    }
}
