using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // Declare the generic class. 
        public class GenericList<T>
        {
            public GenericList()
            {
                dataArray = new T[100];
            }
            public GenericList(int count)
            {
                dataArray = new T[count];
            }

            private int _count;
            public int Count
            {
                get
                { return _count; }
            }

            private T[] dataArray;

            public void Add(T input)
            {
                dataArray[_count] = input;
                _count++;
            }

            public T ItemAt(int index)
            {
                if (index >= 0 && index < dataArray.Length)
                {
                    return dataArray[index];
                }
                return default(T);
            }

            public int GetIndexOf(T input)
            {
                for (int i = 0; i < dataArray.Length; i++)
                {
                    if (dataArray[i].Equals(input))
                        return i;
                }
                return -1;
            }
        }

        public class Student
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return string.Format("Name: {0},  Age: {1}", Name, Age);
            }
        }

        class TestGenericList
        {
            static void Main()
            {
                //System.Collections.Generic.List<ExampleClass> arr = new List<ExampleClass>();
                //arr.Find(p => p.age == 10);


                // Declare a list of type int.
                GenericList<int> list1 = new GenericList<int>();
                list1.Add(10);

                // Declare a list of type string.
                GenericList<string> list2 = new GenericList<string>();
                list2.Add("empty");

                // Declare a list of type ExampleClass.
                GenericList<Student> list3 = new GenericList<Student>(10);
                list3.Add(new Student() { Name = "One", Age = 20 });
                list3.Add(new Student() { Name = "Two", Age = 22 });
                list3.Add(new Student() { Name = "Three", Age = 24 });
                list3.Add(new Student() { Name = "Four", Age = 26 });
                list3.Add(new Student() { Name = "Five", Age = 28 });
                list3.Add(new Student() { Name = "Six", Age = 30 });

                Student element = list3.ItemAt(5);
                Console.WriteLine(element);

                Console.ReadKey();
            }
        }
    }
}
