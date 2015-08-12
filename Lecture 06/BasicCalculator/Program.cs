using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the first number to add: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type the second number to add: ");
            double second = Convert.ToDouble(Console.ReadLine());

            //TODO: Use the Calculator Class
            double result = first + second;
            Console.Write("The Result is: ");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
