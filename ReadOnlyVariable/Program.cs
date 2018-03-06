using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVariable
{
    // 1. Readonly varibale can be initilize at the time of declareation on with in the constructors only, can not set the value later in the program
    // 2. A static readonly field cannot be assigned with in the static constructors only.
    // 3. An ordinary class can have both static and non-static constructors
    class Demo
    {
        public readonly string greeting = "hello";
        public static readonly string greeting2 = "hello";

        //3. An ordinary class can have both static and non-static constructors
        #region 3. An ordinary class can have both static and non-static constructors
        public Demo()
        {
            greeting = "Hello India";

            // 2. A static readonly field cannot be assigned to(except in a static constructor or a variable initializer)
            //greeting2 = "Namastey India";
        }

        static Demo()
        {
            greeting2 = "Namastey India";
        }
        #endregion

        public void PrintGreeting()
        {
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            //d.greeting = "Hello";

            d.PrintGreeting();
            Console.ReadLine();
        }
    }
}
