using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mission03.Task1;
using Mission03.Task2;

namespace Mission03
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount("001", "Joker1", 5000);
            //Arguments: Acc. No, Name, Amount
            sa.Deposit(1500);
            Console.WriteLine(sa.ToString());
            Console.WriteLine();
            Console.WriteLine();
            sa.Withdraw(500);
            Console.WriteLine(sa.ToString());

            /******************************** Task 2 **************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Task 2 started.");
            Console.WriteLine();
            Console.WriteLine();
            Instructor mashter = new Instructor("Ustad", 28, 10);
            //Arguments: Name, age, lectures
            Console.WriteLine(mashter.ToString());

            Student nalaiqStudent = new Student("Shagird", 30, 10, 12, 15);
            Console.WriteLine(nalaiqStudent.ToString());

            Console.ReadKey();
        }
    }
}
