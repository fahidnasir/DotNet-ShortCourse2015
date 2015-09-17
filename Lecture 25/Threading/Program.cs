using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static bool done;    // Static fields are shared between all threads

        public static void Main()
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }
        public static void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
