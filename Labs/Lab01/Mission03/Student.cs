using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task2
{
    public class Student : Person
    {
        public Student(string name, int age, int m1, int m2, int m3)
            : base(name, age)
        {
            this.Subject1Marks = m1;
            this.Subject2Marks = m2;
            this.Subject3Marks = m3;
        }

        public int Subject1Marks { get; set; }
        public int Subject2Marks { get; set; }
        public int Subject3Marks { get; set; }

        public int GetAverage()
        {
            return (Subject1Marks + Subject2Marks + Subject3Marks) / 3;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Subject1: {0}, Subject2: {1}, Subject3: {2}", Subject1Marks, Subject2Marks, Subject3Marks);
        }
    }
}
