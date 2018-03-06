using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodDemo
{
    class Base
    {
        virtual public void Show()
        {
            Console.WriteLine("I am base.");
        }
    }

    class Derive1:Base
    {
        override public void Show()
        {
            Console.WriteLine("I am Derive 1.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Base b = new Derive1();
            b.Show();
            Console.ReadLine();
        }
    }
}
