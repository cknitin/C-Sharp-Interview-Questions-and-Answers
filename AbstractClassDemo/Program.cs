using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{

    // 1. We can not have abstratc method in non abstratc class
    // 2. A abstract class can have both abstratc and non- abstract methds
    // 3. Can not create the instance of abstratc class
    // 4. Its mandatroy to override the abstratc method in derived class
    // 5. Derived class can not have same name method as abstrat class
    abstract class Demo
    {

        public void ShowFirstName()
        {
            Console.WriteLine("I am James.");
        }

        // 2. A abstract class can have both abstratc and non- abstract methds
        abstract public void ShowLastName();

    }

    class Demo1:Demo
    {
        // 5. Derived class can not have same name method as abstrat class
        //public void ShowLastName()
        //{
        //    Console.WriteLine("I am Anderson.");
        //}

        public override void ShowLastName()
        {
            Console.WriteLine("I am Anderson.");
        }
    }


    // 1. We can not have abstratc method in non abstratc class
    //class Demo1
    //{
    //    abstract public void ShowName()
    //    {
    //        Console.WriteLine("I am Demo.");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            // 3. can not create the instance of abstratc class
            // Demo d = new Demo();


            Demo1 d1 = new Demo1();
            d1.ShowLastName();

            Console.ReadLine();
        }
    }
}
