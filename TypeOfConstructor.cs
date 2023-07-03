using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticeProblem
{
    public class TypeOfConstructor
    {
        //Default Constructor
        public TypeOfConstructor()
        {
            Console.WriteLine("Default Constructor Active");
        }

        //Parameterized Constructor
        string userName;
        int userAge;
        public TypeOfConstructor(string name, int age)
        {
            userName = name;
            userAge = age;
            Console.WriteLine("Parameterized Constructor Active and Parameter given is \n User Name" + name + " User Age " + age);
        }

        //Copy Constructor 
        public TypeOfConstructor(TypeOfConstructor typeOfConstructor)
        {
            Console.WriteLine("Copy Constructor is Active");
        }

        //Static Constructor
        static TypeOfConstructor()
        {
            Console.WriteLine("Static Constructor Active");
        }
        public static void SampleMessage()
        {
            Console.WriteLine("This is Sample Message for Static class activation");
        }

        public class ExampleOfPrivetClass
        {
            private ExampleOfPrivetClass()
            {
                Console.WriteLine("Privet Class active ");

            }
            public static string employeeName;
            public static string DisplayDetails()
            {
                return employeeName;
            }
            //
        }

    }
}

