using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_And_LocalFunction
{
    class Program
    {
        //Func and Action are predefined generic delegates, which take zero to sixteen input parameters.
        //The basic difference between both is that Func always returns a value while Action doesn’t return a value.
        //Local function defines in the body of any method.
        //Both Func and Action delegates must be defined before they are called, while a Local function can be defined later in the method.

        // Predicate. A Predicate returns true or false. 
        // This C# type stores a method that receives 1 parameter and returns 1 value of true or false. 
        // And it is often used with lambda expression syntax.

        //Local Function
        //The Local function is a new concept introduced in C# 7. 
        //The Local function can be defined in the body of any method and property’s getter and setter. 
        //All the arguments and the local variables in the outer function are in scope of a local function.
        //These local functions can use ref and out parameters.


        static void Main(string[] args)
        {

            // Example Func instances.
            // ... First example uses one parameter.
            // ... Second example uses two parameters.
            // ... Third example uses no parameter.
            // ... None have results.
            Func<int,(int,string)> example1Func = (int x) =>
            {
                Console.WriteLine("Write {0}", x);
                return (x,"");
            };

            Func<int, int,int> example2Func = (x, y) =>
            {
                Console.WriteLine("Write {0} and {1}", x, y);
                return x + y;
            };

            Func<int> example3Func = () =>
            {
                Console.WriteLine("Done");
                return 10;
            };



            // Func
            // Can take 16 input and 1 output
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int,int > sum = 
                delegate (int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, 
                int a11, int a12, int a13, int a14, int a15, int a16)
            {
                return a1 + a2;
            };
            int result = sum(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,167);
            Console.WriteLine(result);


            // Func
            Func<int, bool> checkPrimeNumber = x =>
            {
                bool isPrime = false;
                int i;
                for (i = 2; i <= x - 1; i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i == x)
                {
                    isPrime = true;
                }
                return isPrime;
            };

            // Example Action instances.
            // ... First example uses one parameter.
            // ... Second example uses two parameters.
            // ... Third example uses no parameter.
            // ... None have results.
            Action<int> example1 = (int x) => 
            {
                Console.WriteLine("Write {0}", x);
            };

            Action<int, int> example2 = (x, y) => 
            {
                Console.WriteLine("Write {0} and {1}", x, y);
            };

            Action example3 = () => 
            {
                Console.WriteLine("Done");
            };

            // Call the anonymous methods.
            example1.Invoke(1);
            example2.Invoke(2, 3);
            example3.Invoke();

            // Can take 16 input
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Squre = 
                delegate (int a1, int a2, int a3, int a4, int a5, int a6, int a7, 
                int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16)
            {
                Console.WriteLine(a1 * a1);
            };


            //
            // This Predicate instance returns true if the argument is one.
            //
            Predicate<int> isOne =
                x => x == 1;
            //
            // This Predicate returns true if the argument is greater than 4.
            //
            Predicate<int> isGreaterEqualFive =
                (int x) => x >= 5;


            //
            // Test the Predicate instances with various parameters.
            //
            Console.WriteLine(isOne.Invoke(1));
            Console.WriteLine(isOne.Invoke(2));
            Console.WriteLine(isGreaterEqualFive.Invoke(3));
            Console.WriteLine(isGreaterEqualFive.Invoke(10));

            // Local Function
            int num = 10;
            long GetFactorial(int number)
            {
                return number == 0 ? 1 : number * GetFactorial(number - 1);
            }
            long fact = GetFactorial(num);
            Console.WriteLine($"{num} factorial is {fact}");

            Console.ReadLine();
        }
    }
}
