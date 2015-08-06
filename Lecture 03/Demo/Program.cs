using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.Library;
using VB.Library;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VB Library Functions
            
            VBClass vbObj = new VBClass();
            double vbResult = vbObj.Add(10, 12);
            Console.WriteLine("VB Function Add(10, 12)\n" + vbResult);
            vbResult = vbObj.Subtract(15, 10);
            Console.WriteLine("VB Function Subtract(15, 10)\n" + vbResult);
            
            #endregion
            #region CS Library Functions
            CSClass csObj = new CSClass();
            double csResult = csObj.Multiply(10, 2);
            Console.WriteLine("CS Function Multiply(10, 2)\n" + csResult);
            csResult = csObj.Divide(10, 5);
            Console.WriteLine("CS Function Divide(10, 5)\n" + csResult);
            #endregion
            Console.Read();
        }
    }
}
