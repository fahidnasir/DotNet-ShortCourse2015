using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class TestGC : IDisposable
    {
        private string name;

        public TestGC()
        {
            Console.WriteLine("Default Constructor");
        }

        public TestGC(string p)
        {
            this.name = p;
            Console.WriteLine("Default Constructor: {0}", this.name);
        }


        ~TestGC()
        {
            /* Release resources
             * 
             * Close Database Connection
             * Close Internet Connectivy Helper
             * Close HttpClient/NetClient
             * Close 
             */

            Console.WriteLine("~Destructor");
            //Console.ReadKey();
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
