using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> mobiles = getAllMobiles();

            for (int i = 0; i < mobiles.Count; i++)
            {
                Console.WriteLine("-------------------------");
                
                Console.WriteLine("Serial " + mobiles[i].GetMobileSerialNumber());
                mobiles[i].MakeCall("123456789");
                mobiles[i].SendSMS("123456798", "abc");

                Console.WriteLine("-------------------------");
            }
            Console.ReadKey(true);
        }

        private static List<Mobile> getAllMobiles()
        {
            List<Mobile> result = new List<Mobile>();

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        result.Add(new NokiaMobile("000000000000000" + i));
                        break;
                    case 1:
                        result.Add(new AndroidMobile("000000000000000" + i));
                        break;
                    case 2:
                        result.Add(new IphoneMobile("000000000000000" + i));
                        break;
                    default:
                        break;
                }
            }

            return result;
        }


        public enum Mobiles
        {
            Nokia,
            Android,
            Iphone
        }
    }
}
