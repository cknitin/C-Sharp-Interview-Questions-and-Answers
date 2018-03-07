using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealDemo
{
    // 1. Sealed class can not be inherited 
    // 2. Sealed also can be used with method to avoid override.
    sealed class Demo
    {
        public string Greeting { get; set; }
    }

    // 1. Sealed class can not be inherited 
    //class Demo1 : Demo
    //{

    //}

    class Demo2
    {
        public virtual void Greeting1()
        {
            Console.WriteLine("Greeting1 from Demo2.");
        }

        public virtual void Greeting2()
        {
            Console.WriteLine("Greeting2 from Demo2.");
        }
    }

    class Demo3:Demo2
    {
        public override void Greeting1()
        {
            Console.WriteLine("Greeting1 from Demo3.");
        }

        //2. Sealed also can be used with method to avoid override.
        sealed public override void Greeting2()
        {
            Console.WriteLine("Greeting1 from Demo3.");
        }
    }

    class Demo4 : Demo3
    {
        //2. Sealed also can be used with method to avoid override.
        // In this class you can not override the Greeting2() method due to sealed 
        public override void Greeting1()
        {
            Console.WriteLine("Greeting1 from Demo4.");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
