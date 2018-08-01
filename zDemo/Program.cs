using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zDemo
{

    interface IInterface1
    {
        void Print();
    }

    interface IInterface2
    {
        void Print();
    }


    class Demo : IInterface1, IInterface2
    {
        public void Print()
        {
            Console.WriteLine("I am IInterface2.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            IInterface2 d = new Demo();
            d.Print();

            Console.ReadLine();
        }
    }
}
