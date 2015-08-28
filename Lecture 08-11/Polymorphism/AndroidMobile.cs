using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class AndroidMobile : Mobile
    {
        public AndroidMobile(string serialNumber)
            : base(serialNumber)
        {
        }

        public override bool MakeCall(string phoneNumber)
        {
            Console.WriteLine("Android Calling to: " + phoneNumber);
            return true;
        }

        public override bool SendSMS(string phoneNumber, string smsText)
        {
            Console.WriteLine("Android sending " + smsText + " SMS to: " + phoneNumber);
            return true;
        }
    }
}
