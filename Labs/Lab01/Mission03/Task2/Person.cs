using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
