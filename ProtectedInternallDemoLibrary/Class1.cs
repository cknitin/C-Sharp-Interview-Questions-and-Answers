using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedInternallDemoLibrary
{
    public class ProtectedInternalDemoLibraryDemo
    {
        // 1. “protected internal” can be accessed in the same assembly and the child classes can also access these methods.
        protected internal string Greeting { get; set; }
        public void PrintGreeting()
        {
            Console.WriteLine(Greeting);




        }
    }
}
