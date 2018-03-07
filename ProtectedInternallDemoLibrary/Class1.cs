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
        protected internal string Greeting { get; set; }
        public void PrintGreeting()
        {
            Console.WriteLine(Greeting);




        }
    }
}
