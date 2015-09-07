using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGC obj1 = new TestGC("First");
            TestGC obj2 = new TestGC("Second");


            //This method mark the object as disposable.
            //So that Garbage collector consider this object to release from memory in next Iteration.
            obj1.Dispose();
            
            
            //Read the documentation of method below.
            System.GC.Collect();



            Console.ReadKey();
        }
    }
}
