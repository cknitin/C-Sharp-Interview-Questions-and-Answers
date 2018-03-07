using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutDemo
{
    class Demo
    {
        public void Print(ref string firstName, out string lastName)
        {
            firstName = "Steve";
            lastName = "Smith";
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tony";
            string lastName = "Stark";

            Demo d = new Demo();

            Console.WriteLine($"Before -  {firstName} {lastName}");

            d.Print(ref firstName,out lastName);

            Console.WriteLine($"Afer -  {firstName} {lastName}");

            Console.ReadLine();
        }
    }
}
