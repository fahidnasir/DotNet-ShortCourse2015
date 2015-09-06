using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            c1.Real = 250;
            c1.Imaginary = 10;

            Complex c2 = new Complex(75, 20);

            Complex c3 = c1.Add(c2);

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.ReadKey();
        }
    }
}
