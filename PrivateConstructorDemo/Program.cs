using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorDemo
{
    // 1. If a class has private constructor, object of that class can not be created
    // 2. A class can have both public and private constructors
    class Demo
    {
        private Demo()
        {

        }
        public Demo(string s)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. If a class has private constructor, object of that class can not be created
            //Demo d = new Demo();

            Console.ReadLine();

        }
    }
}
