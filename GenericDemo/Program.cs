using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class GenericClassDemo<T>
    {
        public void Swap(T a, T b)
        {
            T c = a;
            a = b;
            b = c;

            Console.Write($"\n a - {a} \n b - {b}");
        }

    }

    class GenericMethodDemo
    {
        public void Swap<T>(T a, T b)
        {
            T c = a;
            a = b;
            b = c;

            Console.Write($"\n a - {a} \n b - {b}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Generic Class-----");
            GenericClassDemo<int> d = new GenericClassDemo<int>();
            d.Swap(1, 2);
            GenericClassDemo<string> d1 = new GenericClassDemo<string>();
            d1.Swap("x", "y");

            Console.WriteLine("--- Generic Method-----");
            GenericMethodDemo d2 = new GenericMethodDemo();
            d2.Swap(1, 2);
            GenericClassDemo<string> d3 = new GenericClassDemo<string>();
            d3.Swap("x", "y");


            Console.ReadLine();
        }
    }
}
