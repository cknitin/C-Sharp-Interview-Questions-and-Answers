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
    }
    class Program
    {
        static void Main(string[] args)
        {
            TupleDemoClass obj = new TupleDemoClass();
            var tp = obj.GetMultiTypeValues(10,"Ten");

            Console.WriteLine($"{tp.Item1} {tp.Item2}");

            Console.ReadLine();
        }
    }
}
