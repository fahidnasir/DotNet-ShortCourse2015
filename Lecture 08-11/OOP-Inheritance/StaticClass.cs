using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    /// <summary>
    /// this is a static class which can only contains static members, function, events
    /// </summary>
    public static class StaticClass
    {
        private static int firstNumber;
        private static int secondNumber;

        private static string stringMember;
        private static List<string> listOfNames;

        public static int GetSum()
        {
            return firstNumber + secondNumber;
        }
        public static string GetName()
        {
            stringMember = "this is dummy text";
            return stringMember;
        }

        public static List<string> GetListOfNames()
        {
            listOfNames = new List<string>();
            listOfNames.Add("first name");
            listOfNames.Add("second name");
            listOfNames.Add("third name");
            listOfNames.Add("forth name");
            listOfNames.Add("fifth name");

            return listOfNames;
        }
    }
}
