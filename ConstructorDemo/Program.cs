using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    // 1. Whose constructor will call the first? If child class is inherited with base class.
    // Answer - Base class’s constructor

    // 2. We know that Base class constructor called first. But if we creating object with parameters, and base class have
    // both constructor default and parameterized, then which constructor of baseclass called first.
    // Answer - Base class default constructor called first.

    // 3. How can we call Base class parameterized constructor first
    // Answer - use the keyword “base” with child class constructor

    class Base
    {
        public Base()
        {
            Console.WriteLine("I am Base default.");
        }

        public Base(string name)
        {
            Console.WriteLine("I am Base parameter.");
        }

    }

    class Drive:Base
    {
        public Drive()
        {
            Console.WriteLine("I am Drive default.");
        }

        public Drive(string name) : base(name)
        {
            Console.WriteLine("I am Drive parameter.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Drive d = new Drive("I am Drive parameter");

            Console.ReadLine();
        }
    }
}
