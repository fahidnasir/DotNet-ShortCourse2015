using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using GetType to obtain type information: 
            int i = 42;
            System.Type intType = i.GetType();
            System.Console.WriteLine(intType);


            // Using Reflection to get information from an Assembly:
            System.Reflection.Assembly info = intType.Assembly;
            System.Console.WriteLine(info);


            // Loads an assembly using its file name.
            System.Reflection.Assembly a = System.Reflection.Assembly.LoadFrom("Reflection.exe");
            // Gets the type names from the assembly.
            Type[] types2 = a.GetTypes();
            foreach (Type t in types2)
            {
                Console.WriteLine(t.FullName);
            }



            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type MyType = Type.GetType("System.IO.File");
            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                Mymemberinfoarray.Length, MyType.FullName);
            Console.WriteLine("{0}.", MyType.FullName);
            if (MyType.IsPublic)
            {
                Console.WriteLine("{0} is public.", MyType.FullName);
            }

            Console.ReadKey();
        }
    }
}
