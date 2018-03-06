using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyDemo
{
    class Demo:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
       
        public void Print(string objectName)
        {
            Console.WriteLine($"Object Name- {objectName} \nFirst Name- {FirstName} \nLast Name- {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Demo d1 = new Demo();
            d1.FirstName = "Peter";
            d1.LastName = "Parker";

            d1.Print("d1");

            Demo d2 = new Demo();
            d2 = (Demo)d1.Clone();
            d2.FirstName = "Rachel";
            d2.Print("d2");
            d1.Print("d1");

            Console.ReadLine();

        }
    }
}
