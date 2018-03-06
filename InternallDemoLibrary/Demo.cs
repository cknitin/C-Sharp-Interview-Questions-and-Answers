using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternallDemoLibrary
{
    public class InternallDemoLibraryDemo
    {
        internal string Greeting { get; set; }
        public void PrintGreeting()
        {
            Console.WriteLine(Greeting);
        }
    }
}
