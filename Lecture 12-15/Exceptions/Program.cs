using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try to uncomment the code below to catch the exception.


            SensitiveClass sensitiveObj = new SensitiveClass();
            //try
            //{
                if (sensitiveObj.SaveOnlyNumberSeventMultiple(14))
                {
                    Console.WriteLine("Your number saved.");
                }

                if (sensitiveObj.SaveOnlyTextContainPak("I love Pakista"))
                {
                    Console.WriteLine("You are a Pakistani.");
                }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadKey(true);
        }
    }
}
