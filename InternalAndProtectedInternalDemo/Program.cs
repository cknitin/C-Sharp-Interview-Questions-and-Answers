using InternallDemoLibrary;
using ProtectedInternallDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAndProtectedInternalDemo
{
    // 1. Internal member can be access on with in assembely
    // 2. “protected internal” can be accessed in the same assembly and the child classes can also access these methods.
    class Demo : ProtectedInternalDemoLibraryDemo
    {
        public Demo()
        {
            // 2. “protected internal” can be accessed in the same assembly and the child classes can also access these methods.
            Greeting = "Protected Internal Demo Library Demo";
            PrintGreeting();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InternallDemoLibraryDemo d =new InternallDemoLibraryDemo();

           

            // Can not be access because it is define diffrent namespace as internal
            // So it can be access with in the same name space
            //d.Greeting = "Hello World"; 
            d.PrintGreeting();

            Demo d1 = new Demo();
            



            Console.ReadLine();
        }
    }
}
