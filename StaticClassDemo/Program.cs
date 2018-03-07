using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    // 1. Static class cannot declare instance members in a static class 
    // 2. Access modifiers are not allowed on static constructors
    // 3. Static class can not have instance constructtor
    // 4. Static class can not be inherit
    // 5. Object of static class can not be created
    // 6. Non staic filed can not be access in static constructors
    // 7. Static constructor invoke once for any number of instance, it is use to initilize static member fileds, by default static constructor is public
    // and access modifiers can not be use with static constructor.
    // 8. If the class is made static then all the members of the class are also made static. 
    //If the variable is made static then it will have a single instance and the value change is updated in this instance.
    static class Demo
    {
        //1. Static class cannot declare instance members in a static class 
        //public string name = string.Empty;

        public static string nameStaticProperty = string.Empty;

        // 2. Access modifiers are not allowed on static constructors
        //public static Demo()
        //{

        //}

        //3. Static class can not have instance constructtor
        //public Demo()
        //{

        //}

        static Demo()
        {
            // 6. Non staic filed can not be access in static constructors
            //name = "Mark";
            nameStaticProperty = "Johnson1";

            Console.WriteLine(nameStaticProperty);
        }
    }

    // 4. Static class can not be inherit
    //class Demo2 : Demo
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {
            // 5. Object of static class can not be created
            //Demo d = new Demo();
            Demo.nameStaticProperty = "testc";
            Console.ReadLine();

        }
    }
}
