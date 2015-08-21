using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Anonymous class

            // sampleObject is an instance of a simple anonymous type.
            // you use 'var' or 'object' to save the anonymous class object.
            // this class only accessable to this specific object.
            var sampleObject = new { FirstProperty = "A", SecondProperty = "B" };

            #endregion

            #region Constructor Overloading
            ConstructorsClass constructor1 = new ConstructorsClass();

            Random rand = new Random();
            ConstructorsClass constructor2 = new ConstructorsClass(rand);


            string str = "this string is recieved as parameter.";
            ConstructorsClass constructor3 = new ConstructorsClass(str);


            ConstructorsClass constructor4 = new ConstructorsClass(rand, str);


            ConstructorsClass constructor5 = new ConstructorsClass(str, rand);
            #endregion

            #region Static Class
            int result = StaticClass.GetSum();
            string name = StaticClass.GetName();
            List<string> names = StaticClass.GetListOfNames();
            #endregion
        }
    }
}
