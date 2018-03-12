using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Demo_6_0
{
    // 1. Auto-Property Initializers
    // 2. Primary Constructors is Removed from C# 6.0
    // 3. Primar Constructor
    // 4. Dictionary initilizer 

    class  User 
    {
        public string Role { get; set; }
        public User(string role)
        {
            Console.WriteLine(role);
        }
    }

    class Demo
    {
        // 1. Auto-Property Initializers
        public int Number { get; set; } = 10;

        public void PrintNumber()
        {
            Dictionary<string, User> dicUser = new Dictionary<string, User>()
            {
                ["admin"] = new User("Admin"),
                ["FreeUser"] = new User("Free User")
            };

            foreach (var item in dicUser)
            {
                Console.WriteLine($"Key - {item.Key} Value - {item.Value}");
            }

            Console.WriteLine(Number);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.PrintNumber();

            Console.ReadLine();
        }
    }
}
