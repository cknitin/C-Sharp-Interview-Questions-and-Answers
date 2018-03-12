using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestLibrary
{
    public class Test1
    {
        internal int Number { get; set; }
        protected internal int Number1 { get; set; }
    }

    public class Test2
    {
        public Test2()
        {
            Test1 t1 = new Test1();
            t1.Number = 10;
            t1.Number1 = 20;
        }
    }

}
