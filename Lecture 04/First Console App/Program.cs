using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Console_App
{
    class Program
    {
        #region Class level members
        public static string staticVar = "this is static type variable.";
        #endregion

        #region Class Member types
        #region Access Modifiers
        public int publicVar = 10;
        private double privateVar = 150.5;
        protected string protectedVar = "this is string type variable";

        #endregion
        const double PI = 3.14159;
        #endregion

        static void Main(string[] args)
        {
            #region Comments
            //Single Line Comment
            /*
             * Multi
             * Line
             * Comment
             */
            #endregion

            #region Data Types
            const double PILOCAL = 3.14159;

            #region literal types
            double doubleObj = 3.14159;       /* Simple double object */
            decimal decimalObj = 85;         /* decimal */
            //0213       /* octal */
            //0x4b       /* hexadecimal */
            int intObj = 30;         /* int */
            uint uintObj = 30u;        /* unsigned int */
            long longObj = 30l;        /* long */
            ulong ulongObj = 30ul;       /* unsigned long */
            double exponentObj = 314159E-5;    /* exponent of the number */
            #endregion
            #endregion

            #region Collections
            Array[] arr = new Array[10];
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            #endregion

            #region If Else
            if (list.Count == 0)
            {
                Console.Write("List is Empty");
            }
            else if (list.Count == 1)
            {
                Console.Write("List is not Empty");
            }
            else if (list.Count == 2)
            {
                Console.Write("List contains more than 1 value");
            }
            else
            {
                Console.Write("List contains more than 2 value");
            }
            #endregion

            #region For Loop
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            #endregion

            #region Foreach Loop
            //Consider looking into 'IEnumerable' and 'IEnumerator' interfaces
            //https://support.microsoft.com/en-us/kb/322022
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region While      
            /* while loop evaluate the true/false statement just like If statement.
             * If statement in the while(conditional statement) results true then it enters in the block. otherwise while inner code will not run.
             */
            int whileCounter = 0;
            while (whileCounter < list.Count)
            {
                Console.WriteLine(list[whileCounter]);

                //Increasing the whileCounter value by 1.
                //It is same as  whileCounter = whileCounter + 1;
                whileCounter++;
            }

            #endregion

            #region do while
            //Only difference between 'while' and 'do while'  is that while check the conditional statement before running the code.
            //And do-while check the conditional statement after running the code.
            whileCounter = 0;
            do
            {
                Console.WriteLine(list[whileCounter]);
            } while (whileCounter < list.Count);
            #endregion

            #region try-catch-finally block
            //Write it where you fear to crash of the program for any reason.
            //Mostly at time of communication or File reading writing force to use this try-catch.
            //I write only a naive line to show the error
            try
            {
                object obj = null;
                //above line shows the obj variable with null value which results in NullPointerException.
                //But it will be handeled by catch block. so your program never crash.
                obj.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Null Pointer Exception Occured.");
                Console.WriteLine("Comment or remove the try-catch block just to try.");
            }
            #endregion

            #region Creating Objects of other class and Function calling
            Random rnd = new Random();
            int firstRandomNumber = rnd.Next();
            int randomNumberWithRange = rnd.Next(100, 200);
            #endregion

            #region Calling Local Function
            PrintMyName();
            #endregion
            Console.Read();
        }

        public static void PrintMyName()
        {
            Console.Write("PrintMyName function called and it print your name:   ");
            Console.WriteLine("Write your Name here.");
        }

        public void testFunction()
        {
            var v = PI;
        }
    }
}
