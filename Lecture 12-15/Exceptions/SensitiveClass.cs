using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Assume class work with very Sensitive data
    /// So, it implement very strict rules to deal with other classes.
    /// Other classes bound to send it the compatible data only.
    /// </summary>
    public class SensitiveClass
    {
        /// <summary>
        /// This method only accepts the values multiple of 7.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool SaveOnlyNumberSeventMultiple(int number)
        {
            //Saving somewhere secret place..:p
            if (number % 7 == 0)
                return true;

            throw new Exception("Last warning send me only numbers multiple of 7.");
        }

        public bool SaveOnlyTextContainPak(string text)
        {
            if (text.ToLower().Contains("pakistan"))
                return true;

            throw new Exception("This method allowed only to Pakistanis");
        }
    }
}
