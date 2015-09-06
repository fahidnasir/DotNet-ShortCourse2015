using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task2
{
    public class Instructor : Person
    {

        public Instructor(string name, int age, int lectures)
            : base(name, age)
        {
            this.Lectures = lectures;
        }

        public int Lectures { get; set; }

        public int GetSalary()
        {
            return Lectures * 5000;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Lectures: {0}, Salary: {1}", Lectures, GetSalary());
        }
    }
}
