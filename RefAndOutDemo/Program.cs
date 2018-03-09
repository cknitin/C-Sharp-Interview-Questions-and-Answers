using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutDemo
{
    // 1. “out” parameter can be passed to a method and it need not be initialized 
    // where as “ref” parameter has to be initialized before it is used.
    class Demo
    {
        public int refSum(ref int a, ref int b)
        {
            return a = a + b; 
            
        }

        public int outSum(out int a, out int b)
        {
            a = 11;
            b = 22;

            return a = a + b;

        }

        public int inPrint(in int a, in int b)
        {
            // Not allowed with in
            
            //return a = a + b;
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Demo d = new Demo();

            Console.WriteLine($"Before -  {x} {y}");

            int z = d.refSum(ref x,ref y);


            Console.WriteLine($"ref after -  {x} {y} {z}");


            int zz = d.outSum(out int a, out int b);
            Console.WriteLine($"out after -  {a} {b} {zz}");


            int p = 10;
            int q = 20;

            int r = d.outSum(out p, out q);
            Console.WriteLine($"in after -  {p} {q} {r}");


            Console.ReadLine();
        }
    }
}
