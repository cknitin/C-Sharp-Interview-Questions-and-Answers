using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpInterfaceDemo
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Demo1 demo = new Demo1(
                 new List<User> 
                 {
                     new User { Role="Admin" },
                     new User { Role="Paid" },
                     new User { Role="Free" }
                 }
             );
            // The foreach-loop calls the generic GetEnumerator method.
            // ... It then uses the List's Enumerator.
            foreach (User element in demo)
            {
                Console.WriteLine(element.Role);
            }

            


        }
    }
}
