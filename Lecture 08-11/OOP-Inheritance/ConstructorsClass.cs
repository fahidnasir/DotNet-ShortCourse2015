using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    //Constructor overloading.


    //Constructors are class methods that are executed automatically when an object of a given type is created. Constructors usually initialize the data members of the new object. A constructor can run only once when a class is created. Furthermore, the code in the constructor always runs before any other code in a class. However, you can create multiple constructor overloads in the same way as for any other method.

    /// <summary>
    /// By default every class have a parameter less constructor which is removed/unimplemented automatically
    /// if user write a constructor.
    /// 
    /// 
    /// Constructor use to initialize values of members
    /// 1. parameter less constructor write some default values in members
    /// and constructor with parameter update the values with the values recieved in parameter.
    /// </summary>

    class ConstructorsClass
    {
        private Random first;
        private String second;

        public ConstructorsClass()
        {
            //I did'nt recieve any value so I write some value in object just so make sure no NullPointerException occur in code.
            first = new Random();
            second = "this is default text.";
        }

        public ConstructorsClass(string userGivenText)
        {
            second = userGivenText;
        }

        public ConstructorsClass(Random userGivenRandomObject)
        {
            first = userGivenRandomObject;
        }
        public ConstructorsClass(Random userGivenRandomObject, string userGivenText)
        {
            first = userGivenRandomObject;
            second = userGivenText;
        }

        public ConstructorsClass(string userGivenText, Random userGivenRandomObject)
        {
            second = userGivenText;
            first = userGivenRandomObject;
        }
    }
}
