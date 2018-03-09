using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefualtDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Acquire the default values for these types and assign to a variable.
            StringBuilder variable1 = default(StringBuilder);
            int variable2 = default(int);
            bool variable3 = default(bool);
            Program variable4 = default(Program);

            // Write the values.
            Console.WriteLine(variable1); // Null
            Console.WriteLine(variable2); // 0
            Console.WriteLine(variable3); // False
            Console.WriteLine(variable4); // Null

            Console.ReadLine();

        }
    }
}
