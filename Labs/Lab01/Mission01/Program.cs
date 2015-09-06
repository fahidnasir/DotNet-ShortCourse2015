using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission01
{
    class Program
    {
        static void Main(string[] args)
        {
            TheDate d1 = new TheDate();
            d1.SetDay(4);
            d1.SetMonth(9);
            d1.SetYear(2015);
            d1.SetSaparator('~');


            TheDate d2 = new TheDate(4, 9, 2015, '-');

            TheDate d3 = new TheDate(d1);
            d3.SetSaparator('/');

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine(d3.ToString());
            Console.ReadKey();
        }
    }
}
