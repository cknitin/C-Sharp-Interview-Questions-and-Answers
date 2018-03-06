using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Destructor
{
    class Demo
    {
        public Demo()
        {
            Console.WriteLine(" entered in constructor.");
        }
        ~Demo()
        {
            Console.WriteLine("Entered in Destructor.");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Demo demo = null;
            demo = new Demo();
            demo = null;
            GC.Collect();
            Console.ReadLine();
        }
    }
}
