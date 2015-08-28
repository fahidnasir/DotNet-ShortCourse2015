using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Its an incomplete functional class. So, its riskful to use incomplete functionality
    /// Thats why compiler Restrict the developer to make the class abstract which contain any abstract method.
    /// </summary>
    public abstract class Mobile
    {
        private string IMEI;

        public Mobile()
        {
            IMEI = "00000000000000";
        }
        public Mobile(string serialNumber)
        {
            IMEI = serialNumber;
        }

        //Every mobile have Serial so this method is common in 100% of the mobiles.
        //So its better to write in parent class. So no Child class have to write the duplicate functionality.
        public string GetMobileSerialNumber()
        {
            return IMEI;
        }

        /// <summary>
        /// Same as the above method every method also make the Call.
        /// So, What is the reason not to make these methods concrete?
        /// 
        /// Because every mobile have its own mechanism to dial the call.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>If call successfully made return TRUE or FALSE otherwise</returns>
        public abstract bool MakeCall(string phoneNumber);
        /// <summary>
        /// Same as the above method every method also make the Call.
        /// So, What is the reason not to make these methods concrete?
        /// 
        /// Because every mobile have its own mechanism to send the sms.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>If SMS sent method return TRUE or FALSE otherwise</returns>
        public abstract bool SendSMS(string phoneNumber, string smsText);
    }
}
