using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayListDemo
{
    // 1. Array stores the values or elements of same data type  but arraylist stores values of different datatypes.
    // 2. Arrays will use the fixed length but arraylist does not uses fixed length like array.
    class Program
    {
        static void Main(string[] args)
        {
            // 2.Arrays will use the fixed length but arraylist does not uses fixed length like array.
            string[] Demo = new string[5];

            Demo[0] = "string 1";
            Demo[1] = "string 2";
            Demo[2] = "string 3";
            Demo[3] = "string 4";
            // 1. Array stores the values or elements of same data type
            // Demo[4] = 5;

            foreach (var d in Demo)
            {
                Console.WriteLine(d);
            }

            
            ArrayList arrayList = new ArrayList();
            arrayList[0] = "String 1";
            arrayList[1] = "String 2";
            arrayList[2] = "String 3";
            // 1. but arraylist stores values of different datatypes.
            // 2.Arrays will use the fixed length but arraylist does not uses fixed length like array.
            arrayList[3] = 4;



            foreach (var a in arrayList)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
    }
}
