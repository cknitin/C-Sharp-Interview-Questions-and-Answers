using PrivateProtectedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProtectedDemo
{
    
    public class D2:Base
    {
        public void M()
        {
            base.M();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
