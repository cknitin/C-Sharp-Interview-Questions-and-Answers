using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleDemo
{

    public class TupleDemoClass
    {
        public Tuple<int, string> GetMultiTypeValues(int x, string y)
        {
            return new Tuple<int, string>(x, y);
        }

        // C# 7.0 - Tuples need to add reference of System.Tuple
        public (int p, string q) NewGetMultiTypeValues(int x, string y)
        {
            return (x, y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {



            TupleDemoClass obj = new TupleDemoClass();
            var tp = obj.GetMultiTypeValues(10,"Ten");

            Console.WriteLine($"{tp.Item1} {tp.Item2}");

            var tp1 = obj.NewGetMultiTypeValues(10, "Ten");
            Console.WriteLine($"{tp1.p} {tp1.q}");

            // C# 7.2 - Leading underscores in numeric literals
            int j = 10_11_12;
            Console.WriteLine(j);


            //Console.WriteLine($"{tp1.Item1} {tp1.Item2}");
            Console.ReadLine();
        }
    }
}
